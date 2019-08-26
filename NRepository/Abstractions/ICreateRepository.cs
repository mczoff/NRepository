using NRepository.Attributes;

namespace NRepository.Abstractions
{
    [RepositoryContract("IsCreate")]
    public interface ICreateRepository<TModel, TKey>
    {
        TKey Create(TModel model);
    }
}
