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
    public class PersonaTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Persona> test = new RepositorioBase<Persona>();
            Persona persona = new Persona();
            persona.IdPersona = 0;
            persona.Dni = 846;
            persona.Nombre = "papa";
            persona.Materno = "algo";
            persona.Paterno = "papaitas";
            persona.FechaNacimiento = DateTime.Now;
            persona.Telefono = string.Empty;
            persona.Correo = string.Empty;
            persona.Sexo = string.Empty;
            persona.IdImagen = 0;
            persona.Direccion = string.Empty;
            persona.IdTipoPersona = 0;

            Assert.IsTrue(test.Guardar(persona));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Persona> db = new RepositorioBase<Persona>();

            Persona persona = new Persona();
            persona.IdPersona = 1;
            persona.Dni = 846;
            persona.Nombre = "papa";
            persona.Materno = "algo";
            persona.Paterno = "papaitas";
            persona.FechaNacimiento = DateTime.Now;
            persona.Telefono = "844-448-4125";
            persona.Correo = string.Empty;
            persona.Sexo = string.Empty;
            persona.IdImagen = 0;
            persona.Direccion = string.Empty;
            persona.IdTipoPersona = 0;

            Assert.IsTrue(db.Modificar(persona));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Persona> db = new RepositorioBase<Persona>();

            Assert.IsNotNull(db.Buscar(1));

        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Persona> db = new RepositorioBase<Persona>();

            Assert.IsNotNull(db.GetList(t => true));

        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Persona> db = new RepositorioBase<Persona>();

            Assert.IsTrue(db.Eliminar(1));
        }
    }
}