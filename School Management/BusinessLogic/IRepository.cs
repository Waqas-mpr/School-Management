using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management.BusinessLogic
{
    internal interface IRepository<T> where T : class
    {
         T GetById(int id);
        List<T> GetAll();
        T Add(T entity);
        T Update(T entity);
        bool Delete(T entity);

    }
}
