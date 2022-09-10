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
    public class WorkingTypesController : ControllerBase
    {
        private readonly IWorkingTypeService _workingTypeService;
        public WorkingTypesController(IWorkingTypeService workingTypeService)
        {
            _workingTypeService = workingTypeService;
        }
        [HttpPost("Add")]
        public IActionResult Add(WorkingType workingType)
        {
            var result = _workingTypeService.Add(workingType);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(WorkingType workingType)
        {
            var result = _workingTypeService.Delete(workingType);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(WorkingType workingType)
        {
            var result = _workingTypeService.Update(workingType);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _workingTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _workingTypeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
