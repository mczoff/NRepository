using NRepository.Core;
using NRepository.Factories;

namespace NRepository
{
    /// <summary>
    /// Build repositoties with params
    /// </summary>
    public class RepositoryBuilder
        : IRepositoryBuilder
    {
        public object RepositorySource { get; set; }

        public TRepository Build<TRepository>()
        {
            return RepositoryFactory.Create<TRepository>(RepositorySource);
        }

        public IRepositoryBuilder SetSource<TModel>(CollectionRepositorySource<TModel> repositorySource)
        {
            RepositorySource = repositorySource;

            return this;
        }
    }
}
