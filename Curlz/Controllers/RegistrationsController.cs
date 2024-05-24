using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Curlz.Models;
using Curlz.Aspects;
using Curlz.Services.Services_Registration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;

namespace Curlz.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("policy")]
    [ApiController]
    [ExceptionHandler]
    public class RegistrationsController : ControllerBase
    {
        private readonly IRegistrationService service;

        public RegistrationsController(IRegistrationService service)
        {
            this.service = service;
        }

        // GET: api/Registrations
        [HttpGet]
        //[Authorize(Roles ="Admin")]
        public IActionResult Get()
        {
            return Ok(service.GetRegistration());
        }


        // GET: api/Registrations/5
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.GetRegistration(id));
        }

        // PUT: api/Registrations/5
        
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put(int id, Registration registration)
        {
            return Ok(service.UpdateRegistration(id, registration));
        }

        // POST: api/Registrations
        
        [HttpPost]
        public IActionResult Post(Registration registration)
        {
            return StatusCode(201, service.AddRegistration(registration));
        }

        // DELETE: api/Registrations/5
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(service.DeleteRegistration(id));
        }

        [HttpPost("login")]
        public string Login(string email, string password)
        {
            var result = service.Login(email, password);

            if (result != null)
            {
                return result;
            }
            return null;
        }

    }
}
