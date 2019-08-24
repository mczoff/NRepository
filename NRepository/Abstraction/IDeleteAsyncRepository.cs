using NRepository.Attributes;
using System.Threading.Tasks;

namespace NRepository.Abstraction
{
    [RepositoryContract("IsDeleteAsync")]
    public interface IDeleteAsyncRepository<TModel, TKey>
    {
        Task DeleteAsync(TModel key);
        Task DeleteAsync(TKey key);
    }
}
