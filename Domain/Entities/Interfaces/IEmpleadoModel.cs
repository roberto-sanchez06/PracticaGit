using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Empleados;

namespace Domain.Entities.Interfaces
{
    //cuando las interfaces heredan de otras interfaces no implementan los metodos 
    //por obvias razones
    public interface IEmpleadoModel : IModel<Empleado>
    {
        Empleado FindById(int codigo);
        int GetLastEmpleadoId();
    }
}
