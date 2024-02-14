using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIo.Entities
{
    public class Category:BaseEntity
    {
        public string? CategoryName { get; set; }
        public List<Course>? Courses { get; set; }
    }
}
