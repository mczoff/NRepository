using NRepository.Abstractions.Core;
using NRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.EntityFramework.Params
{
    public class EntityFrameworkRepositoryTransferTemplateParams
        : IRepositoryTemplateParams
    {
        public string Name { get; set ; }
        public string NameSpace { get; set; }
        public string Interface { get; set; }
        public string FullNameModel { get; set; }
        public string KeyName { get; set; }
        public string KeyType { get; set; }
        public string FullNameEntity { get; set; }
        public string KeyEntityName { get; set; }
        public string KeyEntityType { get; set; }
        public RepositoryContract Contract { get; set; }
    }
}
