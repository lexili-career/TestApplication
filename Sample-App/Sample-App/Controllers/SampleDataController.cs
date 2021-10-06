using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Sample_App.Models;
using Sample_App.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Sample_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class SampleDataController : ControllerBase
    {

        private ISampleData _sampleRepository;
        

        public SampleDataController(ISampleData sampleRepository)
        {
            this._sampleRepository = sampleRepository;
            
        }
        //private IHostingEnvironment Environment;

        //public SampleDataController(IHostingEnvironment _environment)
        //{
        //    Environment = _environment;
        //}
        // public async Task<IActionResult> CreateItem([FromBody] Sample data)
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CreateItem([FromBody] Sample data)
        {
            if (data == null) return BadRequest();

            this._sampleRepository.Insert(data);
            
            return new JsonResult("Data Saved Successfully") { StatusCode = 200 };
        }
        
    }
}
