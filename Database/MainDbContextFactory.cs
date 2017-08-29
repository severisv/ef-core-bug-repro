using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace App.DAL.Database
{

    // Denne brukes bare av kommandolinja (dotnet ef osv)
    public class MainDbContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=.\\SQLEXPRESS;Database=App;Trusted_Connection=True";
            var builder = new DbContextOptionsBuilder<DatabaseContext>();

            builder.UseSqlServer(connectionString);

            return new DatabaseContext(builder.Options);
        }


    }

}
