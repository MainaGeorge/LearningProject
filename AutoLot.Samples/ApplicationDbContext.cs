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

            modelBuilder.Entity<Car>(c =>
            {
                c.Property(p => p.IsDrivable)
                    .HasField("_isDrivable")
                    .HasDefaultValue(true);
                c.Property(p => p.FullName)
                    .HasComputedColumnSql("[PetName] + ' (' + [Color] + ' )'", stored:true);
            });
        }

        private void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
        }
    }
}
