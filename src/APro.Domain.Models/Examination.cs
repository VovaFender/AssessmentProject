using System;

namespace APro.Domain.Models
{
    public class Examination
    {
        public int ID { get; set; }
        public User CreatedBy { get; set; }
        public User AssignedTo { get; set; }
        public DateTime AssignmentDate { get; set; }
        public string Description { get; set; }
        public ExaminationDetails ExaminationDetails { get; set; }
    }
}