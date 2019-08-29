using System;

namespace NRepository.Attributes
{
    /// <summary>
    /// Key in repository models
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    public sealed class RepositoryKeyAttribute
        : Attribute
    {
    }
}
