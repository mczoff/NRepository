using NRepository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.DemoEntityFramework
{
    public interface ICarRepository
        : ISelectRepository<Car, int>
    {
    }
}
