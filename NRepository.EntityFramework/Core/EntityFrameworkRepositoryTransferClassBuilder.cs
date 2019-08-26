using NRepository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.EntityFramework.Core
{
    public class EntityFrameworkRepositoryTransferClassBuilder
        : RepositoryClassBuilder
    {
        public override TRepository CreateRepositoryInstance<TRepository>(object repositorySource)
        {
            throw new NotImplementedException();
        }
    }
}
