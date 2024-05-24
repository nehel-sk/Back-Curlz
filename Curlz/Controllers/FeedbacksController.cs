using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Curlz.Models;
using Curlz.Services.Services_Feedback;
using Curlz.Aspects;

namespace Curlz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ExceptionHandler]
    public class FeedbacksController : ControllerBase
    {
        private readonly IFeedbackService service;

        public FeedbacksController(IFeedbackService service)
        {
            this.service = service;
        }

        // GET: api/Feedbacks
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetFeedback());
        }

        // GET: api/Feedbacks/5
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(service.GetFeedback(id));
        }

        // PUT: api/Feedbacks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        [Route("{id}")]
        public IActionResult Put(int id, Feedback feedback)
        {
            return Ok(service.UpdateFeedback(id, feedback));
        }

        // POST: api/Feedbacks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public IActionResult Post(Feedback feedback)
        {
            return StatusCode(201, service.AddFeedback(feedback));
        }

        // DELETE: api/Feedbacks/5
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(service.DeleteFeedback(id));
        }

    }
}
