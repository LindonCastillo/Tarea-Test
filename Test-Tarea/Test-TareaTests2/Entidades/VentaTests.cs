using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_Tarea.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Tarea.BLL;

namespace Test_Tarea.Entidades.Tests
{
    [TestClass()]
    public class VentaTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Venta> test = new RepositorioBase<Venta>();
            Venta v = new Venta();
            v.IdVenta = 0;
            v.IdUsuario = 6;
            v.IdCliente = 6;
            v.IdComprobante = 51;
            v.FechaVenta = DateTime.Now;
            v.Igv = 41;
            v.Subtotal = 5000;
            v.CostoVenta = 225;

            v.ventaDetalle = new List<VentaDetalle>();

            Assert.IsTrue(test.Guardar(v));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Venta> db = new RepositorioBase<Venta>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Venta> db = new RepositorioBase<Venta>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}