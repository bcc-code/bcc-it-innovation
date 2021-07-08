using System.Collections.Generic;

namespace raven_db_api.Models
{
    public class Course
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public List<string> Allergenics { get; set; }
    }
}