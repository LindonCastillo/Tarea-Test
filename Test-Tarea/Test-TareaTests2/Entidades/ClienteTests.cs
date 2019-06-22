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
    public class ClienteTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Cliente> test = new RepositorioBase<Cliente>();
            Cliente cliente = new Cliente();
            cliente.IdCliente = 0;
            cliente.Nombre = string.Empty;
            cliente.Cedula = string.Empty;
            cliente.Celular = string.Empty;
            cliente.Telefono = string.Empty;
            cliente.Direccion = string.Empty;
            cliente.LimiteCredito = 0;

            Assert.IsTrue(test.Guardar(cliente));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Cliente> db = new RepositorioBase<Cliente>();

            Cliente cliente = new Cliente();
            cliente.IdCliente = 1;
            cliente.Nombre = "San juan";
            cliente.Cedula = "algo";
            cliente.Celular = "algo";
            cliente.Telefono = "algo";
            cliente.Direccion = "algo";
            cliente.LimiteCredito = 1200;

            Assert.IsTrue(db.Modificar(cliente));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Cliente> db = new RepositorioBase<Cliente>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Cliente> db = new RepositorioBase<Cliente>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Cliente> db = new RepositorioBase<Cliente>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}