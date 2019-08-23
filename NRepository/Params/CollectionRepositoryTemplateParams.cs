using NRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Params
{
    public class CollectionRepositoryTemplateParams
    {
        public string Name { get; set; }
        public string Interface { get; set; }
        public string FullNameModel { get; set; }
        public string KeyName { get; set; }

        public RepositoryContract Contract { get; set; }
    }
}
