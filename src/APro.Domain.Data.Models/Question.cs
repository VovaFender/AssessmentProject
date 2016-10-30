using System;
using System.Collections.Generic;

namespace APro.Domain.Data.Models
{
    public class Question
    {
        public int ID { get; set; }

        public string Description { get; set; }

        public Rate Rate 
        { 
            get
            {
                return (Rate) Enum.Parse(typeof(Rate), RateDatabase);
            }
        }
        
        public string RateDatabase { get; set; }
        public IList<QuestionTag> QuestionTags { get; set; }
        public IList<PossibleAnswer> PossibleAnswers { get; set; }
        public IList<TestQuestion> TestQuestions { get; set; }
    }
}