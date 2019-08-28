using Microsoft.CSharp;
using NRepository.Abstractions.Core;
using NRepository.Attributes;
using NRepository.Core;
using NRepository.EntityFramework.Params;
using NRepository.EntityFramework.Templates;
using NRepository.Models;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.EntityFramework.Core
{
    public class EntityFrameworkRepositoryClassBuilder
        : IRepositoryClassBuilder
    {
        public List<string> RequiredAssemblies { get; set; }
        public IRepositoryContractProvider ContractProvider { get; set; }

        public EntityFrameworkRepositoryClassBuilder()
        {
            ContractProvider = new DefaultRepositoryContractProvider();

            RequiredAssemblies = new List<string>
            {
                "NRepository.EntityFramework",
                "NRepository",
                "System.Runtime",
                "EntityFramework",
                "System.Core",
                "System.Data"
            };
        }

        //TODO: Check type RepositoryId and TKey and TEntity
        public TRepository CreateRepositoryInstance<TRepository>(object repositorySource)
        {
            var template = new EntityFrameworkRepositoryTemplate();

            var repositoryName = typeof(TRepository).Name.TrimStart('I', 'i');

            var keyModel = repositorySource.GetType().GenericTypeArguments[0].GetProperties().FirstOrDefault(t => t.GetCustomAttribute<RepositoryKeyAttribute>() != null);

            if (keyModel == null)
                throw new Exception();

            EntityFrameworkRepositoryTemplateParams entityFrameworkRepositoryTransferTemplateParams = new EntityFrameworkRepositoryTemplateParams
            {
                Name = repositoryName,
                Interface = typeof(TRepository).Name,
                NameSpace = typeof(TRepository).Namespace,
                FullNameModel = repositorySource.GetType().GenericTypeArguments[0].FullName,
                KeyName = keyModel.Name,
                KeyType = keyModel.PropertyType.FullName,
                Contract = ContractProvider.GenerateRepositoryContract(typeof(TRepository).GetInterfaces())
            };

            template.Session = new Dictionary<string, object>
            {
                {  "Params", entityFrameworkRepositoryTransferTemplateParams }
            };

            template.Initialize();
            string code = template.TransformText();

            using (CSharpCodeProvider compiler = new CSharpCodeProvider())
            {
                var compileParams = new CompilerParameters
                {
                    GenerateInMemory = true,
                };

                var assemblyModule = repositorySource.GetType().GenericTypeArguments[0].Assembly.Modules.First();

                compileParams.ReferencedAssemblies.AddRange(RequiredAssemblies.Select(t => Assembly.LoadWithPartialName(t).Modules.First().FullyQualifiedName).Concat(new[] { assemblyModule.FullyQualifiedName }).ToArray());

                var result = compiler.CompileAssemblyFromSource(compileParams, code);

                var repositoryType = Array.Find(result.CompiledAssembly.GetTypes(), t => t.Name == repositoryName);

                return (TRepository)Activator.CreateInstance(repositoryType, new object[] { repositorySource });
            }
        }
    }
}
