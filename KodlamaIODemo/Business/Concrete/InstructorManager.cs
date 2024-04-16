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
    public class InstructorManager : IGenericServices<Instructor>
    {
        private readonly IInstructorDal _instructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void Add(Instructor item)
        {
            _instructorDal.Add(item);
        }
        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public void Remove(Instructor item)
        {
            _instructorDal.Delete(item);
        }

        public void Update(Instructor item)
        {
            _instructorDal.Update(item);
        }
    }
}
