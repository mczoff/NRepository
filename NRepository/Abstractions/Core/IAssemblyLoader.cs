using System.Reflection;

namespace NRepository.Abstractions.Core
{
    internal interface IAssemblyLoader
    {
        Assembly GetEntryAssembly();
    }
}
