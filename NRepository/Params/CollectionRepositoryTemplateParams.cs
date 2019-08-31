using NRepository.Abstractions.Core;
using NRepository.Models;

namespace NRepository.Params
{
    /// <summary>
    /// Params for collection repository Template
    /// </summary>
    public class CollectionRepositoryTemplateParams
        : IRepositoryTemplateParams
    {
        public string Name { get; set; }
        public string NameSpace { get; set; }
        public string Interface { get; set; }
        public string FullNameModel { get; set; }
        public string KeyName { get; set; }
        public string KeyType { get; set; }

        public RepositoryContract Contract { get; set; }
    }
}
