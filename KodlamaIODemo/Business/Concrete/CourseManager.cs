using KodlamaIODemo.Business.Abstracts;
using KodlamaIODemo.DataAccess.Abstracts;
using KodlamaIODemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.Business.Concrete
{
    public class CourseManager : IGenericServices<Course>
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(Course item)
        {
            _courseDal.Add(item);
        }

        public List<Course> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Course item) 
        {
            _courseDal.Delete(item);
        
        }
        public void Update(Course item)
        {
            _courseDal.Update(item);
        }
    }
}
