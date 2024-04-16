using KodlamaIODemo.DataAccess.Abstracts;
using KodlamaIODemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;

        public CategoryDal()
        {
            _categories = new List<Category>();
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Remove(Category category)
        {
            var categoryDelete = _categories.FirstOrDefault(c => c.CategoryId == category.CategoryId);
            if (categoryDelete != null)
            {
                _categories.Remove(categoryDelete);
            }
        }

        public void Update(Category category)
        {
            var UCategory = _categories.Where(u => u.CategoryId == category.CategoryId).SingleOrDefault();

            if (UCategory != null)
            {
                UCategory = category;
            }
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Delete(Category category)
        {
            _categories.Remove(category);
        }
    }
}
