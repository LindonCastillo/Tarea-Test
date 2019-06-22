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
    public class CompraTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Compra> test = new RepositorioBase<Compra>();
            Compra c = new Compra();
            c.IdCompra = 0;
            c.IdUsuario = 3;
            c.FechaCompra = DateTime.Now;
            c.IdProveedor = 82;
            c.CostoCompra = 12;

            c.compraDetalle = new List<CompraDetalle>();

            Assert.IsTrue(test.Guardar(c));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Compra> db = new RepositorioBase<Compra>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Compra> db = new RepositorioBase<Compra>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}