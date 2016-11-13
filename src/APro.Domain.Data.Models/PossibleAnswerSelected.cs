namespace APro.Domain.Data.Models
{
    public class PossibleAnswerSelected
    {
        public int ID { get; set; }
        public int SelectedAnswerID { get; set; }
        public PossibleAnswer SelectedAnswer { get; set; }
        public int QuestionUserAnswerID { get; set; }
        public QuestionUserAnswer QuestionUserAnswer { get; set; }
    }
}