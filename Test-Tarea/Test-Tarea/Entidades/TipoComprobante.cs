using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tarea.Entidades
{
    public class TipoComprobante
    {
        [Key]
        public int IdTipoComprobante { get; set; }
        public string NombreComprobante { get; set; }

        public TipoComprobante()
        {
            IdTipoComprobante = 0;
            NombreComprobante = string.Empty;
        }
    }
}
