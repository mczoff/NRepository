using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Abstraction
{
    public interface ISelectRepository<TModel, TKey>
    {
        TModel Select(TKey key);
    }
}
