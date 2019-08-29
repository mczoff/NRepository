using NRepository.Models;

namespace NRepository.Abstractions.Core
{
    /// <summary>
    /// Default params for repository templates 
    /// </summary>
    public interface IRepositoryTemplateParams
    {
        /// <summary>
        /// Class name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Class namespace
        /// </summary>
        string NameSpace { get; set; }

        /// <summary>
        /// Class main interface
        /// </summary>
        string Interface { get; set; }

        /// <summary>
        /// Class model full name
        /// </summary>
        string FullNameModel { get; set; }

        /// <summary>
        /// Class model key name
        /// </summary>
        string KeyName { get; set; }

        /// <summary>
        /// Class model type name
        /// </summary>
        string KeyType { get; set; }

        /// <summary cref="RepositoryContract">
        /// RepositoryContract
        /// </summary>
        RepositoryContract Contract { get; set; }
    }
}
