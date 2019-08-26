using NRepository.EntityFramework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.EntityFramework
{
    public static class RepositoryBuilderEFHelper
    {
        public static IRepositoryBuilder SetSource<TModel>(this IRepositoryBuilder repositoryBuilder, EntityFrameworkRepositorySource<TModel> repositorySource)
            where TModel : class
        {
            repositoryBuilder.RepositorySource = repositorySource;

            return repositoryBuilder;
        }

        public static IRepositoryBuilder SetSource<TModel, TEntity>(this IRepositoryBuilder repositoryBuilder, EntityFrameworkRepositoryTransferSource<TModel, TEntity> repositorySource)
            where TEntity : class
        {
            repositoryBuilder.RepositorySource = repositorySource;

            return repositoryBuilder;
        }
    }
}
