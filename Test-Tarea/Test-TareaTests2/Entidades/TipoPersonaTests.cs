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
    public class TipoPersonaTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<TipoPersona> test = new RepositorioBase<TipoPersona>();
            TipoPersona tp = new TipoPersona();
            tp.IdTipoPersona = 0;
            tp.IdPersona = 5;
            tp.Nombre = "paco";
            Assert.IsTrue(test.Guardar(tp));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<TipoPersona> db = new RepositorioBase<TipoPersona>();
            TipoPersona tp = new TipoPersona();
            tp.IdTipoPersona = 1;
            tp.IdPersona = 6;
            tp.Nombre = "paco";
            Assert.IsTrue(db.Modificar(tp));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<TipoPersona> db = new RepositorioBase<TipoPersona>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<TipoPersona> db = new RepositorioBase<TipoPersona>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<TipoPersona> db = new RepositorioBase<TipoPersona>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}