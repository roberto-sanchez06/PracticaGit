using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Interfaces
{
    public interface IService<T>
    {
        void Create(T t);
        bool Delete(T t);
        int Update(T t);
        T[] FindAll();
    }
}
