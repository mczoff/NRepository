using NRepository.EntityFramework;
using NRepository.EntityFramework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.DemoEntityFramework
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IRepositoryBuilder repositoryBuilder = new RepositoryBuilder();

            CarDbContext cardbContext = new CarDbContext();

            var repository = repositoryBuilder
                .SetSource(new EntityFrameworkRepositorySource<CarEntity>(cardbContext, cardbContext.Cars))
                .Build<ICarRepository>();

            var cars = await repository.SelectAsync();
        }
    }
}
