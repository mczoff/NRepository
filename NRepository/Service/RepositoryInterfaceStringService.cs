using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Service
{
    public class RepositoryInterfaceStringService
    {
        public string Generate(Type type)
        {
            string nameSpaceType = type.Namespace;
            string typeName = type.Name.Substring(0, type.Name.Length - 2);
            Type[] countGenericTypes = type.GetGenericArguments();

            return $"{nameSpaceType}.{typeName}<{string.Join(", ", countGenericTypes.Select(t => t.FullName))}>";
        }
    }
}
