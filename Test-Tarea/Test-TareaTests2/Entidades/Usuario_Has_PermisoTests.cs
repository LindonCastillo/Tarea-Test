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
    public class Usuario_Has_PermisoTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Usuario_Has_Permiso> test = new RepositorioBase<Usuario_Has_Permiso>();
            Usuario_Has_Permiso usuarioP = new Usuario_Has_Permiso();
            usuarioP.IdUsuarioPermiso = 0;
            usuarioP.IdUsuario = 65;
            usuarioP.IdPermiso = 5;
            Assert.IsTrue(test.Guardar(usuarioP));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Usuario_Has_Permiso> db = new RepositorioBase<Usuario_Has_Permiso>();
            Usuario_Has_Permiso usuarioP = new Usuario_Has_Permiso();
            usuarioP.IdUsuarioPermiso = 1;
            usuarioP.IdUsuario = 32;
            usuarioP.IdPermiso = 5;
            Assert.IsTrue(db.Modificar(usuarioP));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Usuario_Has_Permiso> db = new RepositorioBase<Usuario_Has_Permiso>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Usuario_Has_Permiso> db = new RepositorioBase<Usuario_Has_Permiso>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Usuario_Has_Permiso> db = new RepositorioBase<Usuario_Has_Permiso>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}