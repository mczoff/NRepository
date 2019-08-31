using NRepository.Models;
using System;

namespace NRepository.Abstractions.Core
{
    /// <summary>
    /// Interface analyze repository interfaces
    /// </summary>
    internal interface IRepositoryContractProvider
    {
        /// <summary>
        /// Generate RepositoryContract by using interfaces
        /// </summary>
        /// <param name="typeInterfaces"></param>
        /// <returns cref="RepositoryContract">Contract</returns>
        RepositoryContract GenerateRepositoryContract(Type[] typeInterfaces);
    }
}
