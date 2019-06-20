using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tarea.Entidades
{
    public class Imagen
    {
        public int IdImagen { get; set; }
        public string RutaImagen { get; set; }

        public Imagen()
        {
            IdImagen = 0;
            RutaImagen = string.Empty;
        }
    }
}
