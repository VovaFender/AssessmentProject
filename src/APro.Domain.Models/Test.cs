namespace APro.Domain.Models
{
    public class Test
    {
        public int ID { get; set; }

        public string Description { get; set; }

        public string Title { get; set; }

        public IList<TestQuestion> TestQuestions { get; set; }
    }
}