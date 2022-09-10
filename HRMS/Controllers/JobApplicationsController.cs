using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobApplicationsController : ControllerBase
    {
        private IJobApplicationService _jobApplicationService;
        public JobApplicationsController(IJobApplicationService jobApplicationService)
        {
            _jobApplicationService = jobApplicationService;
        }

        [HttpPost("Add")]
        public IActionResult Add(JobApplication jobApplication)
        {
            var result = _jobApplicationService.Add(jobApplication);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(JobApplication jobApplication)
        {
            var result = _jobApplicationService.Delete(jobApplication);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(JobApplication jobApplication)
        {
            var result = _jobApplicationService.Update(jobApplication);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("GetAllByJobAdvertisement")]
        public IActionResult GetAllByJobAdvertisement(int jobAdvertisementId)
        {
            var result = _jobApplicationService.GetAllByJobAdvertisement(jobAdvertisementId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("GetAllByJobSeeker")]
        public IActionResult GetAllByJobSeeker(int jobSeekerId)
        {
            var result = _jobApplicationService.GetAllByJobSeeker(jobSeekerId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _jobApplicationService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
