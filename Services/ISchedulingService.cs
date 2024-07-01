using Recycle.Entities;
using Recycle.Models;

namespace Recycle.Services
{
    public interface ISchedulingService
    {
        SchedulingDto GetById(int id);
        List<SchedulingDto> GetAll();
        SchedulingDto Add(SchedulingDto truck);
        SchedulingDto Update(SchedulingDto truck, int id);
        void Delete(int id);
    }
}
