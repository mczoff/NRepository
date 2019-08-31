using NRepository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.DemoCollection
{
    public interface ISongRepository 
        : ISelectRepository<Song, int>, 
          IDeleteRepository<Song, int>, 
          ICreateRepository<Song, int>, 
          IUpdateRepository<Song, int>,
          IPaginationRepository<Song>,
          ICountAsyncRepository
    {
    }
}
