using System.Collections.Generic;

namespace APro.Domain.Models
{
    public class QuestionUserAnswer
    {
        public int ID { get; set; }
        public Question TestQuestion { get; set; }
        public IList<PossibleAnswer> SelectedAnswers { get; set; }
    }
}