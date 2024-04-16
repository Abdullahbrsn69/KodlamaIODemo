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
    public class CategoryManager : IGenericServices<Category>
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category item)
        {
            _categoryDal.Add(item);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Remove(Category itme)
        {
            _categoryDal.Delete(itme);
        }

        public void Update(Category item)
        {
            _categoryDal.Update(item);
        }
    }
}
