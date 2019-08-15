using NRepository.Abstraction.Core;
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
        private object _repositorySource;

        public TRepository Build<TRepository>()
        {
            return RepositoryFactory.Create<TRepository>(_repositorySource);
        }

        public IRepositoryBuilder SetSource<TModel>(IRepositorySource<TModel> repositorySource)
        {
            _repositorySource = repositorySource;

            return this;
        }
    }
}
