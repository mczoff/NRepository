using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Abstraction
{
    public interface IDeleteAsyncRepository<TKey>
    {
        Task Delete(TKey key);
    }
}
