using NRepository.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Abstractions
{
    /// <summary>
    /// Interface selecting row in container.
    /// </summary>
    /// <typeparam name="TModel">Model repository</typeparam>
    /// <typeparam name="TKey">Key repository</typeparam>
    [RepositoryContract("IsSelect")]
    public interface ISelectRepository<TModel, TKey>
    {
        TModel Select(TKey key);
        TModel[] Select();
    }
}
