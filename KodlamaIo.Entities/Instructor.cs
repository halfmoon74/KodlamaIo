using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Entities
{
    public class Instructor:BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public List<Course>? Courses { get; set; }

    }
}
