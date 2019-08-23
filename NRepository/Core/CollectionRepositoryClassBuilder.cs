using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;
using NRepository.Abstraction.Core;
using NRepository.Attributes;
using NRepository.Params;
using NRepository.Templates;

namespace NRepository.Core
{
    public class CollectionRepositoryClassBuilder
        : RepositoryClassBuilder
    {
        public CollectionRepositoryClassBuilder()
        {
            RequiredAssemblies.Add("System.Core.dll");
        }

        public override TRepository CreateRepositoryInstance<TRepository>(object repositorySource)
        {
            CollectionRepositoryTemplate enumerableRepositoryTemplate = new CollectionRepositoryTemplate();

            var repositoryName = typeof(TRepository).Name.TrimStart('I', 'i');

            var key = repositorySource.GetType().GenericTypeArguments[0].GetProperties().FirstOrDefault(t => t.GetCustomAttribute<RepositoryKeyAttribute>() != null);

            if (key == null)
                throw new Exception();

            CollectionRepositoryTemplateParams enumerableRepositoryTemplateParams = new CollectionRepositoryTemplateParams
            {
                Name = repositoryName,
                Interface = typeof(TRepository).Name,
                FullNameModel = repositorySource.GetType().GenericTypeArguments[0].FullName,
                KeyName = key.Name,
                KeyType = key.PropertyType.FullName,
                Contract = GenerateRepositoryContract(typeof(TRepository).GetInterfaces())
            };

            enumerableRepositoryTemplate.Session = new Dictionary<string, object>
            {
                {  "Params", enumerableRepositoryTemplateParams }
            };

            enumerableRepositoryTemplate.Initialize();
            string code = enumerableRepositoryTemplate.TransformText();

            using (CSharpCodeProvider compiler = new CSharpCodeProvider())
            {
                var compileParams = new CompilerParameters
                {
                    GenerateInMemory = true,
                };

                var entryAssembly = Assembly.GetEntryAssembly().Modules.First();

                compileParams.ReferencedAssemblies.AddRange(RequiredAssemblies.Concat(new[] { entryAssembly.Name }).ToArray());

                var result = compiler.CompileAssemblyFromSource(compileParams, code);

                //Result Has Errors

                var repositoryType = Array.Find(result.CompiledAssembly.GetTypes(), t => t.Name == repositoryName);

                return (TRepository)Activator.CreateInstance(repositoryType, new object[] { repositorySource });
            }
        }
    }
}

