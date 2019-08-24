using NRepository.Abstraction;
using NRepository.Samples.Collections.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Samples.Collections.Repositories
{
    public interface ICarRepository
        : ISelectAsyncRepository<Car, int>,
          IDeleteAsyncRepository<Car, int>,
          ICreateAsyncRepository<Car, int>,
          IUpdateAsyncRepository<Car, int>
    {
    }
}
