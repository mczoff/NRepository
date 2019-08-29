using NRepository.Attributes;
using System.Threading.Tasks;

namespace NRepository.Abstractions
{
    /// <summary>
    /// Interface deleting row in container. Async implementation.
    /// </summary>
    /// <typeparam name="TModel">Model repository</typeparam>
    /// <typeparam name="TKey">Key repository</typeparam>
    [RepositoryContract("IsDeleteAsync")]
    public interface IDeleteAsyncRepository<TModel, TKey>
    {
        Task DeleteAsync(TModel model);
        Task DeleteAsync(TKey key);
    }
}
