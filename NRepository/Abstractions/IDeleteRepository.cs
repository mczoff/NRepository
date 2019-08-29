using NRepository.Attributes;

namespace NRepository.Abstractions
{
    /// <summary>
    /// Interface deleting row in container.
    /// </summary>
    /// <typeparam name="TModel">Model repository</typeparam>
    /// <typeparam name="TKey">Key repository</typeparam>
    [RepositoryContract("IsDelete")]
    public interface IDeleteRepository<TModel, TKey>
    {
        void Delete(TModel model);

        void Delete(TKey key);
    }
}
