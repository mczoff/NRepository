using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.DemoEntityFramework
{
    public class TestRepo
    {
        CarDbContext carDbContext = new CarDbContext();

        public int Create(CarEntity model)
        {
            var item = carDbContext.Cars.Add(model);

            return item.Id;
        }

        public void Delete(CarEntity model)
        {
            carDbContext.Cars.Remove(model);
        }

        public void Delete(int key)
        {
            var item = carDbContext.Cars.FirstOrDefault(t => t.Id == key);

            //carDbContext.Cars.Remove(key);

            //carDbContext.Cars.

            //carDbContext.aveChanges();
        }

        public CarEntity Select(int key)
        {
            return default;
        }

        public CarEntity[] Select()
        {
            var ss = carDbContext.Cars.ToArray();

            return ss;
        }

        public int Update(CarEntity model)
        {
            //carDbContext.Cars.(model);
            return 0;
        }
    }
}

