using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CourseCatalogMVCDemo.Models
{
    public class EFCourseRepository : ICourseRepository
    {
        private readonly AppDBContext appDBContext;
        public EFCourseRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<Course> AllCourses
        {
            get
            {
                return appDBContext.Courses.Include(c => c.Category);
            }
        }
        /*public IEnumerable<Course> AllCourses => throw new NotImplementedException();*/

        public IEnumerable<Course> FreeCoursesOfTheWeek => throw new NotImplementedException();

        public Course GetCourseById(int courseId)
        {
            /*throw new NotImplementedException();*/
            return appDBContext.Courses.Include(c => c.CourseId == courseId).FirstOrDefault(c => c.CourseId == courseId);
        }
    }
}
