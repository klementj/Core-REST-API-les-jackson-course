using System.Collections.Generic;
using Core_REST_API_les_jackson_course.Data;
using Core_REST_API_les_jackson_course.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core_REST_API_les_jackson_course.Controllers
{
    // api/jobs
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IJobsRepo _repository;

        public JobsController(IJobsRepo repository)
        {
            _repository = repository;
        }

        // GET api/jobs
        [HttpGet]
        public ActionResult <IEnumerable<Job>> GetAllJobs()
        {
            var jobItems = _repository.GetAllJobs();

            return Ok(jobItems);
        }

        // GET api/jobs/{id}
        [HttpGet("{id}")]
        public ActionResult <Job> GetJobById(int id)
        {
            var jobItem = _repository.GetJobById(id);

            return Ok(jobItem);
        }
    }
}