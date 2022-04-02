using ControlRobotApi.Models;
using ControlRobotApi.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRobotApi.Controllers.head
{
    [ApiController]
    [Route("[Controller]")]
    public class StateRotationController : ControllerBase
    {
        private headRotationService _service;

        //contsructor
        public StateRotationController(headRotationService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult ListState()
        {
            StateRotationModel ReturnState = _service.List();
            return Ok(ReturnState);
        }
        [HttpPut]
        public IActionResult AttState([FromBody] StateRotationModel newState)
        {

            Result res = _service.Update(newState);

            if (res.IsFailed) return Problem();

            return NoContent();
        }
    }
}
