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
    public class PermisoTests
    {

            [TestMethod()]
            public void GuardarTest()
            {
                RepositorioBase<Permiso> test = new RepositorioBase<Permiso>();
                Permiso permiso = new Permiso();
                permiso.IdPermiso = 0;
                permiso.Descripcion = "hell";
                permiso.Funcionalidad = "algo";

                Assert.IsTrue(test.Guardar(permiso));
            }

            [TestMethod()]
            public void ModificarTest()
            {
                RepositorioBase<Permiso> db = new RepositorioBase<Permiso>();

                Permiso permiso = new Permiso();
                permiso.IdPermiso = 1;
                permiso.Descripcion = "viceAlgo";
                permiso.Funcionalidad = "algo 2";

                Assert.IsTrue(db.Modificar(permiso));

            }

            [TestMethod()]
            public void BuscarTest()
            {
                RepositorioBase<Permiso> db = new RepositorioBase<Permiso>();

                Assert.IsNotNull(db.Buscar(1));

            }

            [TestMethod()]
            public void GetListTest()
            {
                RepositorioBase<Permiso> db = new RepositorioBase<Permiso>();

                Assert.IsNotNull(db.GetList(t => true));

            }

            [TestMethod()]
            public void EliminarTest()
            {
                RepositorioBase<Permiso> db = new RepositorioBase<Permiso>();

                Assert.IsTrue(db.Eliminar(1));
            }
        
    }
}