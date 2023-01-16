using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanysController : ControllerBase
    {
        private readonly IDbService _db;
        public CompanysController(IDbService db)
        {
            _db = db;
        }
        // GET: api/<CompanysController>
        [HttpGet]
        public async Task<IResult> Get()
        {
            var companys = await _db.GetAsync<CompanyName, CompanyNameDTO>();
            return Results.Ok(companys);
        }

        // GET api/<CompanysController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id)
        {
            var company = await _db.SingleAsync<CompanyName, CompanyNameDTO>(c => c.Id.Equals(id));
            return Results.Ok(company);
        }

        // POST api/<CompanysController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CompanysController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CompanysController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
