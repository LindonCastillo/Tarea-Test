using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tarea.Entidades
{
    public class CompraDetalle
    {
        [Key]
        public int IdCompraDetalle { get; set; }
        public int IdCompra { get; set; }
        public int IdProducto { get; set; }
        public double Unidades { get; set; }
        public double CostoUnidad { get; set; }
        public double Total { get; set; }

        public CompraDetalle()
        {
            IdCompraDetalle = 0;
            IdCompra = 0;
            IdProducto = 0;
            Unidades = 0;
            CostoUnidad = 0;
            Total = 0;
        }
    }
}
