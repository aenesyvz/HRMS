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
    public class WorkingTimesController : ControllerBase
    {
        private readonly IWorkingTimeService _workingTimeService;
        public WorkingTimesController(IWorkingTimeService workingTimeService)
        {
            _workingTimeService = workingTimeService;
        }

        [HttpPost("Add")]
        public IActionResult Add(WorkingTime workingTime)
        {
            var result = _workingTimeService.Add(workingTime);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(WorkingTime workingTime)
        {
            var result = _workingTimeService.Delete(workingTime);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(WorkingTime workingTime)
        {
            var result = _workingTimeService.Update(workingTime);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _workingTimeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _workingTimeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
