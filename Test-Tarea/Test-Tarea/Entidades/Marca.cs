using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tarea.Entidades
{
    public class Marca
    {
        [Key]
        public int IdMarca { get; set; }
        public string NombreMarca { get; set; }

        public Marca()
        {
            IdMarca = 0;
            NombreMarca = string.Empty;
        }
    }
}
