using NRepository.Attributes;

namespace NRepository.Abstraction
{
    [RepositoryContract("IsDelete")]
    public interface IDeleteRepository<TKey>
    {
        void Delete(TKey key);
    }
}
