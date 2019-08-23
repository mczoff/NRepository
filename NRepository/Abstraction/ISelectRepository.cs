using NRepository.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Abstraction
{
    [RepositoryContract("IsSelect")]
    public interface ISelectRepository<TModel, TKey>
    {
        TModel Select(TKey key);
        TModel[] Select();
    }
}
