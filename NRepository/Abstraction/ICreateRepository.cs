using NRepository.Attributes;

namespace NRepository.Abstraction
{
    [RepositoryContract("IsCreate")]
    public interface ICreateRepository<TModel, TKey>
    {
        TKey Create(TModel model);
    }
}
