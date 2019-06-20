using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tarea.Entidades
{
    public class Compra
    {
        [Key]
        public int IdCompra { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaCompra { get; set; }
        public int IdProveedor { get; set; }
        public double CostoCompra { get; set; }
        public virtual List<CompraDetalle> compraDetalle { get; set; }

        public Compra()
        {
            IdCompra = 0;
            IdUsuario = 0;
            FechaCompra = DateTime.Now;
            IdProveedor = 0;
            CostoCompra = 0;

            compraDetalle = new List<CompraDetalle>();
        }
    }
}
