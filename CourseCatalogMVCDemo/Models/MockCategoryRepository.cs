using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseCatalogMVCDemo.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category> { 
            new Category
            {
                CategoryId=101,
                Name="Web Technology",
                Description="All Serve-Side and Client-side Web Technology Courses"
               
            },
            new Category
            {
                CategoryId=102,
                Name="Data Science ",
                Description="All Data Science related courses"
            },
            new Category
            {
                CategoryId=103,
                Name=" Mobile Application Development",
                Description="Various courses related to Mobile Application Development"
            }
        };
    }
}
