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
    public class CategoriaTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Categoria> test = new RepositorioBase<Categoria>();
            Categoria categoria = new Categoria();
            categoria.IdCategoria = 0;
            categoria.NombreCategoria = "Algo";
            categoria.Descripcion = "Algo";

            Assert.IsTrue(test.Guardar(categoria));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Categoria> db = new RepositorioBase<Categoria>();

            Categoria categoria = new Categoria();
            categoria.IdCategoria = 0;
            categoria.NombreCategoria = "Algo";
            categoria.Descripcion = "Algo ahi";

            Assert.IsTrue(db.Modificar(categoria));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Categoria> db = new RepositorioBase<Categoria>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Categoria> db = new RepositorioBase<Categoria>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Categoria> db = new RepositorioBase<Categoria>();

            Assert.IsTrue(db.Eliminar(1));
        }
    
    }
}