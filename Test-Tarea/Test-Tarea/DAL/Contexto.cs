using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Tarea.Entidades;

namespace Test_Tarea.DAL
{
    public class Contexto : DbContext
    {
        //Persona
        public DbSet<Persona> persona { get; set; }
        public DbSet<TipoPersona> tipoPersona { get; set; }

        //Producto
        public DbSet<Producto> producto { set; get; }
        public DbSet<Categoria> categoria { set; get; }
        public DbSet<Marca> marca { set; get; }
        public DbSet<UnidadMedida> unidadMedida { set; get; }

        //Compra
        public DbSet<Compra> compra { set; get; }




        public Contexto() : base("Constr") { }
    }
}
