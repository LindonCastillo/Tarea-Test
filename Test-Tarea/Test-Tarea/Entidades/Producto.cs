using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tarea.Entidades
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaFabricacion { get; set; }
        public double CostoCompra { get; set; }
        public double Stock { get; set; }


        public Producto()
        {
            IdProducto = 0;
            Nombre = string.Empty;
            Descripcion = string.Empty;
            FechaFabricacion = DateTime.Now;
            CostoCompra = 0;
            Stock = 0;
        }
    }
}
