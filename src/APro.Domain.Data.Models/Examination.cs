using System;

namespace APro.Domain.Data.Models
{
    public class Examination
    {
        public int ID { get; set; }
        public int CreatedByID { get; set; }
        public User CreatedBy { get; set; }
        public int AssignedToID { get; set; }
        public User AssignedTo { get; set; }
        public DateTime AssignmentDate { get; set; }
        public string Description { get; set; } 
    }
}