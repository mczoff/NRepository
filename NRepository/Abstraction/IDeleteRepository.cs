using NRepository.Attributes;

namespace NRepository.Abstraction
{
    [RepositoryContract("IsDelete")]
    public interface IDeleteRepository<TModel, TKey>
    {
        void Delete(TModel key);

        void Delete(TKey key);
    }
}
