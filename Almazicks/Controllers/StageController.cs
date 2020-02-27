using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Almazicks.DataContracts.DataContracts;
using BusinessLogic.Interfaces;
using Data.EntityModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Almazicks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StageController : ControllerBase
    {
        private readonly IStageService _stageService;
        public StageController(IStageService stageService)
        {
            _stageService = stageService;
        }
        // GET: api/Stage
        [HttpGet]
        public async Task<IEnumerable<StageDto>> GetStagesAsync()
        {
            return await _stageService.GetStagesAsync();
        }

        // GET: api/Stage/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/Stage
        [HttpPost]
        public async Task CreateStageAsync([FromBody] StageDto stage)
        {
            await _stageService.CreateStageAsync(stage);
        }

        // PUT: api/Stage/5
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
