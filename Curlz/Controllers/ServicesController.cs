using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Curlz.Models;
using Curlz.Aspects;
using Curlz.Services.Services_Service;

namespace Curlz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ExceptionHandler]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceService service;

        public ServicesController(IServiceService service)
        {
            this.service = service;
        }

        // GET: api/Services
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetService());
        }
        
        // GET: api/Services/5
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.GetService(id));
        }
        // PUT: api/Services/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put(int id, Service services)
        {
            return Ok(service.UpdateService(id, services));
        }

        // POST: api/Services
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public IActionResult Post(Service services)
        {
            return StatusCode(201, service.AddService(services));
        }

        // DELETE: api/Services/5
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(service.DeleteService(id));
        }


        //Stored Procedure SearchByServiceName
        /*
        [HttpGet]
        [Route("{service}")]
        public IActionResult Get(string services)
        {
            return Ok(service.GetServiceByName(services));
        }*/

        [HttpGet]
        [Route("{services}/name")]
        public IActionResult Get(string services)
        {
            return Ok(service.GetServiceByService(services));
        }

    }
}
