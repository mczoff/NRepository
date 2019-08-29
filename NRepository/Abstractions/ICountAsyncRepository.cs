using System.Threading.Tasks;

namespace NRepository.Abstractions
{
    /// <summary>
    /// Interface return count rows in container. Async implementation
    /// </summary>
    public interface ICountAsyncRepository
    {
        Task CountAsync();
    }
}
