using Recycle.Entyties;

namespace Recycle.Repositories
{
    public interface ITruckRepository
    {
        Truck GetById(int id);
        IEnumerable<Truck> GetAll();
        Truck Add(Truck truck);
        void Update(Truck truck);
        void Delete(Truck truck);
    }
}
