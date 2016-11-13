namespace APro.Domain.Models
{
    public class QuestionUserAnswer
    {
        public int ID { get; set; }
        public TestQuestion TestQuestion { get; set; }
        public IList<PossibleAnswerSelected> SelectedAnswers { get; set; }
    }
}