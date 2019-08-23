using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Abstraction.Core
{
    public interface IRepositoryProvider
    {
        object Select(object collection, object key);
    }
}
