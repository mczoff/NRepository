using NRepository.Abstractions.Core;
using System;
using System.Data.Entity;

namespace NRepository.EntityFramework.Core
{
    public class EntityFrameworkRepositorySource<TModel> : IRepositorySource<TModel>
        where TModel : class
    {
        public IDbSet<TModel> DbSet { get; set; }

        public EntityFrameworkRepositorySource(IDbSet<TModel> dbSet)
        {
            DbSet = dbSet ?? throw new ArgumentNullException("Initialize dbset was null");
        }
    }
}
