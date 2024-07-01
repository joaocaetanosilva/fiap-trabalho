using Microsoft.EntityFrameworkCore;
using Recycle.Entities;
using Recycle.Repository.Map;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Recycle.Repositories.Context
{
    public class RecycleContext : DbContext
    {
        public DbSet<Truck> Truck { get; set; }

        public RecycleContext(DbContextOptions<RecycleContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TruckMap());

        }
        public DbSet<Truck> Scheduling { get; set; }

        public RecycleContext(DbContextOptions<RecycleContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TruckMap());

        }

    }
}
