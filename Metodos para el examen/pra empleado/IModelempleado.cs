using System;
using System.Collections.Generic;
using System.Text;

namespace Metodos_para_el_examen.pra_empleado
{
  public   interface IModelempleado :Imodel<Empleado>
    {
        Empleado FindById(int id);
        int GetLastEmpleadoId();
    }
}
