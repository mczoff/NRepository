using NRepository.Abstractions.Core;
using NRepository.Attributes;
using NRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NRepository.Core
{
    public abstract class RepositoryClassBuilder : IRepositoryClassBuilder
    {
        public List<string> RequiredAssemblies { get; set; }
        protected RepositoryClassBuilder()
        {
            var fullpathNRepositoryAssembly = Assembly.Load("NRepository").Modules.First().FullyQualifiedName;

            RequiredAssemblies = new List<string> { fullpathNRepositoryAssembly, "System.Runtime.dll" };
        }
        public abstract TRepository CreateRepositoryInstance<TRepository>(object repositorySource);

        public RepositoryContract GenerateRepositoryContract(Type[] typeInterfaces)
        {
            RepositoryContract repositoryContract = new RepositoryContract();

            foreach (var typeInterface in typeInterfaces)
            {
                var contactProperty = typeInterface.GetCustomAttribute<RepositoryContractAttribute>()?.ContractProperty;

                if (contactProperty == null)
                    continue;

                var propertyInfo = repositoryContract.GetType().GetProperty($"{contactProperty}");
                propertyInfo.SetValue(repositoryContract, true);
            }

            return repositoryContract;
        }
    }
}
