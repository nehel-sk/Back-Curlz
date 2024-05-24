using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Curlz.Models;
using Curlz.Services.Services_Booking;
using Curlz.Aspects;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace Curlz.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("policy")]
    [ApiController]
    [ExceptionHandler]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService service;

        public BookingsController(IBookingService service)
        {
            this.service = service;
        }

        // GET: api/Bookings
        [HttpGet]

        public IActionResult Get()
        {
            return Ok(service.GetBooking());
        }

        // GET: api/Bookings/5
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.GetBooking(id));
        }

        // PUT: api/Bookings/5
       
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put(int id, Booking booking)
        {
            return Ok(service.UpdateBooking(id, booking));
        }





        // POST: api/Bookings
        
        [HttpPost]
        public IActionResult Post(Booking booking)
        {
            return StatusCode(201, service.AddBooking(booking));
        }

        // DELETE: api/Bookings/5
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(service.DeleteBooking(id));
        }

        

    }
}
