using NRepository.Abstraction.Core;
using NRepository.Attributes;
using NRepository.Models;
using NRepository.Params;
using NRepository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Core
{
    public abstract class RepositoryClassBuilder
        : IRepositoryClassBuilder
    {
        public List<string> RequiredAssemblies { get; set; }
        protected RepositoryClassBuilder()
        {
            RequiredAssemblies = new List<string> { "NRepository.dll", "System.Runtime.dll" };
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
