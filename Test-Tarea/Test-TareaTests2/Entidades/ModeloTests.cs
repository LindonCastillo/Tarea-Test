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
    public class ModeloTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Modelo> test = new RepositorioBase<Modelo>();
            Modelo modelo = new Modelo();
            modelo.IdModelo = 0;
            modelo.NombreModelo = "algo";

            Assert.IsTrue(test.Guardar(modelo));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Modelo> db = new RepositorioBase<Modelo>();

            Modelo modelo = new Modelo();
            modelo.IdModelo = 1;
            modelo.NombreModelo = "toyota";

            Assert.IsTrue(db.Modificar(modelo));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Modelo> db = new RepositorioBase<Modelo>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Modelo> db = new RepositorioBase<Modelo>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Modelo> db = new RepositorioBase<Modelo>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}