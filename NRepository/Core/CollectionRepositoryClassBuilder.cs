using Microsoft.CSharp;
using NRepository.Attributes;
using NRepository.Params;
using NRepository.Templates;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NRepository.Core
{
    public class CollectionRepositoryClassBuilder : RepositoryClassBuilder
    {
        public CollectionRepositoryClassBuilder()
        {
            RequiredAssemblies.Add("System.Core.dll");
        }


        //TODO: Check type RepositoryId and TKey
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
                NameSpace = typeof(TRepository).Namespace,
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

                var assemblyModule = repositorySource.GetType().GenericTypeArguments[0].Assembly.Modules.First();

                compileParams.ReferencedAssemblies.AddRange(RequiredAssemblies.Concat(new[] { assemblyModule.FullyQualifiedName }).ToArray());

                var result = compiler.CompileAssemblyFromSource(compileParams, code);

                var repositoryType = Array.Find(result.CompiledAssembly.GetTypes(), t => t.Name == repositoryName);

                return (TRepository)Activator.CreateInstance(repositoryType, new object[] { repositorySource });
            }
        }
    }
}

