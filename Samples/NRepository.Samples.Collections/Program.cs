using NRepository.Core;
using NRepository.Samples.Collections.Models;
using NRepository.Samples.Collections.Repositories;
using System;
using System.Collections.Generic;

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

            if (selectedCar != null)
                Console.WriteLine($"First selected car [{selectedCar.Id}] - {selectedCar.Name} ");
        }
    }
}
