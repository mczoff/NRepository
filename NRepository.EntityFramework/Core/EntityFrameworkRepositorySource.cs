using NRepository.Abstractions.Core;
using System;
using System.Data.Entity;

namespace NRepository.EntityFramework.Core
{
    public class EntityFrameworkRepositorySource<TModel>
        where TModel : class
    {
        public IDbSet<TModel> DbSet { get; set; }
        public DbContext DatabaseСontext { get; set; }

        public EntityFrameworkRepositorySource(DbContext dbcontext, IDbSet<TModel> dbSet)
        {
            DatabaseСontext = dbcontext ?? throw new ArgumentNullException("Initialize dbcontext was null");
            DbSet = dbSet ?? throw new ArgumentNullException("Initialize dbset was null");
        }
    }
}

