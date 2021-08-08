using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AutoLot.Samples
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            const string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=AutoLotSamples; Trusted_Connection=True;MultipleActiveResultSets=true;";

            optionsBuilder.UseSqlServer(connectionString);

            Console.WriteLine(connectionString);

            return new ApplicationDbContext(optionsBuilder.Options);
        }

    }
}
