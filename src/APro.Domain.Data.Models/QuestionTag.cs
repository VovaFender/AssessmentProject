namespace APro.Domain.Data.Models
{
    public class QuestionTag
    {
        public int ID { get; set; }

        public int QuestionID { get; set; }

        public Question Question { get; set; }

        public int TagID { get; set; }

        public Tag Tag { get; set; }
    }
}