using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Curlz.Models;
using Curlz.Aspects;
using Curlz.Services.Services_Slot;

namespace Curlz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ExceptionHandler]
    public class SlotsController : ControllerBase
    {
        private readonly ISlotService service;

        public SlotsController(ISlotService service)
        {
            this.service = service;
        }

        // GET: api/Slots
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetSlot());
        }

        // GET: api/Bookings/5
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.GetSlot(id));
        }

        // PUT: api/Bookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put(int id, Slot slot)
        {
            return Ok(service.UpdateSlot(id, slot));
        }

        // POST: api/Slots
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public IActionResult Post(Slot slot)
        {
            return StatusCode(201, service.AddSlot(slot));
        }

        // DELETE: api/Slots/5
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(service.DeleteSlot(id));
        }

    }
}
