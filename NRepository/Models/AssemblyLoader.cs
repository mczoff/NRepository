using NRepository.Abstractions.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Models
{
    public class AssemblyLoader
        : IAssemblyLoader
    {
        public Assembly GetEntryAssembly()
        {
            throw new NotImplementedException();
        }
    }
}
