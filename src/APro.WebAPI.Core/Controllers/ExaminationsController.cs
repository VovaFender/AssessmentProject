using System.Linq;
using APro.Domain.Data;
using Microsoft.AspNetCore.Mvc;

namespace APro.WebAPI.Core.Controllers
{
    [Route("api/[controller]")]
    public class ExaminationsController : Controller
    {
        private readonly AssessmentDataContext _dbContext;

        public ExaminationsController(AssessmentDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var examinations = _dbContext.Examinations.Select(e => 
                new 
                {
                    e.ID,
                    e.AssignedToID,
                    e.CreatedByID,
                    e.Description,
                    e.AssignmentDate
                }).ToList();
            
            return new ObjectResult(examinations);
        }
    }    
}