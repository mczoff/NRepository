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
using NRepository.Params;
using NRepository.Templates;

namespace NRepository.Core
{
    public class EnumerableRepositoryClassBuilder
        : RepositoryClassBuilder
    {
        public EnumerableRepositoryClassBuilder()
        {
            RequiredAssemblies.Add("System.Core.dll");
        }

        public override TRepository CreateRepositoryInstance<TRepository>(object repositorySource)
        {
            //var repositoryInterfaces = typeof(TRepository).GetInterfaces();

            EnumerableRepositoryTemplate enumerableRepositoryTemplate = new EnumerableRepositoryTemplate();

            var repositoryInterfaceType = typeof(TRepository);
            var repositoryName = repositoryInterfaceType.Name.TrimStart('I', 'i');
            var repositoryModel = repositorySource.GetType().GenericTypeArguments[0].FullName;

            EnumerableRepositoryTemplateParams enumerableRepositoryTemplateParams = new EnumerableRepositoryTemplateParams
            {
                Name = repositoryName,
                Interface = typeof(TRepository).Name,
                FullNameModel = repositoryModel
            };

            enumerableRepositoryTemplate.Session = new Dictionary<string, object>
            {
                {  "Params", enumerableRepositoryTemplateParams }
            };

            enumerableRepositoryTemplate.Initialize();
            string code = enumerableRepositoryTemplate.TransformText();

            CSharpCodeProvider compiler = new CSharpCodeProvider();
            var compileParams = new CompilerParameters
            {
                GenerateInMemory = true,
            };

            var entryAssembly = Assembly.GetEntryAssembly().Modules.First();

            compileParams.ReferencedAssemblies.AddRange(RequiredAssemblies.Concat(new[] { entryAssembly.Name }).ToArray());

            var result = compiler.CompileAssemblyFromSource(compileParams, code);

            var repositoryType = Array.Find(result.CompiledAssembly.GetTypes(), t => t.Name == "CarRepository");

            return (TRepository)Activator.CreateInstance(repositoryType, new object[] { repositorySource });
        }
    }
}
