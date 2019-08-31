using NRepository.Abstractions.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NRepository.Core
{
    /// <summary>
    /// Collection source for collection source class builders
    /// </summary>
    /// <typeparam name="TModel">Model repository</typeparam>
    public sealed class CollectionRepositorySource<TModel>
    {
        public ICollection<TModel> Collection { get; set; }

        public CollectionRepositorySource()
        {
            Collection = new Collection<TModel>();
        }

        public CollectionRepositorySource(ICollection<TModel> collection)
        {
            Collection = collection ?? throw new ArgumentNullException("Initialize collection was null");
        }
    }
}
