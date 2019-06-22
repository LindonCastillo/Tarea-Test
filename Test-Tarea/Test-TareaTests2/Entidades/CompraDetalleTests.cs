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
    public class CompraDetalleTests
    {

        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<CompraDetalle> test = new RepositorioBase<CompraDetalle>();
            CompraDetalle cd = new CompraDetalle();
            cd.IdCompraDetalle = 0;
            cd.IdCompra = 5;
            cd.IdProducto = 6;
            cd.Unidades = 5;
            cd.CostoUnidad = 3;
            cd.Total = 4;

            Assert.IsTrue(test.Guardar(cd));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<CompraDetalle> db = new RepositorioBase<CompraDetalle>();
            CompraDetalle cd = new CompraDetalle();
            cd.IdCompraDetalle = 1;
            cd.IdCompra = 15;
            cd.IdProducto = 6;
            cd.Unidades = 5;
            cd.CostoUnidad = 3;
            cd.Total = 4;

            Assert.IsTrue(db.Modificar(cd));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<CompraDetalle> db = new RepositorioBase<CompraDetalle>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<CompraDetalle> db = new RepositorioBase<CompraDetalle>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<CompraDetalle> db = new RepositorioBase<CompraDetalle>();

            Assert.IsTrue(db.Eliminar(1));
        }

    }
}