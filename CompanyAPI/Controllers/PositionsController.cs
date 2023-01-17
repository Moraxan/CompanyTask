using Company.Data.Entities;
using Company.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionsController : ControllerBase
    {
        private readonly IDbService _db;
        public PositionsController(IDbService db)
        {
            _db = db;
        }
        // GET: api/<CompanysController>
        [HttpGet]
        public async Task<IResult> Get()
        {
            var companys = await _db.GetAsync<Position, PositionDTO>();
            return Results.Ok(companys);
        }

        // GET api/<CompanysController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id)
        {
            var company = await _db.SingleAsync<Position, PositionDTO>(c => c.Id.Equals(id));
            return Results.Ok(company);
        }

        // POST api/<CompanysController>
        [HttpPost]
        //public async Task<IResult> Post([FromBody] Position dto)
        //{
        //    if (dto is null) return Results.BadRequest();
        //    var company = _db.AddAsync<Position, PositionDTO>(dto);
        //    if (await _db.SaveChangesAsync())
        //    {
        //        var Uri = _db.GetURI<Position>(company);
        //        return Results.Created(Uri, company);
        //    }
        //    return Results.BadRequest();
        //}

        // PUT api/<CompanysController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] PositionDTO dto)
        {
            try
            {

                if (!await _db.AnyAsync<Position>(e => e.Id.Equals(id)))
                    return Results.NotFound();
                _db.Update<Position, PositionDTO>(id, dto);
                if (await _db.SaveChangesAsync()) return Results.NoContent();


            }
            catch (Exception ex)
            {

                return Results.BadRequest($"Couldn't update the {typeof(Position).Name}entity.\n{ex}.");

            }
            return Results.BadRequest();


        }

        // DELETE api/<CompanysController>/5
        [HttpDelete("{id}")]


        public async Task<IResult> Delete(int id)
        {
            try
            {
                if (!await _db.DeleteAsync<Position>(id)) return Results.NotFound();
                if (await _db.SaveChangesAsync()) return Results.NoContent();
            }
            catch (Exception ex)
            {
                return Results.BadRequest($"Couldn't delete the {typeof(Position).Name}entity.\n{ex}.");

                throw;
            }
            return Results.BadRequest();
        }
    }
}
