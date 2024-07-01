using Recycle.Entities;

namespace Recycle.Repositories
{
    public interface ISchedulingRepository
    {
        Scheduling GetById(int id);
        IEnumerable<Scheduling> GetAll();
        Scheduling Add(Scheduling Scheduling);
        void Update(Scheduling Scheduling);
        void Delete(Scheduling Scheduling);
    }
}
