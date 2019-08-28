using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Abstractions.Core
{
    public interface IRepositoryClassBuilder
    {
        List<string> RequiredAssemblies { get; set; }

        IRepositoryContractProvider ContractProvider { get; set; }

        TRepository CreateRepositoryInstance<TRepository>(object repositorySource);
    }
}
