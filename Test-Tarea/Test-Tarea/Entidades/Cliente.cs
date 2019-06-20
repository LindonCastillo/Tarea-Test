using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Tarea.Entidades
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public double LimiteCredito { get; set; }

        public Cliente()
        {
            IdCliente = 0;
            Nombre = string.Empty;
            Cedula = string.Empty;
            Celular = string.Empty;
            Telefono = string.Empty;
            Direccion = string.Empty;
            LimiteCredito = 0;
        }
    }
}
