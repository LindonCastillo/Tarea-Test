using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_Tarea.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tarea.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Assert.Persona();
        }
    }
}