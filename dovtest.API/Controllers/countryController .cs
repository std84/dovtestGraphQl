using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dovtest.REPOSITORY;
using System.Net.Http;
using System.Net.Http.Headers; 

namespace dovtest.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class countryController: ControllerBase
    {
        private readonly ICountryRepository _repo;
        public countryController(ICountryRepository repo){
            _repo= repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetCountries()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCountry(string id)
        {
            var rng = await _repo.GetCountryGraphQl(id);

            return Ok(rng);
        }
    }
}