using System;

namespace NRepository.Attributes
{
    /// <summary cref="RepositoryContract">
    /// Attribute for interface`s contract and provides value of the property in repository contract
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface, Inherited = false, AllowMultiple = true)]
    internal sealed class RepositoryContractAttribute
        : Attribute
    {
        public string ContractProperty { get; set; }

        public RepositoryContractAttribute(string contractProperty)
        {
            ContractProperty = contractProperty;
        }
    }
}
