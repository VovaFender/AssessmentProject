namespace APro.Domain.Models
{
    public class TestQuestion
    {
        public int ID { get; set; }
        public Question Question { get; set; }
        public Test Test { get; set; }
    }
}