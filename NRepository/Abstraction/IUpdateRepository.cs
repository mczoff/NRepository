using NRepository.Attributes;

namespace NRepository.Abstraction
{
    [RepositoryContract("IsUpdate")]
    public interface IUpdateRepository<TModel, TKey>
    {
        void Update(TModel model, TKey key);
    }
}
