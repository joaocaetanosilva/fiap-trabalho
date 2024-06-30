using Recycle.Entyties;
using Recycle.Models;
using Recycle.Repositories;
using Recycle.Repository;
using System.Text.RegularExpressions;

namespace Recycle.Services
{
    public class TruckService : ITruckService
    {
        private ITruckRepository _truckRepository;
        public TruckService(ITruckRepository _truckRepository)
        {
            this._truckRepository = _truckRepository;
        }
        public List<TruckDto> GetAll()
        {

            List<TruckDto> list = new List<TruckDto>();

            list = _truckRepository.GetAll()
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
            var truckDto = _truckRepository.GetById(id);
            if (truckDto != null)
            {
                response.Id = truckDto.Id;
                response.Placa = truckDto.Placa;

            }
            return response;
        }
        public TruckDto Add(TruckDto truck)
        {
            var response = _truckRepository.Add(new Truck()
            {
             Placa = truck.Placa
             
            });
            truck.Id = response.Id;
            return truck;
        }
        public TruckDto Update(TruckDto truckDto, int id)
        {

            var truck = this._truckRepository.GetById(id);
            if (truck != null) {
                truck.Placa = truckDto.Placa;
                this._truckRepository.Update(truck);
                
            }
            return truckDto;
        }
        public void Delete(int id)
        {
            var truck = this._truckRepository.GetById(id);
            if (truck != null){
                this._truckRepository.Delete(truck);
            }
        }
    }
}
