using NRepository.Attributes;
using System.Threading.Tasks;

namespace NRepository.Abstractions
{
    [RepositoryContract("IsSelectAsync")]
    public interface ISelectAsyncRepository<TModel, TKey>
    {
        Task<TModel> SelectAsync(TKey key);
        Task<TModel[]> SelectAsync();
    }
}
