using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Abstraction.Core
{
    internal interface IAssemblyLoader
    {
        Assembly GetEntryAssembly();
    }
}
