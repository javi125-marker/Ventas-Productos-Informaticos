//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class PRODUCTO_TIENDA
    {
        public int IdProductoTienda { get; set; }
        public Nullable<int> IdProducto { get; set; }
        public Nullable<int> IdTienda { get; set; }
        public Nullable<decimal> PrecioUnidadCompra { get; set; }
        public Nullable<decimal> PrecioUnidadVenta { get; set; }
        public Nullable<long> Stock { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<bool> Iniciado { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
    
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual TIENDA TIENDA { get; set; }
    }
}
