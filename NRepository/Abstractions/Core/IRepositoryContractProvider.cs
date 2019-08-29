using NRepository.Models;
using System;

namespace NRepository.Abstractions.Core
{
    /// <summary>
    /// Interface analyze repository interfaces
    /// </summary>
    public interface IRepositoryContractProvider
    {
        /// <summary>
        /// Generate RepositoryContract 
        /// </summary>
        /// <param name="typeInterfaces"></param>
        /// <returns cref="RepositoryContract">Contract</returns>
        RepositoryContract GenerateRepositoryContract(Type[] typeInterfaces);
    }
}
