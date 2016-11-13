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
                    e.AssignmentDate,
                    ExaminationDetails = new 
                    {
                        e.ExaminationDetails.ID,
                        e.ExaminationDetails.Status,
                        UserAnswers = e.ExaminationDetails.UserAnswers
                            .Select(ua => new 
                            { 
                                ua.TestQuestionID,
                                ua.TestQuestion.Question.Description, 
                                SelectedAnswers = ua.SelectedAnswers
                                    .Select(sa => sa.SelectedAnswer.Description)
                            } )
                            
                    }
                }).ToList();
            
            return new ObjectResult(examinations);
        }
    }    
}