﻿using System;
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
        public DbSet<Cargo> cargo { set; get; }
        public DbSet<Categoria> categoria { set; get; }
        public DbSet<Cliente> cliente { set; get; }
        public DbSet<Compra> compra { set; get; }
        public DbSet<CompraDetalle> compraDetalle { set; get; }
        public DbSet<Empleado> empleado { set; get; }
        public DbSet<Estado> estado { set; get; }
        public DbSet<Imagen> imagen { set; get; }
        public DbSet<Marca> marca { set; get; }
        public DbSet<Modelo> modelo { set; get; }
        public DbSet<Permiso> permiso { set; get; }
        public DbSet<Persona> persona { get; set; }
        public DbSet<Producto> producto { set; get; }
        public DbSet<Proveedor> proveedor { set; get; }
        public DbSet<TipoComprobante> tipoComprobante { set; get; }
        public DbSet<TipoPersona> tipoPersona { get; set; }
        public DbSet<UnidadMedida> unidadMedida { set; get; }
        public DbSet<Usuario> usuario { set; get; }
        public DbSet<Usuario_Has_Permiso> usuarioPermiso  { set; get; }
        public DbSet<Venta> venta { set; get; }
        public DbSet<VentaDetalle> ventaDetalle { set; get; }


        public Contexto() : base("Constr") { }
    }
}
