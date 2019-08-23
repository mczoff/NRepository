using NRepository.Attributes;

namespace NRepository.Abstraction
{
    [RepositoryContract("IsUpdate")]
    public interface IUpdateRepository<TModel, TKey>
    {
        TKey Update(TModel model);
    }
}
