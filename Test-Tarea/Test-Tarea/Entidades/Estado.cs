using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tarea.Entidades
{
    public class Estado
    {
        [Key]
        public int IdEstado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string estado { get; set; }

        public Estado()
        {
            IdEstado = 0;
            FechaInicio = DateTime.Now;
            FechaFin = DateTime.Now;
            estado = string.Empty;

        }
    }
}
