using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tarea.Entidades
{
    public class Venta
    {
        [Key]
        public int IdVenta { get; set; }
        public int IdUsuario { get; set; }
        public int IdCliente { get; set; }
        public int IdComprobante { get; set; }
        public DateTime FechaVenta { get; set; }
        public double Igv { get; set; }
        public double Subtotal { get; set; }
        public double CostoVenta { get; set; }

        public virtual List<VentaDetalle> ventaDetalle { get; set; }

        public Venta()
        {
            IdVenta = 0;
            IdUsuario = 0;
            IdCliente = 0;
            IdComprobante = 0;
            FechaVenta = DateTime.Now;
            Igv = 0;
            Subtotal = 0;
            CostoVenta = 0;

            ventaDetalle = new List<VentaDetalle>();
        }
    }
}
