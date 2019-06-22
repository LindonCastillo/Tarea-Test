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
    public class ProductoTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Producto> test = new RepositorioBase<Producto>();
            Producto producto = new Producto();
            producto.IdProducto = 0;
            producto.Nombre = "Papitas";
            producto.Descripcion = string.Empty;
            producto.FechaFabricacion = DateTime.Now;
            producto.CostoCompra = 0;
            producto.Stock = 0;
            producto.IdUnidadMedida = 0;
            producto.IdImagen = 0;
            producto.IdMarca = 0;
            producto.IdCategoria = 0;
            producto.IdModelo = 0;

            Assert.IsTrue(test.Guardar(producto));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Producto> db = new RepositorioBase<Producto>();

            Producto producto = new Producto();
            producto.IdProducto = 1;
            producto.Nombre = "Papitas";
            producto.Descripcion = "se come";
            producto.FechaFabricacion = DateTime.Now;
            producto.CostoCompra = 0;
            producto.Stock = 0;
            producto.IdUnidadMedida = 0;
            producto.IdImagen = 0;
            producto.IdMarca = 0;
            producto.IdCategoria = 0;
            producto.IdModelo = 0;


            Assert.IsTrue(db.Modificar(producto));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Producto> db = new RepositorioBase<Producto>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Producto> db = new RepositorioBase<Producto>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Producto> db = new RepositorioBase<Producto>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}