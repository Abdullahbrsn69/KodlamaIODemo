using System;
using KodlamaIODemo.DataAccess.Abstracts;
using KodlamaIODemo.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {   
        List<Course> _courses;

        public CourseDal() 
        {
            Course course1 = new();
            course1.CourseId = 1;
            course1.CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)";
            course1.CourseDescription = "C# Detaylı anlatım ile iyi bir C# geliştiricisi olun.";
            course1.InstructorName = "Engin Demiroğ";

            Course course2 = new();
            course1.CourseId = 2;
            course1.CourseName = "Yazılım Geliştirici Yetiştirme Kampı (C# + Angular)";
            course1.CourseDescription = "2 Ay sürecek Yazılım Geliştirici Yetiştirme Kampı";
            course1.InstructorName = "Engin Demiroğ";

            Course course3 = new();
            course1.CourseId = 3;
            course1.CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)";
            course1.CourseDescription = "Java ve React Yazılımcı Yetiştirme Kampı";
            course1.InstructorName = "Engin Demiroğ";

            Course course4 = new();
            course1.CourseId = 4;
            course1.CourseName = "2024 Yazılım Geliştirici Yetiştirme Kampı (Javascript)";
            course1.CourseDescription = "Javascript iyi yazılımcı yetiştirme kampı";
            course1.InstructorName = "Engin Demiroğ";

            Course course5 = new();
            course1.CourseId = 5;
            course1.CourseName = "Senior Yazılımcı Yetiştirme Kampı (ASP.NET)";
            course1.CourseDescription = "Senior Yazılım Geliştirici Yetiştirme Kampımıza buradan ulaşın.";
            course1.InstructorName = "Engin Demiroğ";
        }

        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Delete(Course course)
        {
            _courses.Remove(course);
        }

        public void Update(Course course)
        {
            Course courseToUpdate = _courses.FirstOrDefault(c => c.CourseId == course.CourseId);

            if (courseToUpdate != null)
            {
                courseToUpdate = course;
            }
        }
    }
}
