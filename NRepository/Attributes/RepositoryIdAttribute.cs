using System;

namespace NRepository.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
    public sealed class RepositoryIdAttribute
        : Attribute
    {
    }
}
