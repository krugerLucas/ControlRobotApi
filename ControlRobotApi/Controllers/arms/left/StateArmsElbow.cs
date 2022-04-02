using ControlRobotApi.Models;
using ControlRobotApi.Services;
using FluentResults;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRobotApi.Controllers.arms.left
{
    [ApiController]
    [Route("[Controller]")]
    public class StateLeftArmsElbowController : ControllerBase
    {
        private leftArmsElbowService _service;

        //contsructor
        public StateLeftArmsElbowController(leftArmsElbowService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult ListState()
        {
            StateLeftElbowModel ReturnState = _service.List();
            return Ok(ReturnState);
        }
        [HttpPut]
        public IActionResult AttState([FromBody] StateLeftElbowModel newState)
        {
            Result res = _service.Update(newState);

            if (res.IsFailed) return Problem();

            return NoContent();
        }
    }
}
