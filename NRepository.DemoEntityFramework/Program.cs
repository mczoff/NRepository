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
        static void Main(string[] args)
        {
            IRepositoryBuilder repositoryBuilder = new RepositoryBuilder();

            CarDbContext cardbContext = new CarDbContext();

            //var repository = new TestRepo();

            var repository = repositoryBuilder
                .SetSource(new EntityFrameworkRepositoryTransferSource<Car, CarEntity>(cardbContext.Cars, CastEntityToModel))
                .Build<ICarRepository>();

            var cars = repository.Select();
        }


        private static Car CastEntityToModel(CarEntity caeEntity)
            => new Car { Id = caeEntity.Id, Value = caeEntity.Value };
    }
}
