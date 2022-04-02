using ControlRobotApi.Models;
using ControlRobotApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRobotApi.Controllers.head
{   
    [ApiController]
    [Route("[Controller]")]
    public class StateInclinationController : ControllerBase
    {
        private headInclinationService _service;

        //contsructor
        public StateInclinationController(headInclinationService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult ListState()
        {
            StateInclinationModel ReturnState = _service.List();
            return Ok(ReturnState);
        }
        [HttpPut]
        public IActionResult AttState([FromBody] StateInclinationModel newState)
        {
            _service.Update(newState);
            return NoContent();
        }
    }
}
