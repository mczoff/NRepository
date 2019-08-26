using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRepository.DemoEntityFramework
{
    public class CarDbContext
        : DbContext
    {
        public CarDbContext()
            : base(@"Server=(localdb)\MSSQLLocaldb;Database=CarDb;")
        {

        }

        public DbSet<CarEntity> Cars { get; set; }
    }
}
