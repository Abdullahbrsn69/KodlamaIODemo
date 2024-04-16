using KodlamaIODemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        void Add(Instructor instructor);
        List<Instructor> GetAll();
        void Update(Instructor instructor);
        void Delete(Instructor instructor);
    }
}
