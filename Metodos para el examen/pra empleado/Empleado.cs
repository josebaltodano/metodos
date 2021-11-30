
using System;
using System.Collections.Generic;
using System.Text;

namespace Metodos_para_el_examen.pra_empleado
{
  public   class Empleado
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public decimal Salario { get; set; }
        public DateTime FechaContratacion { get; set; }
        public Empleado(int id, int codigo, string cedula, string nombres, string apellidos, decimal salario, DateTime fechaContratacion)
        {
            Id = id;
            Codigo = codigo;
            Cedula = cedula;
            Nombres = nombres;
            Apellidos = apellidos;
            Salario = salario;
            FechaContratacion = fechaContratacion;
        }

       
    }
}
