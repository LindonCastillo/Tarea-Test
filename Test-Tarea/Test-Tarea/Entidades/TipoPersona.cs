using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tarea.Entidades
{
    public class TipoPersona
    {
        [Key]
        public int IdTipoPersona { get; set; }
        public int IdPersona { get; set; }
        public string Nombre { get; set; }

        public TipoPersona()
        {
            IdTipoPersona = 0;
            IdPersona = 0;
            Nombre = string.Empty;
        }
    }
}
