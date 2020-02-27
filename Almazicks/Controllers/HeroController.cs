using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Almazicks.DataContracts.DataContracts;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Almazicks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        private readonly IHeroService _heroService;
        public HeroController(IHeroService heroService)
        {
            _heroService = heroService;
        }
        [HttpGet]
        public async Task<IEnumerable<HeroDto>> GetHeroesAsync()
        {
            return await _heroService.GetHeroesAsync();
        }

        // GET: api/Hero/5
        [HttpGet("{id}", Name = "Hero")]
        public async Task<HeroDto> GetHeroAsync(int id)
        {
            return await _heroService.GetHeroAsync(id);
        }

        // POST: api/Hero
        [HttpPost]
        public async Task CreateHeroAsync([FromBody] HeroDto hero)
        {
            await _heroService.CreateHeroAsync(hero);
        }

        // PUT: api/Hero/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
