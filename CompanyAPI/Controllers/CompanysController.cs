using Company.Data.Interfaces;
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
        public async Task<IResult> Post([FromBody] CompanyNameDTO dto)
        {
            if (dto is null) return Results.BadRequest();
            var company = await _db.AddAsync<CompanyName, CompanyNameDTO>(dto);
            if (await _db.SaveChangesAsync())
            {
                var Uri = _db.GetURI<CompanyName>(company);
                return Results.Created(Uri, company);
            }
            return Results.BadRequest();
        }

        // PUT api/<CompanysController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] CompanyNameDTO dto)
        {
            try
            {

                if (!await _db.AnyAsync<CompanyName>(e => e.Id.Equals(id)))
                    return Results.NotFound();
                _db.Update<CompanyName, CompanyNameDTO>(id, dto);
                if (await _db.SaveChangesAsync()) return Results.NoContent();


            }
            catch (Exception)
            {

                return Results.BadRequest($"Couldn't update the {typeof(CompanyName).Name}entity.\n{ex}.");

            }
            //return Results.BadRequest();
            

        }

        // DELETE api/<CompanysController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
