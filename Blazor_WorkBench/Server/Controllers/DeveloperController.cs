using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor_WorkBench.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blazor_WorkBench.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var devs = DeveloperData.Developers;
            return Ok(devs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int? id)
        {
            var dev = DeveloperData.Developers.FirstOrDefault(x => x.Id == id);
            return Ok(dev);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Developer developer)
        {
            DeveloperData.Developers.Add(new Developer(developer.Id, developer.FirstName, developer.LastName, developer.Email, developer.Experience));
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Put(Developer developer)
        {
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            var recordToRemove = DeveloperData.Developers.Find(x => x.Id == id);
            DeveloperData.Developers.Remove(recordToRemove);
            return NoContent();
        }
    }
}
