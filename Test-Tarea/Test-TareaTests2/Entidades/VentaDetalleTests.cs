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
    public class VentaDetalleTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<VentaDetalle> test = new RepositorioBase<VentaDetalle>();
            VentaDetalle vd = new VentaDetalle();
            vd.IdVentaDetalle = 0;
            vd.IdVenta = 5;
            vd.IdProducto = 85;
            vd.Unidades = 50;
            vd.CostoUnidad = 100;
            vd.DescuentoUnidad = 7;
            vd.Total = 5000;

            Assert.IsTrue(test.Guardar(vd));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<VentaDetalle> db = new RepositorioBase<VentaDetalle>();
            VentaDetalle vd = new VentaDetalle();
            vd.IdVentaDetalle = 1;
            vd.IdVenta = 8;
            vd.IdProducto = 45;
            vd.Unidades = 10;
            vd.CostoUnidad = 50;
            vd.DescuentoUnidad = 7;
            vd.Total = 500;

            Assert.IsTrue(db.Modificar(vd));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<VentaDetalle> db = new RepositorioBase<VentaDetalle>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<VentaDetalle> db = new RepositorioBase<VentaDetalle>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<VentaDetalle> db = new RepositorioBase<VentaDetalle>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}