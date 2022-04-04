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
    public class StateRightArmsElbowController : ControllerBase
    {
        private rightArmsElbowService _service;

        //contsructor
        public StateRightArmsElbowController(rightArmsElbowService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult ListState()
        {
            StateRightElbowModel ReturnState = _service.List();
            return Ok(ReturnState);
        }
        [HttpPut]
        public IActionResult AttState([FromBody] StateRightElbowModel newState)
        {
            Result res = _service.Update(newState);

            if (res.IsFailed) return Problem();

            return NoContent();
        }
    }
}
