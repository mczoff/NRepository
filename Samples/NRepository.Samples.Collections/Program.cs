using NRepository.Core;
using NRepository.Samples.Collections.Models;
using NRepository.Samples.Collections.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NRepository.Samples.Collections
{
    class Program
    {
        static void Main(string[] args)
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

            var selectedCar = repository.Select(0);

            //KeyNotFoundException();

            //ArgumentException

            repository.Create(new Car { Id = 3, Name = "Mazda" });

            repository.Delete(3);

            var items = repository.Select();
            items.ToList().ForEach(t => Console.WriteLine($"Car [{t.Id}] - {t.Name} "));
        }
    }
}
