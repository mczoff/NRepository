using NRepository.Attributes;

namespace NRepository.Abstractions
{
    [RepositoryContract("IsDelete")]
    public interface IDeleteRepository<TModel, TKey>
    {
        void Delete(TModel model);

        void Delete(TKey key);
    }
}
