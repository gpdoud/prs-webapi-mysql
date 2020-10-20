using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace webapi {

    [ApiController]
    [Route("api/[controller]")]    
    public class UsersController: ControllerBase {

        private readonly PrsDbContext _context;
        public UsersController(PrsDbContext context) { _context = context; }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAll() {
            return await _context.Users.ToListAsync();
        }
    }
}