using System.Collections.Generic;

namespace APro.Domain.Data.Models
{
    public class Tag
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public IList<QuestionTag> QuestionTags { get; set; }
    }    
}