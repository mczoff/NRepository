using NRepository.Core;
using NRepository.Samples.Collections.Models;
using NRepository.Samples.Collections.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NRepository.Samples.Collections
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IList<Car> cars = new List<Car>
            {
                new Car { Id = 0, Name = "BMW" },
                new Car { Id = 1, Name = "Honda" },
                new Car { Id = 2, Name = "Chevrolet" }
            };

            IRepositoryBuilder repositoryBuilder = new RepositoryBuilder();

            var repository = repositoryBuilder
                .SetSource(new CollectionRepositorySource<Car>(cars))
                .Build<ICarRepository>();

            var selectedCar = repository.SelectAsync(0);

            //KeyNotFoundException();

            //ArgumentException

            repository.CreateAsync(new Car { Id = 3, Name = "Mazda" });

            repository.DeleteAsync(3);

            var items = await repository.SelectAsync();
            items.ToList().ForEach(t => Console.WriteLine($"Car [{t.Id}] - {t.Name} "));
        }
    }
}
