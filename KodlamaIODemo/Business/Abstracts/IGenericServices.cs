using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.Business.Abstracts
{
    public interface IGenericServices<T> where T : class // sadece classlar - referans türler için
    {
        List<T> GetAll();
        void Add(T item);
        void Remove(T item);
        void Update(T item);
    }
}
