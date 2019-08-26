using NRepository.Abstractions.Core;
using NRepository.Core;
using NRepository.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository
{
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
