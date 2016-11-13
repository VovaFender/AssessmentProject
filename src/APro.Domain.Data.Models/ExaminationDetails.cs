using System.Collections.Generic;

namespace APro.Domain.Data.Models
{
    public class ExaminationDetails    
    {
        public int ID { get; set; }
        public int ExaminationID { get; set; }
        public Examination Examination { get; set; }
        public string Status { get; set; }
        public IList<QuestionUserAnswer> UserAnswers { get; set; }
    }
}