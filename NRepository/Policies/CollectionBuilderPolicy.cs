using NRepository.Abstractions.Core;
using NRepository.Attributes;
using NRepository.Core;

namespace NRepository.Policies
{
    /// <summary>
    /// Collection policy
    /// </summary>
    [RepositoryPolicy(typeof(CollectionRepositorySource<>))]
    public class CollectionPolicy
        : IRepositoryPolicy
    {
        public IRepositoryClassBuilder GetClassBuilder()
            => new CollectionRepositoryClassBuilder();
    }
}
