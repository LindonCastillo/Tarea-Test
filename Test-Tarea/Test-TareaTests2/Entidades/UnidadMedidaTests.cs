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
    public class UnidadMedidaTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<UnidadMedida> test = new RepositorioBase<UnidadMedida>();
            UnidadMedida unidad = new UnidadMedida();
            unidad.IdUnidadMedida = 0;
            unidad.NombreMarca = "polo";
            Assert.IsTrue(test.Guardar(unidad));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<UnidadMedida> db = new RepositorioBase<UnidadMedida>();
            UnidadMedida unidad = new UnidadMedida();
            unidad.IdUnidadMedida = 1;
            unidad.NombreMarca = "polo cha";
            Assert.IsTrue(db.Modificar(unidad));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<UnidadMedida> db = new RepositorioBase<UnidadMedida>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<UnidadMedida> db = new RepositorioBase<UnidadMedida>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<UnidadMedida> db = new RepositorioBase<UnidadMedida>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}