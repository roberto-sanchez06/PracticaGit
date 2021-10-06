using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Interfaces
{
    public interface IModel<T>
    {
        //sin modificadores de acceso
        void Create(T t);
        bool Delete(T t);
        int Update(T t);
        T[] FindAll();
    }
}
