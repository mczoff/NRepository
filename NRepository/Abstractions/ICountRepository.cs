using NRepository.Attributes;

namespace NRepository.Abstractions
{
    /// <summary>
    /// Interface return count rows in container.
    /// </summary>
    [RepositoryContract("IsCount")]
    public interface ICountRepository
    {
        int Count();
    }
}
