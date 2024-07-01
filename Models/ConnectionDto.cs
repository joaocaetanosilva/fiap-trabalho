using Recycle.Entities;

namespace Recycle.Repositories
{
    public interface ITruckRepository
    {
        Scheduling GetById(int id);
        IEnumerable<Scheduling> GetAll();
        Truck Add(Scheduling scheduling);
        void Update(Scheduling scheduling);
        void Delete(Scheduling scheduling);
    }
}
