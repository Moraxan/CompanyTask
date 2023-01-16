using Company.Common.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CompanyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDbService _db;
        public DepartmentsController(IDbService db)
        {
            _db = db;
        }
        // GET: api/<DepartmentsController>
        [HttpGet]
        
        public async Task<IResult> Get()
        {
            var departments = await _db.GetAsync<Department, DepartmentDTO>();
            return Results.Ok(departments);
        }

        // GET api/<DepartmentsController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id)
        {
            var department = await _db.SingleAsync<Department, DepartmentDTO>(c => c.Id.Equals(id));
            return Results.Ok(department);
        }

            // POST api/<DepartmentsController>
        [HttpPost]

        public async Task<IResult> Post([FromBody] DepartmentDTO dto)
        {
            if (dto is null) return Results.BadRequest();
            var department = await _db.AddAsync<Department, DepartmentDTO>(dto);
            if (await _db.SaveChangesAsync())
            {
                var Uri = _db.GetURI<Department>(department);
                return Results.Created(Uri, department);
            }
            return Results.BadRequest();
        }

        // PUT api/<DepartmentsController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] DepartmentDTO dto)
        {
            try
            {

                if (!await _db.AnyAsync<Department>(e => e.Id.Equals(id)))
                    return Results.NotFound();
                _db.Update<Department, DepartmentDTO>(id, dto);
                if (await _db.SaveChangesAsync()) return Results.NoContent();


            }
            catch (Exception ex)
            {

                return Results.BadRequest($"Couldn't update the {typeof(CompanyName).Name}entity.\n{ex}.");

            }
            return Results.BadRequest();


        }

        // DELETE api/<DepartmentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
