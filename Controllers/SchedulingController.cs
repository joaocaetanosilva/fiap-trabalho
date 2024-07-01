using Microsoft.AspNetCore.Mvc;
using Recycle.Models;
using Recycle.Services;

namespace Recycle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class schedulingController : ControllerBase
    {
        private ISchedulingService _service;
        public schedulingController(ISchedulingService _sevice)
        {
            this._service = _sevice;
        }
        // GET: api/<SchedulingController>
        [HttpGet]
        public ActionResult<SchedulingDto> GetAll()
        {
            return this.Ok(_service.GetAll());
        }

        // GET api/<SchedulingController>/5
        [HttpGet("{id}")]
        public ActionResult<SchedulingDto> GetById(int id)
        {
            return this.Ok(_service.GetById(id));
        }

        // POST api/<ShedulingController>
        [HttpPost]
        public ActionResult<SchedulingDto> Post([FromBody] SchedulingDto schedulingDto)
        {
            return this.Ok(_service.Add(schedulingDto));
        }

        // PUT api/<TruckController>/5
        [HttpPut("{id}")]
        public ActionResult<SchedulingDto> Put([FromBody] SchedulingDto schedulingDto, int id)
        {
            return _service.Update(schedulingDto, id);
        }

        // DELETE api/<TruckController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
