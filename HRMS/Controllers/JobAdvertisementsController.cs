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
    public class JobAdvertisementsController : ControllerBase
    {
        private readonly IJobAdvertisementService _jobAdvertisementService;
        public JobAdvertisementsController(IJobAdvertisementService jobAdvertisementService)
        {
            _jobAdvertisementService = jobAdvertisementService;
        }

        [HttpPost("Add")]
        public IActionResult Add(JobAdvertisement jobAdvertisement)
        {
            var result = _jobAdvertisementService.Add(jobAdvertisement);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(JobAdvertisement jobAdvertisement)
        {
            var result = _jobAdvertisementService.Delete(jobAdvertisement);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(JobAdvertisement jobAdvertisement)
        {
            var result = _jobAdvertisementService.Update(jobAdvertisement);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll(JobAdvertisement jobAdvertisement)
        {
            var result = _jobAdvertisementService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _jobAdvertisementService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("GetByIdDto")]
        public IActionResult GetByIdDto(int id)
        {
            var result = _jobAdvertisementService.GetByIdDto(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
