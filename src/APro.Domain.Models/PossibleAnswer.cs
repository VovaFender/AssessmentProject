namespace APro.Domain.Models
{
    public class PossibleAnswer
    {
        public int ID { get; set; }
        
        public string Description { get; set; }

        public bool IsCorrect { get; set; }
    }
}