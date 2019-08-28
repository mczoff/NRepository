using System.Data.Entity;

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
