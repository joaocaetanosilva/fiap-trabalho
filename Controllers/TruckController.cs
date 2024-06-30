using Microsoft.AspNetCore.Mvc;
using Recycle.Models;
using Recycle.Services;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Recycle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TruckController : ControllerBase
    {
        private ITruckService _service;
        public TruckController(ITruckService _sevice) {
            this._service = _sevice;
        }
        // GET: api/<TruckController>
        [HttpGet]
        public ActionResult<TruckDto> GetAll()
        {
            return this.Ok(_service.GetAll());
        }

        // GET api/<TruckController>/5
        [HttpGet("{id}")]
        public ActionResult<TruckDto> GetById(int id)
        {
            return this.Ok(_service.GetById(id));
        }

        // POST api/<TruckController>
        [HttpPost]
        public ActionResult<TruckDto> Post([FromBody] TruckDto truckDto)
        {
            return this.Ok(_service.Add(truckDto)); 
        }

        // PUT api/<TruckController>/5
        [HttpPut("{id}")]
        public ActionResult<TruckDto> Put([FromBody] TruckDto truckDto, int id)
        {
            return _service.Update(truckDto, id);
        }

        // DELETE api/<TruckController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
