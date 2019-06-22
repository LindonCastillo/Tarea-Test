using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_Tarea.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Tarea.BLL;
using Test_Tarea.DAL;

namespace Test_Tarea.Entidades.Tests
{
    [TestClass()]
    public class CargoTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Cargo> test = new RepositorioBase<Cargo>();
            Cargo cargo = new Cargo();
            cargo.IdCargo = 0;
            cargo.IdEstado = 1;
            cargo.NombreCargo = "Papitas";

            Assert.IsTrue(test.Guardar(cargo));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Cargo> db = new RepositorioBase<Cargo>();

            Cargo cargo = new Cargo();
            cargo.IdCargo = 1;
            cargo.IdEstado = 1;
            cargo.NombreCargo = "Choripan";

            Assert.IsTrue(db.Modificar(cargo));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Cargo> db = new RepositorioBase<Cargo>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Cargo> db = new RepositorioBase<Cargo>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Cargo> db = new RepositorioBase<Cargo>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}