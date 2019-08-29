using System.Collections.Generic;

namespace NRepository.Abstractions.Core
{
    /// <summary>
    /// Base interface for repository class builders
    /// </summary>
    public interface IRepositoryClassBuilder
    {
        /// <summary>
        /// Required assemblies for repository assembly
        /// </summary>
        List<string> RequiredAssemblies { get; set; }

        /// <summary>
        /// ContactProvider for parsing repository interfaces
        /// </summary>
        IRepositoryContractProvider ContractProvider { get; set; }

        /// <summary>
        /// Create a TRepository 
        /// </summary>
        /// <param name="repositorySource">Source repository</param>
        /// <returns>Repository implemented TRepository</returns>
        TRepository CreateRepositoryInstance<TRepository>(object repositorySource);
    }
}
