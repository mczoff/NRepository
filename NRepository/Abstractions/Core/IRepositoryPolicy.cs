﻿using NRepository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Abstractions.Core
{
    public interface IRepositoryPolicy
    {
        RepositoryClassBuilder GetClassBuilder();
    }
}
