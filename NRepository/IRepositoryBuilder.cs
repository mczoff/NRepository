using NRepository.Abstractions.Core;
using NRepository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository
{
    public interface IRepositoryBuilder
    {
        object RepositorySource { get; set; }

        IRepositoryBuilder SetSource<TModel>(CollectionRepositorySource<TModel> repositorySource);

        T Build<T>();
    }
}
