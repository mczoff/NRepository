using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.DemoEntityFramework
{
    public class TestRepo
        : ICarRepository
    {
        public Car Select(int key)
        {
            return default;
        }

        public Car[] Select()
        {
            CarDbContext carDbContext = new CarDbContext();

            var ss = carDbContext.Cars.ToArray();

            return new[] { new Car { }, new Car { } };
        }
    }
}
