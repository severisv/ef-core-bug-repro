using App.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.Database
{

    public class DatabaseContext : DbContext
    {
        public DbSet<ExampleEntity> Entities { get; set; }

        public DatabaseContext() { }

        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }


    }
}
