using NRepository.Abstraction.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Core
{
    public class EnumerableRepositorySource<TModel>
        : IRepositorySource<TModel>
    {
        private IEnumerable<TModel> _enumerable;

        public EnumerableRepositorySource(IEnumerable<TModel> enumerable)
        {
            _enumerable = enumerable;
        }
    }
}
