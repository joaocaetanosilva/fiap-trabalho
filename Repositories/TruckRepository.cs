using Microsoft.EntityFrameworkCore;
using Recycle.Entyties;
using Recycle.Models;
using Recycle.Repositories;
using Recycle.Repositories.Context;
using System.Text.RegularExpressions;

namespace Recycle.Repositories
{
    public class TruckRepository : ITruckRepository 
    {
        protected readonly RecycleContext context;
        protected readonly DbSet<Truck> db;

        public TruckRepository(RecycleContext context) {
            this.context = context;
            this.db = context.Set<Truck>();
        }

        public IEnumerable<Truck> GetAll()
        {
            return this.db
                .ToList();
        }
        public Truck GetById(int id)
        {
            return this.db
               .FirstOrDefault(e => e.Id == id);
        }
        public Truck Add(Truck entity)
        {
            Truck data = this.db.Add(entity).Entity;
            this.context.SaveChanges();

            return data;
        }

        public void Update(Truck entity)
        {
            var data = this.context.Update(entity);
            this.context.SaveChanges();

        }

        public void Delete(Truck entity)
        {
            this.db.Remove(entity);
            this.context.SaveChanges();
        }
    }
}
