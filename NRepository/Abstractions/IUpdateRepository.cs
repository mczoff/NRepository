using NRepository.Attributes;

namespace NRepository.Abstractions
{
    /// <summary>
    /// Interface updating row in container.
    /// </summary>
    /// <typeparam name="TModel">Model repository</typeparam>
    /// <typeparam name="TKey">Key repository</typeparam>
    [RepositoryContract("IsUpdate")]
    public interface IUpdateRepository<TModel, TKey>
    {
        TKey Update(TModel model);
    }
}
