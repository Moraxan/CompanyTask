using Company.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CompanyAPI.Controllers
{
    //
    //[Route("api/[controller]")]
    //[ApiController]
    //public class LinkPositionsController : ControllerBase
    //{
    //    private readonly IDbService _db;
    //    public LinkPositionsController(IDbService db)
    //    {
    //        _db = db;
    //    }
    //    // GET: api/<CompanysController>
    //    [HttpGet]
    //    //public async Task<IResult> Get()
    //    //{
    //    //    var companys = await _db.GetAsync<LinkPosition, LinkPositionDTO>();
    //    //    return Results.Ok(companys);
    //    //}

    //    // GET api/<CompanysController>/5
    //    [HttpGet("{id}")]
    //    //public async Task<IResult> Get(int id)
    //    //{
    //    //    var company = await _db.SingleAsync<LinkPosition, LinkPositionDTO>(c => c.Id.Equals(id));
    //    //    return Results.Ok(company);
    //    //}

    //    // POST api/<CompanysController>
    //    [HttpPost]
    //    //public async Task<IResult> Post([FromBody] LinkPositionDTO dto)
    //    //{
    //    //    if (dto is null) return Results.BadRequest();
    //    //    var company = await _db.AddAsync<LinkPosition, LinkPositionDTO>(dto);
    //    //    if (await _db.SaveChangesAsync())
    //    //    {
    //    //        var Uri = _db.GetURI<LinkPosition>(company);
    //    //        return Results.Created(Uri, company);
    //    //    }
    //    //    return Results.BadRequest();
    //    //}

    //    // PUT api/<CompanysController>/5
    //    [HttpPut("{id}")]
    //    //public async Task<IResult> Put(int id, [FromBody] LinkPositionDTO dto)
    //    //{
    //    //    try
    //    //    {

    //    //        if (!await _db.AnyAsync<LinkPosition>(e => e.Id.Equals(id)))
    //    //            return Results.NotFound();
    //    //        _db.Update<LinkPosition, LinkPositionDTO>(id, dto);
    //    //        if (await _db.SaveChangesAsync()) return Results.NoContent();


    //    //    }
    //    //    catch (Exception ex)
    //    //    {

    //    //        return Results.BadRequest($"Couldn't update the {typeof(LinkPosition).Name}entity.\n{ex}.");

    //    //    }
    //    //    return Results.BadRequest();


    //    //}

    //    // DELETE api/<CompanysController>/5
    //    [HttpDelete("{id}")]


    //    //public async Task<IResult> Delete(int id)
    //    //{
    //    //    try
    //    //    {
    //    //        if (!await _db.DeleteAsync<LinkPosition>(id)) return Results.NotFound();
    //    //        if (await _db.SaveChangesAsync()) return Results.NoContent();
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        return Results.BadRequest($"Couldn't delete the {typeof(LinkPosition).Name}entity.\n{ex}.");

    //    //        throw;
    //    //    }
    //    //    return Results.BadRequest();
    //    //}
    //}

}
