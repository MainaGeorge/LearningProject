using AutoLot.Samples.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoLot.Samples
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Make> Make { get; set; }
        public virtual DbSet<Radio> Radios { get; set; }    
        public virtual DbSet<Driver> Drivers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        private void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
        }
    }
}
