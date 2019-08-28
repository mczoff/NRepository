using NRepository.Abstractions.Core;
using NRepository.Attributes;
using NRepository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Policies
{
    [RepositoryPolicy(typeof(CollectionRepositorySource<>))]
    public class CollectionPolicy
        : IRepositoryPolicy
    {
        public IRepositoryClassBuilder GetClassBuilder()
            => new CollectionRepositoryClassBuilder();
    }
}
