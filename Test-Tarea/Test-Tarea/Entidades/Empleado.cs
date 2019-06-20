using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tarea.Entidades
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        public int IdEstado { get; set; }
        public int IdCargo { get; set; }
        public int IdPersona { get; set; }

        public Empleado()
        {
            IdEmpleado = 0;
            IdEstado = 0;
            IdCargo = 0;
            IdPersona = 0;
        }
    }
}
