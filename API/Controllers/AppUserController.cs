using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")] //localhost:xxxx/api/appuser
    [ApiController]
    public class AppUserController(AppDbContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<AppUser>>> GetAppUsers()
        {
            return await context.AppUsers.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetAppUser(string id)
        {
            var appuser = await context.AppUsers.FindAsync(id);

            if(appuser == null)
                return NotFound();

            return appuser;
        } 
    }
}
