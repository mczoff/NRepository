using NRepository.Abstraction.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository
{
    public interface IRepositoryBuilder
    {
        IRepositoryBuilder SetSource<TModel>(IRepositorySource<TModel> repositorySource);

        T Build<T>();
    }
}
