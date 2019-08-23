using System;

namespace NRepository.Attributes
{
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
