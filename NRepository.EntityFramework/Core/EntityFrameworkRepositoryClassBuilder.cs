using NRepository.Abstractions.Core;
using NRepository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.EntityFramework.Core
{
    public class EntityFrameworkRepositoryClassBuilder
        : IRepositoryClassBuilder
    {
        public List<string> RequiredAssemblies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRepositoryContractProvider ContractProvider { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public TRepository CreateRepositoryInstance<TRepository>(object repositorySource)
        {
            throw new NotImplementedException();
        }
    }
}
