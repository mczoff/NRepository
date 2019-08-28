using NRepository.Abstractions.Core;
using NRepository.Attributes;
using NRepository.Core;
using NRepository.EntityFramework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.EntityFramework.Policies
{
    [RepositoryPolicy(typeof(EntityFrameworkRepositorySource<>))]
    public class EntityFrameworkBuilderPolicy
        : IRepositoryPolicy
    {
        public IRepositoryClassBuilder GetClassBuilder()
            => new EntityFrameworkRepositoryClassBuilder();
    }
}
