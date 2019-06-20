using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tarea.Entidades
{
    public class Proveedor
    {
        [Key]
        public int IdProveedor { get; set; }
        public int IdPersona { get; set; }

        public Proveedor()
        {
            IdProveedor = 0;
            IdPersona = 0;
        }
    }
}
