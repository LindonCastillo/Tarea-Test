using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tarea.Entidades
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public int IdEmpleado { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }

        public Usuario()
        {
            IdUsuario = 0;
            IdEmpleado = 0;
            NombreUsuario = string.Empty;
            Clave = string.Empty;
        }
    }
}
