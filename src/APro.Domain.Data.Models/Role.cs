using System.Collections.Generic;

namespace APro.Domain.Data.Models
{
    public class Role
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public IList<User> Users { get; set; }
    }
}