using NRepository.Attributes;
using System.Threading.Tasks;

namespace NRepository.Abstractions
{
    /// <summary>
    /// Interface return count rows in container. Async implementation
    /// </summary>
    [RepositoryContract("IsCountAsync")]
    public interface ICountAsyncRepository
    {
        Task<int> CountAsync();
    }
}
