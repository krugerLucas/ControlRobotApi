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
    public class StateLeftArmsWristController : ControllerBase
    {
        private leftArmsWristService _service;

        //contsructor
        public StateLeftArmsWristController(leftArmsWristService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult ListState()
        {
            StateLeftWristModel ReturnState = _service.List();
            return Ok(ReturnState);
        }
        [HttpPut]
        public IActionResult AttState([FromBody] StateLeftWristModel newState)
        {
            Result res = _service.Update(newState);

            if (res.IsFailed) return Problem();

            return NoContent();
        }
    }
}
