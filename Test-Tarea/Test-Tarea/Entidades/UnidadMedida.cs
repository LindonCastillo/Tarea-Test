using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tarea.Entidades
{
    public class UnidadMedida
    {
        [Key]
        public int IdUnidadMedida { get; set; }
        public string NombreMarca { get; set; }

        public UnidadMedida()
        {
            IdUnidadMedida = 0;
            NombreMarca = string.Empty;
        }
    }
}
