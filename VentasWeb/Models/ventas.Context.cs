﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VentasWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBVENTAS_WEBEntities : DbContext
    {
        public DBVENTAS_WEBEntities()
            : base("name=DBVENTAS_WEBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CATEGORIA> CATEGORIA { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<COMPRA> COMPRA { get; set; }
        public virtual DbSet<DETALLE_COMPRA> DETALLE_COMPRA { get; set; }
        public virtual DbSet<DETALLE_VENTA> DETALLE_VENTA { get; set; }
        public virtual DbSet<MENU> MENU { get; set; }
        public virtual DbSet<PERMISOS> PERMISOS { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTO { get; set; }
        public virtual DbSet<PRODUCTO_TIENDA> PRODUCTO_TIENDA { get; set; }
        public virtual DbSet<PROVEEDOR> PROVEEDOR { get; set; }
        public virtual DbSet<ROL> ROL { get; set; }
        public virtual DbSet<SUBMENU> SUBMENU { get; set; }
        public virtual DbSet<TIENDA> TIENDA { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
        public virtual DbSet<VENTA> VENTA { get; set; }
    }
}
