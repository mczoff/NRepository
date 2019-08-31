using NRepository.Core;

namespace NRepository
{
    /// <summary>
    /// Build repositoties with params
    /// </summary>
    public interface IRepositoryBuilder
    {
        object RepositorySource { get; set; }

        IRepositoryBuilder SetSource<TModel>(CollectionRepositorySource<TModel> repositorySource);

        T Build<T>();
    }
}
