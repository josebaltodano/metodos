using System;
using System.Collections.Generic;
using System.Text;

namespace Metodos_para_el_examen.pra_empleado
{
    public class EmpleadoModel : IModelempleado
    {
        private Empleado[] empleados;
        public void Create(Empleado t)
        {
            if (empleados == null)
            {
                empleados = new Empleado[1];
                empleados[0] = t;
                return;
            }

            Empleado[] temp = new Empleado[empleados.Length + 1];
            Array.Copy(empleados, temp, empleados.Length);
            temp[temp.Length - 1] = t;

            empleados = temp;
        }

        public bool Delete(Empleado t)
        {
            throw new NotImplementedException();
        }

        public Empleado[] FindAll()
        {
            throw new NotImplementedException();
        }

        public Empleado FindById(int id)
        {
            throw new NotImplementedException();
        }

        public int GetLastEmpleadoId()
        {
            throw new NotImplementedException();
        }

        public int Update(Empleado t)
        {
            throw new NotImplementedException();
        }
    }
}
