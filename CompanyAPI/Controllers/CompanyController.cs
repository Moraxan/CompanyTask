using Microsoft.AspNetCore.Mvc;

namespace CompanyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")] //localhost:6001/api/CompanyName
    public class CompanyController : ControllerBase
    {
        private readonly CompanyContext _db;

        public CompanyController(CompanyContext db)
        {
            _db = db;
        }
        [HttpGet("filter")]

        public async Task<IResult> Get(string filter)

        {
            
            var companyNames = await _db.CompanyNames.Where(c => c.Company.Contains(filter)).ToListAsync();
            return Results.Ok(companyNames);
            

        }


    }
}
