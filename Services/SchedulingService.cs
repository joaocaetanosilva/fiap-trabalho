using Recycle.Entities;
using Recycle.Models;
using Recycle.Repositories;
using Recycle.Repository;
using System.Text.RegularExpressions;

namespace Recycle.Services
{
    public class SchedulingService : ISchedulingService
    {
        private ISchedulingRepository _schedulingRepository;
        public SchedulingService(ITruckRepository _schedulingRepository)
        {
            this._schedulingRepository = _schedulingRepository;
        }
        public List<TruckDto> GetAll()
        {

            List<TruckDto> list = new List<TruckDto>();

            list = _schedulingRepository.GetAll()
            .Select(g => new TruckDto
            {
                Id = g.Id,
                Placa = g.Placa,
            }).ToList();

            return list;
        }
        public TruckDto GetById(int id)
        {
            var response = new TruckDto();
            var truckDto = _schedulingRepository.GetById(id);
            if (truckDto != null)
            {
                response.Id = truckDto.Id;
                response.Placa = truckDto.Placa;

            }
            return response;
        }
        public TruckDto Add(TruckDto truck)
        {
            var response = _schedulingRepository.Add(new Truck()
            {
             Placa = truck.Placa
             
            });
            truck.Id = response.Id;
            return truck;
        }
        public TruckDto Update(TruckDto truckDto, int id)
        {

            var truck = this._schedulingRepository.GetById(id);
            if (truck != null) {
                truck.Placa = truckDto.Placa;
                this._schedulingRepository.Update(truck);
                
            }
            return truckDto;
        }
        public void Delete(int id)
        {
            var truck = this._schedulingRepository.GetById(id);
            if (truck != null){
                this._schedulingRepository.Delete(truck);
            }
        }
    }
}

}
