using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Params
{
    public class EnumerableRepositoryTemplateParams
    {
        public string Name { get; set; }
        public string Interface { get; set; }
        public string FullNameModel { get; set; }

        public bool IsSelectContract { get; set; }
    }
}
