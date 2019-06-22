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
    public class ProveedorTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Proveedor> test = new RepositorioBase<Proveedor>();
            Proveedor proveedor = new Proveedor();
            proveedor.IdProveedor = 0;
            proveedor.IdPersona = 1;
            Assert.IsTrue(test.Guardar(proveedor));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Proveedor> db = new RepositorioBase<Proveedor>();
            Proveedor proveedor = new Proveedor();
            proveedor.IdProveedor = 1;
            proveedor.IdPersona = 2;
            Assert.IsTrue(db.Modificar(proveedor));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Proveedor> db = new RepositorioBase<Proveedor>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Proveedor> db = new RepositorioBase<Proveedor>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Proveedor> db = new RepositorioBase<Proveedor>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}