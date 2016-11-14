using System.Collections.Generic;
using APro.Domain.Models.Enums;

namespace APro.Domain.Models
{
    public class ExaminationDetails
    {
        public int ID { get; set; }
        public Examination Examination { get; set; }
        public ExaminationStatus Status { get; set; }
        public IList<QuestionUserAnswer> UserAnswers { get; set; }
        // public int TotalCorrectAnswers => 
    }
}