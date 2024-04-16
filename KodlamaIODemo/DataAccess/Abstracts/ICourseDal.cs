using System;
using KodlamaIODemo.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        void Add(Course course);
        List<Course> GetAll();
        void Update(Course course);
        void Delete(Course course);
    }
}
