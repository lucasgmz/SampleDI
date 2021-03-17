using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleIOC.Domain.Logger.Interface;
using SampleIOC.Domain.MathUtils;

namespace SampleIOC.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private ILoggerService objLoggerService;
        private IMathUtilsService objMathUtilsService;

        public SampleController(ILoggerService objLoggerService, IMathUtilsService objMathUtilsService)
        {
            this.objLoggerService = objLoggerService;
            this.objMathUtilsService = objMathUtilsService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            objLoggerService.Log("Logging.");
            return Ok();
        }
        
        [HttpGet("sum/{x}/{y}")]
        public IActionResult Get(int x, int y)
        {
            var sum = objMathUtilsService.Sum(x, y);
            return Ok(sum);
        }
    }
}
