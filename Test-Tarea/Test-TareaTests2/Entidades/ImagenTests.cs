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
    public class ImagenTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Imagen> test = new RepositorioBase<Imagen>();
            Imagen imagen = new Imagen();
            imagen.IdImagen = 0;
            imagen.RutaImagen = "Ninguno";

            Assert.IsTrue(test.Guardar(imagen));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Imagen> db = new RepositorioBase<Imagen>();

            Imagen imagen = new Imagen();
            imagen.IdImagen = 1;
            imagen.RutaImagen = "algo/algo/";

            Assert.IsTrue(db.Modificar(imagen));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Imagen> db = new RepositorioBase<Imagen>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Imagen> db = new RepositorioBase<Imagen>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Imagen> db = new RepositorioBase<Imagen>();

            Assert.IsTrue(db.Eliminar(1));
        }
    
    }
}