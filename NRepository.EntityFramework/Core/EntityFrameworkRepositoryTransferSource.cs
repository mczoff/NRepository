using NRepository.Abstractions.Core;
using System;
using System.Data.Entity;

namespace NRepository.EntityFramework.Core
{
    public class EntityFrameworkRepositoryTransferSource<TModel, TEntity> : IRepositorySource<TModel>
        where TEntity : class
    {
        public IDbSet<TEntity> DbSet { get; set; }
        public Func<TEntity, TModel> CastDelegate { get; set; }

        public EntityFrameworkRepositoryTransferSource(IDbSet<TEntity> dbSet, Func<TEntity, TModel> castDelegate)
        {
            DbSet = dbSet ?? throw new ArgumentNullException("Initialize dbset was null");

            CastDelegate = castDelegate;
        }
    }
}
