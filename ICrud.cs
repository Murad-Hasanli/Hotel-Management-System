using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    interface ICrud<T>
    {
        bool Create(T model);
        T GetById(int id);
        List<T> GetAll();
        bool Update(int id, T model);
        bool Delete(int id);
    }
}
