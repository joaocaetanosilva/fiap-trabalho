using Microsoft.EntityFrameworkCore;
using Recycle.Entities;
using Recycle.Entities;
using Recycle.Models;
using Recycle.Repositories;
using Recycle.Repositories.Context;
using System.Text.RegularExpressions;

namespace Recycle.Repositories
{
    public class SchedulingRepository : ISchedulingRepository
    {
        protected readonly RecycleContext context;
        protected readonly DbSet<Scheduling> db;

        public SchedulingRepository(RecycleContext context) {
            this.context = context;
            this.db = context.Set<Scheduling>();
        }

        public IEnumerable<Scheduling> GetAll()
        {
            return this.db
                .ToList();
        }
        public Scheduling GetById(int id)
        {
            return this.db
               .FirstOrDefault(e => e.Id == id);
        }
        public Scheduling Add(Scheduling entity)
        {
            Scheduling data = this.db.Add(entity).Entity;
            this.context.SaveChanges();

            return data;
        }

        public void Update(Scheduling entity)
        {
            var data = this.context.Update(entity);
            this.context.SaveChanges();

        }

        public void Delete(Scheduling entity)
        {
            this.db.Remove(entity);
            this.context.SaveChanges();
        }
    }
}
