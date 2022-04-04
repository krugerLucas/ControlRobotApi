using ControlRobotApi.Models;
using ControlRobotApi.Services;
using FluentResults;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRobotApi.Controllers.arms.left
{
    [EnableCors("MyPolicy")]
    [ApiController]
    [Route("[Controller]")]
    public class StateRightArmsWristController : ControllerBase
    {
        private rightArmsWristService _service;

        //contsructor
        public StateRightArmsWristController(rightArmsWristService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult ListState()
        {
            StateRightWristModel ReturnState = _service.List();
            return Ok(ReturnState);
        }
        [HttpPut]
        public IActionResult AttState([FromBody] StateRightWristModel newState)
        {
           Result res = _service.Update(newState);

            if (res.IsFailed) return Problem();

           return NoContent();
        }
    }
}
