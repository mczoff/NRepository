using NRepository.Abstractions.Core;
using NRepository.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Models
{
    public class DefaultRepositoryContractProvider
        : IRepositoryContractProvider
    {
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
