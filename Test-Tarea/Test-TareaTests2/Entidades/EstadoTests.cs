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
    public class EstadoTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Estado> test = new RepositorioBase<Estado>();
            Estado estado = new Estado();
            estado.IdEstado = 0;
            estado.FechaInicio = DateTime.Now;
            estado.FechaFin = DateTime.Now;
            estado.estado = "Soltero";


            Assert.IsTrue(test.Guardar(estado));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Estado> db = new RepositorioBase<Estado>();

            Estado estado = new Estado();
            estado.IdEstado = 1;
            estado.FechaInicio = DateTime.Now;
            estado.FechaFin = DateTime.Now;
            estado.estado = "Casado";

            Assert.IsTrue(db.Modificar(estado));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Estado> db = new RepositorioBase<Estado>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Estado> db = new RepositorioBase<Estado>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Estado> db = new RepositorioBase<Estado>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}