using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Abstractions
{
    public interface ICountAsyncRepository
    {
        Task CountAsync();
    }
}
