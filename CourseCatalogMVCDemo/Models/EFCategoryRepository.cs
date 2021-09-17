using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseCatalogMVCDemo.Models
{
    public class EFCategoryRepository : ICourseRepository
    {
        private readonly AppDBContext appDBContext;
        public EFCategoryRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }
        public IEnumerable<Category> AllCategories => appDBContext.Categories;
        public IEnumerable<Course> AllCourses => throw new NotImplementedException();

        public IEnumerable<Course> FreeCoursesOfTheWeek => throw new NotImplementedException();

        public Course GetCourseById(int courseId)
        {
            throw new NotImplementedException();
        }
    }
}
