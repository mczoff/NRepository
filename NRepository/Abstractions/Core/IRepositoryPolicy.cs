namespace NRepository.Abstractions.Core
{
    /// <summary>
    /// Marked classes for find RepositoryClassBuilders in project;
    /// </summary>
    public interface IRepositoryPolicy
    {
        /// <summary>
        /// Create module RepositoryClassBuilder
        /// </summary>
        /// <returns>Module RepositoryClassBuilder</returns>
        IRepositoryClassBuilder GetClassBuilder();
    }
}
