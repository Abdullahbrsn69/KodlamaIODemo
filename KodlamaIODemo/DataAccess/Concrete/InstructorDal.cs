using System;
using KodlamaIODemo.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIODemo.DataAccess.Abstracts;

namespace KodlamaIODemo.DataAccess.Concrete
{

    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        
         public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Delete(Instructor instructor)
        {
            var instructorDelete = _instructors.Where(c => c.InstructorId == instructor.InstructorId).SingleOrDefault();
            if (instructorDelete != null)
            {
                _instructors.Remove(instructor);
            }
        }

 
        public void Update(Instructor instructor)
        {
            var updateInstructor = _instructors.Where(u => u.InstructorId == instructor.InstructorId).SingleOrDefault();
            if (updateInstructor != null)
            {
                updateInstructor = instructor;
            }
        }
    }
}
