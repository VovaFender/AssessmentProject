using System.Collections.Generic;

namespace APro.Domain.Data.Models
{
    public class QuestionUserAnswer
    {
        public int ID { get; set; }
        public int ExaminationDetailsID { get; set; }
        public ExaminationDetails ExaminationDetails { get; set; }
        public int TestQuestionID { get; set; }
        public TestQuestion TestQuestion { get; set; }
        public IList<PossibleAnswerSelected> SelectedAnswers { get; set; }
    }
}