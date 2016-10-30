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
            var questionsList = _dbContext.Questions.Select(q => 
                new 
                {
                    q.ID,
                    q.Description,
                    q.Rate,
                    Tags = q.QuestionTags.Select(qt => new { qt.Tag.ID, qt.Tag.Title }).ToList(),
                    PossibleAnswers = q.PossibleAnswers
                                        .Select(pa => new { pa.ID, pa.Description, pa.IsCorrect }).ToList()
                });
            
            return new ObjectResult(questionsList);
        }
    }
}