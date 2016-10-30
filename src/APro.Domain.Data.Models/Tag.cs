using System.Collections.Generic;

namespace APro.Domain.Data.Models
{
    public class Tag
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public virtual ICollection<QuestionTag> QuestionTags { get; set; }
    }    
}