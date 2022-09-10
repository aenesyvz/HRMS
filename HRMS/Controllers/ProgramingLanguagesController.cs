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
    public class ProgramingLanguagesController : ControllerBase
    {
        private readonly IProgramingLanguageService _programingLanguageService;
        public ProgramingLanguagesController(IProgramingLanguageService programingLanguageService)
        {
            _programingLanguageService = programingLanguageService;
        }

        [HttpPost("Add")]
        public IActionResult Add(ProgramingLanguage programingLanguage)
        {
            var result = _programingLanguageService.Add(programingLanguage);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(ProgramingLanguage programingLanguage)
        {
            var result = _programingLanguageService.Delete(programingLanguage);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("Update")]
        public IActionResult Update(ProgramingLanguage programingLanguage)
        {
            var result = _programingLanguageService.Update(programingLanguage);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll(int jobSeekerId)
        {
            var result = _programingLanguageService.GetAll(jobSeekerId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _programingLanguageService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
