using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tarea.Entidades
{
    public class Usuario_Has_Permiso
    {
        [Key]
        public int IdUsuarioPermiso { get; set; }
        public int IdUsuario { get; set; }
        public int IdPermiso { get; set; }

        public Usuario_Has_Permiso()
        {
            IdUsuarioPermiso = 0;
            IdUsuario = 0;
            IdPermiso = 0;
        }
    }
}
