using NRepository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.DemoEntityFramework
{
    public interface ICarRepository 
        : ISelectAsyncRepository<CarEntity, int>,
          IDeleteAsyncRepository<CarEntity, int>, 
          IUpdateAsyncRepository<CarEntity, int>, 
          ICreateAsyncRepository<CarEntity, int>,
          IPaginationAsyncRepository<CarEntity>,
          ICountRepository
    {
    }
}
