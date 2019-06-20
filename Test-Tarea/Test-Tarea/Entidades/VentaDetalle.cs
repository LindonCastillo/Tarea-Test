using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tarea.Entidades
{
    public class VentaDetalle
    {
        [Key]
        public int IdVentaDetalle { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public double Unidades { get; set; }
        public double CostoUnidad { get; set; }
        public double DescuentoUnidad { get; set; }
        public double Total { get; set; }

        public VentaDetalle()
        {
            IdVentaDetalle = 0;
            IdVenta = 0;
            IdProducto = 0;
            Unidades = 0;
            CostoUnidad = 0;
            DescuentoUnidad = 0;
            Total = 0;
        }
    }
}
