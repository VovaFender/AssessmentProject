using Microsoft.AspNetCore.Mvc;
using APro.Domain.Data;
using System.Linq;

namespace APro.WebAPI.Core.Controllers
{

    [Route("api/[controller]")]
    public class QuestionsController : Controller
    {
        private AssessmentDataContext _dbContext;

        public QuestionsController(AssessmentDataContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var questionsList = _dbContext.Questions.ToList();
            return new ObjectResult(questionsList);    
        }
    }
}