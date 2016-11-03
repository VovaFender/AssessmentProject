using System.Linq;
using APro.Domain.Data;
using Microsoft.AspNetCore.Mvc;

namespace APro.WebAPI.Core.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller        
    {
        private readonly AssessmentDataContext _dbContext;

        public UsersController(AssessmentDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = _dbContext.Users.Select(u => new 
                {
                    u.ID,
                    Role = new 
                    {
                        u.Role.ID,
                        u.Role.Title
                    },
                    u.FirstName,
                    u.LastName
                }).ToList();

            return new ObjectResult(users);
        }
    }
}