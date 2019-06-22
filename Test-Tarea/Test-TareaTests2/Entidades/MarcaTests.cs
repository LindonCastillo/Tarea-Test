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
    public class MarcaTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Marca> test = new RepositorioBase<Marca>();
            Marca marca = new Marca();
            marca.IdMarca = 0;
            marca.NombreMarca = "patito";

            Assert.IsTrue(test.Guardar(marca));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Marca> db = new RepositorioBase<Marca>();

            Marca marca = new Marca();
            marca.IdMarca = 1;
            marca.NombreMarca = "Acme";

            Assert.IsTrue(db.Modificar(marca));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Marca> db = new RepositorioBase<Marca>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Marca> db = new RepositorioBase<Marca>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Marca> db = new RepositorioBase<Marca>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}