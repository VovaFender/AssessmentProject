using System.Collections.Generic;
using APro.Domain.Models.Enums;

namespace APro.Domain.Models
{
    public class Question
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public QuestionRate Rate { get; set; }        
        public IList<Tag> Tags { get; set; }
        public IList<PossibleAnswer> PossibleAnswers { get; set; }
    }
}