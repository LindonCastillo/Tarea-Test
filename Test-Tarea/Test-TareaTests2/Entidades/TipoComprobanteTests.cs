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
    public class TipoComprobanteTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<TipoComprobante> test = new RepositorioBase<TipoComprobante>();
            TipoComprobante tp = new TipoComprobante();
            tp.IdTipoComprobante = 0;
            tp.NombreComprobante = "ALGO";
            Assert.IsTrue(test.Guardar(tp));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<TipoComprobante> db = new RepositorioBase<TipoComprobante>();
            TipoComprobante tp = new TipoComprobante();
            tp.IdTipoComprobante = 1;
            tp.NombreComprobante = "alguito";
            Assert.IsTrue(db.Modificar(tp));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<TipoComprobante> db = new RepositorioBase<TipoComprobante>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<TipoComprobante> db = new RepositorioBase<TipoComprobante>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<TipoComprobante> db = new RepositorioBase<TipoComprobante>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}