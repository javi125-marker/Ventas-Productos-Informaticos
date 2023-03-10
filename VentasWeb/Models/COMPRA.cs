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
    
    public partial class COMPRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPRA()
        {
            this.DETALLE_COMPRA = new HashSet<DETALLE_COMPRA>();
        }
    
        public int IdCompra { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<int> IdProveedor { get; set; }
        public Nullable<int> IdTienda { get; set; }
        public Nullable<decimal> TotalCosto { get; set; }
        public string TipoComprobante { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
    
        public virtual PROVEEDOR PROVEEDOR { get; set; }
        public virtual TIENDA TIENDA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_COMPRA> DETALLE_COMPRA { get; set; }
    }
}
