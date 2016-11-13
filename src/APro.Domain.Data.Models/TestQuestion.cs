using System.Collections.Generic;

namespace APro.Domain.Data.Models
{
    public class TestQuestion
    {
        public int ID { get; set; }
        public int QuestionID { get; set; }
        public Question Question { get; set; }
        public int TestID { get; set; }
        public Test Test { get; set; }
        public IList<QuestionUserAnswer> UserAnswers { get; set; }
    }
}