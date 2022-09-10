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
    public class StaffsController : ControllerBase
    {
        private readonly IStaffService _staffService;
        public StaffsController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpPost("Add")]
        public IActionResult Add(Staff staff)
        {
            var result = _staffService.Add(staff);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("ChangeStatusEmployer")]
        public IActionResult ChangeStatusEmployer(Employer employer)
        {
            var result = _staffService.ChangeStatusEmployer(employer);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("ChangeStatusJobAdvertisement")]
        public IActionResult ChangeStatusJobAdvertisement(JobAdvertisement jobAdvertisement)
        {
            var result = _staffService.ChangeStatusJobAdvertisement(jobAdvertisement);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("GetAllByPassiveEmployer")]
        public IActionResult GetAllByPassiveEmployer()
        {
            var result = _staffService.GetAllByPassiveEmployer();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetAllByPassiveJobAdvertisement")]
        public IActionResult GetAllByPassiveJobAdvertisement()
        {
            var result = _staffService.GetAllByPassiveJobAdvertisement();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(Staff staff)
        {
            var result = _staffService.Update(staff);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
