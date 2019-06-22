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
    public class EmpleadoTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Empleado> test = new RepositorioBase<Empleado>();
            Empleado empleado = new Empleado();

            empleado.IdEmpleado = 0;
            empleado.IdEstado = 0;
            empleado.IdCargo = 0;
            empleado.IdPersona = 0;

            Assert.IsTrue(test.Guardar(empleado));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Empleado> db = new RepositorioBase<Empleado>();

            Empleado empleado = new Empleado();
            empleado.IdEmpleado = 1;
            empleado.IdEstado = 2;
            empleado.IdCargo = 2;
            empleado.IdPersona = 3;
            Assert.IsTrue(db.Modificar(empleado));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Empleado> db = new RepositorioBase<Empleado>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Empleado> db = new RepositorioBase<Empleado>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Empleado> db = new RepositorioBase<Empleado>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}