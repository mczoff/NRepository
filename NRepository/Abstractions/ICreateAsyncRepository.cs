using NRepository.Attributes;
using System.Threading.Tasks;

namespace NRepository.Abstractions
{
    /// <summary>
    /// Interface creating row in container. Async implementation.
    /// </summary>
    /// <typeparam name="TModel">Model repository</typeparam>
    /// <typeparam name="TKey">Key repository</typeparam>
    [RepositoryContract("IsCreateAsync")]
    public interface ICreateAsyncRepository<TModel, TKey>
    {
        Task<TKey> CreateAsync(TModel model);
    }
}
