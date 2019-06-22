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
    public class UsuarioTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Usuario> test = new RepositorioBase<Usuario>();
            Usuario usuario = new Usuario();
            usuario.IdUsuario = 0;
            usuario.IdEmpleado = 5;
            usuario.NombreUsuario = "chamo";
            usuario.Clave = "12345";
            Assert.IsTrue(test.Guardar(usuario));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Usuario> db = new RepositorioBase<Usuario>();
            Usuario usuario = new Usuario();
            usuario.IdUsuario = 1;
            usuario.IdEmpleado = 5;
            usuario.NombreUsuario = "chamo";
            usuario.Clave = "asdfghjkl";
            Assert.IsTrue(db.Modificar(usuario));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Usuario> db = new RepositorioBase<Usuario>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Usuario> db = new RepositorioBase<Usuario>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Usuario> db = new RepositorioBase<Usuario>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}