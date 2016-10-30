namespace APro.Domain.Data.Models
{
    public class PossibleAnswer
    {
        public int ID { get; set; }
        
        public string Description { get; set; }

        public bool IsCorrect { get; set; }

        public int QuestionID { get; set; }

        public Question Question { get; set; }
    }
}