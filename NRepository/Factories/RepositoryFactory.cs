using NRepository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Factories
{
    public static class RepositoryFactory
    {
        public static TRepository Create<TRepository>(object repositorySource)
        {
            RepositoryClassBuilder repositoryClassBuilder = new EnumerableRepositoryClassBuilder();

            return repositoryClassBuilder.CreateRepositoryInstance<TRepository>();
        }
    }
}
