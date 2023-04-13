using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SuperHeroController : ControllerBase
	{
		// below is heroes data.
		private static List<superhero> superheroes = new List<superhero>
		{
				new superhero {Id = 1, name ="Iron man", firstname = "iron", lastname="man", place="avengers"},
				new superhero {Id = 2, name ="Doctor Strange", firstname = "doctor", lastname="strange", place="avengers"},
		};

		// get all heroes.
		[HttpGet]
		public async Task<ActionResult<List<superhero>>> GetAllHeroes()
		{
			// show response 200 (available).
			return Ok(superheroes);
		}

		// get heroes by id.
		[HttpGet]
		[Route("{id}")]
		public async Task<ActionResult<List<superhero>>> GetSingleHeroes(int id)
		{
			// superheroes are the name from heroes table -> simply database name.
			var hero = superheroes.Find(x => x.Id == id);
			if (hero is null)
			{
				// if hero not found will show below message.
				return NotFound("Sorry, this heroes doesn't exist!");
			} else
			{
				return Ok(superheroes);
			}
		}

		// add hero.
		[HttpPost]
		// "hero" just a variabel to add heroes data.
		public async Task<ActionResult<List<superhero>>> AddHeroes(superhero hero)
		{
			// add heroes data to superheroes table.
			superheroes.Add(hero);
			return Ok(superheroes);
		}

		// edit hero data.
		[HttpPut]
		[Route("{id}")]
		public async Task<ActionResult<List<superhero>>> UpdateHeroes(int id, superhero request)
		{
			// superheroes are the name from heroes table -> simply database name.
			var hero = superheroes.Find(x => x.Id == id);
			hero.name = request.name;
			hero.firstname = request.firstname;
			hero.lastname = request.lastname;
			hero.place = request.place;
			if (hero is null)
			{
				// if hero not found will show below message.
				return NotFound("Sorry, this heroes doesn't exist!");
			}
			else
			{
				return Ok(superheroes);
			}
		}
	}
}