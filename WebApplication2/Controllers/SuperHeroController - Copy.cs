/*using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SuperHeroController : ControllerBase
	{
		[HttpGet]
		// first option.
		// public async Task<IActionResult> GetAllHeroes()
		// second option.
		public async Task<ActionResult<List<superhero>>> GetAllHeroes()
		{
			var SuperHero = new List<superhero>
			{
				new superhero
				{
					Id = 1, name ="Iron man", firstname = "iron", lastname="man", place="avengers"
				}
			};
			return Ok(SuperHero);
		}
	}
}*/