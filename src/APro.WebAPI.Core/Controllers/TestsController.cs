using System.Linq;
using APro.Domain.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APro.WebAPI.Core.Controllers
{
    [Route("api/[controller]")]
    public class TestsController : Controller
    {
        private AssessmentDataContext _dbContext;

        public TestsController(AssessmentDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var tests = _dbContext.Tests.Select(t => 
                new 
                {
                    t.ID,
                    t.Title,
                    t.Description,                   
                    Questions = t.TestQuestions.Select(tq => 
                        new 
                        {
                            tq.Question.ID,
                            tq.Question.Description,
                            tq.Question.Rate,
                            PossibleAnswers = tq.Question.PossibleAnswers
                                                .Select(pa => new { pa.ID, pa.Description, pa.IsCorrect }).ToList(),
                            Tags = tq.Question.QuestionTags
                                                .Select(qt => new { qt.Tag.ID, qt.Tag.Title }).ToList()
                        }).ToList() 
                });

            return new ObjectResult(tests);
        }
    }
}