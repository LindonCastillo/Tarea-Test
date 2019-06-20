using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tarea.Entidades
{
    public class Modelo
    {
        [Key]
        public int IdModelo { get; set; }
        public string NombreModelo { get; set; }

        public Modelo()
        {
            IdModelo = 0;
            NombreModelo = string.Empty;
        }
    }
}
