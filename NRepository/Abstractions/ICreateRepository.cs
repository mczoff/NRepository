using NRepository.Attributes;

namespace NRepository.Abstractions
{
    /// <summary>
    /// Interface creating row in container.
    /// </summary>
    /// <typeparam name="TModel">Model repository</typeparam>
    /// <typeparam name="TKey">Key repository</typeparam>
    [RepositoryContract("IsCreate")]
    public interface ICreateRepository<TModel, TKey>
    {
        TKey Create(TModel model);
    }
}
