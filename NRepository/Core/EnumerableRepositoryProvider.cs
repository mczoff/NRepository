﻿using NRepository.Abstraction.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Core
{
    public class EnumerableRepositoryProvider
        : IRepositoryProvider
    {
        public object Select(object collection, object key)
        {
            return Enumerable.FirstOrDefault(collection as IEnumerable<object>);
        }
    }
}
