using NRepository.Attributes;
using System.Threading.Tasks;

namespace NRepository.Abstractions
{
    /// <summary>
    /// Interface selecting row in container. Async implementation.
    /// </summary>
    /// <typeparam name="TModel">Model repository</typeparam>
    /// <typeparam name="TKey">Key repository</typeparam>
    [RepositoryContract("IsSelectAsync")]
    public interface ISelectAsyncRepository<TModel, TKey>
    {
        Task<TModel> SelectAsync(TKey key);
        Task<TModel[]> SelectAsync();
    }
}
