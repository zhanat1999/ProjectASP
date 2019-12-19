using CarCity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCity.Data
{
    public class DBContext : IdentityDbContext<User>
    {
        public DBContext(DbContextOptions options) : base(options)
        {
        }

        public DBContext() { }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasOne(p => p.role).WithMany(i => i.User);
            //modelBuilder.Entity<CarOwner>().HasKey(sca => new { sca.CarId, sca.OwnerId });
            //modelBuilder.Entity<Car>().HasOne(p => p.year).WithMany(i => i.Car);
            //modelBuilder.Entity<Car>().HasOne(p => p.type).WithMany(i => i.Car);
            //modelBuilder.Entity<Car>().HasOne(p => p.city).WithMany(i => i.Car);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Types> Types { get; set; }
        public DbSet<Year> Years { get; set; }

    }
}
