using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Entities
{
    public class Course:BaseEntity
    {
        public string? CourseName { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public int InstructorId { get; set; }
        public Instructor? Instructor { get; set; }
    }

    
}
