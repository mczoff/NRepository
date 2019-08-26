using NRepository.Attributes;
using System.Threading.Tasks;

namespace NRepository.Abstractions
{
    [RepositoryContract("IsDeleteAsync")]
    public interface IDeleteAsyncRepository<TModel, TKey>
    {
        Task DeleteAsync(TModel key);
        Task DeleteAsync(TKey key);
    }
}
