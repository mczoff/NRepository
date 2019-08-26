using NRepository.Attributes;

namespace NRepository.Abstractions
{
    [RepositoryContract("IsUpdate")]
    public interface IUpdateRepository<TModel, TKey>
    {
        TKey Update(TModel model);
    }
}
