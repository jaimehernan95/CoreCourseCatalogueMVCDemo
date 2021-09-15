using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseCatalogMVCDemo.Models
{
    public class MockCourseRepository : ICourseRepository
    {
        private readonly ICategoryRepository categoryRepository;
        public MockCourseRepository(ICategoryRepository repo)
        {
            categoryRepository = repo;
        }
        public IEnumerable<Course> AllCourses => new List<Course>
        {
            new Course
            {
                CourseId = 1, Title = "APS .NET Core", Description ="",
                Fee = 1350, isWeekendClassAvailable = true, imageUrl="https://vslive.com/-/media/ECG/VSLive/Blogs/aspnet_logo.jpg",
                Category = categoryRepository.AllCategories.ToList()[0]
            },
            new Course{
                CourseId = 2, Title = "MEAN Stack", Description ="",
                Fee = 1450, isWeekendClassAvailable = true, imageUrl="https://miro.medium.com/max/725/1*P8aGpuAxcVXgO4m7cByVtA.jpeg",
                Category = categoryRepository.AllCategories.ToList()[0]
            },
            new Course{
                CourseId = 3, Title = "Data Analysis using Python", Description ="",
                Fee = 1550, isWeekendClassAvailable = true, imageUrl="https://d1y2qj23ol72q6.cloudfront.net/2019/06/python-blog.jpg",
                Category = categoryRepository.AllCategories.ToList()[0]
            },
            new Course{
                CourseId = 4, Title = "Android Application Development", Description ="",
                Fee = 1650, isWeekendClassAvailable = false, imageUrl="https://goobar.b-cdn.net/wp-content/uploads/2021/03/android_category_thumbnail.png",
                Category = categoryRepository.AllCategories.ToList()[0]
            },
            new Course{
                CourseId = 5, Title = "IOS Application Development", Description ="",
                Fee = 1750, isWeekendClassAvailable = false, imageUrl="https://www.scoopbyte.com/wp-content/uploads/2021/07/ios-app-development-india.png",
                Category = categoryRepository.AllCategories.ToList()[1]
            }
        };
        public IEnumerable<Course> FreeCourseOfTheWeek { get; }

        public IEnumerable<Course> FreeCoursesOfTheWeek => throw new NotImplementedException();

        public Course GetCourseById(int courseId)
        {
            return AllCourses.FirstOrDefault(c => c.CourseId == courseId);
        }
    }
}
