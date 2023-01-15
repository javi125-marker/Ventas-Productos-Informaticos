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
    
    public partial class VENTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VENTA()
        {
            this.DETALLE_VENTA = new HashSet<DETALLE_VENTA>();
        }
    
        public int IdVenta { get; set; }
        public string Codigo { get; set; }
        public Nullable<int> ValorCodigo { get; set; }
        public Nullable<int> IdTienda { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public string TipoDocumento { get; set; }
        public Nullable<int> CantidadProducto { get; set; }
        public Nullable<int> CantidadTotal { get; set; }
        public Nullable<decimal> TotalCosto { get; set; }
        public Nullable<decimal> ImporteRecibido { get; set; }
        public Nullable<decimal> ImporteCambio { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_VENTA> DETALLE_VENTA { get; set; }
        public virtual TIENDA TIENDA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
