using NRepository.Core;
using NRepository.Samples.Collections.Models;
using NRepository.Samples.Collections.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.Samples.Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new[]
            {
                new Car { Id = 0, Name = "BMW" },
                new Car { Id = 1, Name = "Honda" },
                new Car { Id = 2, Name = "Chevrolet" }
            };

            IRepositoryBuilder repositoryBuilder = new RepositoryBuilder();

            var repository = repositoryBuilder
                .SetSource(new EnumerableRepositorySource<Car>(cars))
                .Build<ICarRepository>();

            var selectedCar = repository.Select(0);

            if (selectedCar != null)
                Console.WriteLine($"Selected car [{selectedCar.Id}] - {selectedCar.Name} ");
        }
    }
}
