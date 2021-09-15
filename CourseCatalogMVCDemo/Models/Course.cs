using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseCatalogMVCDemo.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Fee { get; set; }
        public string imageUrl { get; set; }
        public bool isWeekendClassAvailable { get; set; }

        public Category Category { get; set; }
    }
}
