using Recycle.Models;

namespace Recycle.Services
{
    public interface ITruckService
    {
        TruckDto GetById(int id);
        List<TruckDto> GetAll();
        TruckDto Add(TruckDto truck);
        TruckDto Update(TruckDto truck, int id);
        void Delete(int id);
    }
}
