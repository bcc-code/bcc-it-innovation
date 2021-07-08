using System.Collections.Generic;

namespace raven_db_api.Models
{
    public class Menu
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}