using NRepository.Attributes;
using System.Threading.Tasks;

namespace NRepository.Abstraction
{
    [RepositoryContract("IsSelectAsync")]
    public interface ISelectAsyncRepository<TModel, TKey>
    {
        Task<TModel> SelectAsync(TKey key);
    }
}
