using NRepository.Abstraction.Core;
using NRepository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Core
{
    public abstract class RepositoryClassBuilder
    {
        public List<string> RequiredAssemblies { get; set; }

        protected RepositoryClassBuilder()
        {
            RequiredAssemblies = new List<string> { "NRepository.dll" };
        }

        public abstract TRepository CreateRepositoryInstance<TRepository>(object repositorySource);
    }
}
