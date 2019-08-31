using NRepository.Attributes;
using System.Threading.Tasks;

namespace NRepository.Abstractions
{
    /// <summary>
    /// Pagination interface. Async implementation.
    /// </summary>
    /// <typeparam name="TModel">Model repository</typeparam>
    [RepositoryContract("IsPaginationAsync")]
    public interface IPaginationAsyncRepository<TModel>
    {
        Task<TModel[]> SelectPageAsync(int page, int count);
    }
}
