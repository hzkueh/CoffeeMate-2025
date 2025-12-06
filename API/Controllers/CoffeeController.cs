using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    
    public class CoffeeController(AppDbContext context) : BaseApiController
    {
        
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Coffee>>> GetCoffees()
        {
            var coffee = await context.Coffees.ToListAsync();
            return Ok(coffee);
        }

        [HttpGet("FlavorProfile")]
        public async Task<ActionResult<IReadOnlyList<FlavorProfile>>> GetFlavorProfiles()
        {
            var flavors = await context.FlavorProfiles.ToListAsync();
            return Ok(flavors);
        }
    }
}
