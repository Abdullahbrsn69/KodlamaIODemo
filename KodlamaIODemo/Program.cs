using KodlamaIODemo.Business.Concrete;
using KodlamaIODemo.DataAccess.Abstracts;
using KodlamaIODemo.DataAccess.Concrete;
using KodlamaIODemo.Entities;


namespace KodlamaIODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            List<Category> categories = categoryManager.GetAll();
            for (int i = 0; i < categories.Count; i++)
            {
                Console.WriteLine(categories[i].CategoryName + " / " + categories[i].CategoryDescription);
            }

            Instructor instructor1 = new Instructor();
            instructor1.InstructorId = 1;
            instructor1.FirstName = "Halit";
            instructor1.LastName = "Kalaycı";
        }
    }
}