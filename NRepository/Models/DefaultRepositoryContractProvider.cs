using NRepository.Abstractions.Core;
using NRepository.Attributes;
using System;
using System.Reflection;

namespace NRepository.Models
{
    /// <summary>
    /// Alanyze collection repository interfaces and provide repository contract
    /// </summary>
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
