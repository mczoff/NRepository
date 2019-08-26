using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    public sealed class RepositoryPolicyAttribute : Attribute
    {
        public RepositoryPolicyAttribute(Type repositorySourceType)
        {
            this.RepositorySourceType = repositorySourceType;
        }

        public Type RepositorySourceType { get; set; }

    }
}
