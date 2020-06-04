using System;
using Microsoft.AspNetCore.Mvc;

namespace MathApi.Controllers
{
	[ApiController]
	[Route("/")]
	public class IndexController : ControllerBase // Part of Microsoft.AspNetCore.Mvc
	{
		public IndexController()
        {
        }

		[HttpGet(Name = "GetIndex")] // Swagger stuff
		public IActionResult Index()
		{
            // Ok method returns IActionResult - maps to 200
            // Can also do:
            // return StatusCode(200);
            return Ok("Hello world!");

		}

        [HttpGet("time", Name = "GetTime")] // Name is for Swagger stuff
		public IActionResult Time()
		{
            return Ok(DateTime.Now);
		}
	}
}