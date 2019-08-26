﻿using NRepository.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Tests.Utils
{
    public interface IGuidKeyTestSelectRepository
        : ISelectRepository<GuidKeyTestItem, Guid>
    {
    }
}