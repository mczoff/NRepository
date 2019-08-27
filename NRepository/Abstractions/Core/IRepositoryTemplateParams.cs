using NRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Abstractions.Core
{
    public interface IRepositoryTemplateParams
    {
        string Name { get; set; }
        string NameSpace { get; set; }
        string Interface { get; set; }
        string FullNameModel { get; set; }
        string KeyName { get; set; }
        string KeyType { get; set; }

        RepositoryContract Contract { get; set; }
    }
}
