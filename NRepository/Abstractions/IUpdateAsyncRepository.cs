using NRepository.Attributes;
using System.Threading.Tasks;

namespace NRepository.Abstractions
{
    /// <summary>
    /// Interface updating row in container. Async implementation.
    /// </summary>
    /// <typeparam name="TModel">Model repository</typeparam>
    /// <typeparam name="TKey">Key repository</typeparam>
    [RepositoryContract("IsUpdateAsync")]
    public interface IUpdateAsyncRepository<TModel, TKey>
    {
        Task<TKey> UpdateAsync(TModel model);
    }
}
