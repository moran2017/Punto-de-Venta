//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PV.DL.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleCompras
    {
        public int DetalleCompraId { get; set; }
        public int MarcaId { get; set; }
        public int ProductoId { get; set; }
        public int TipoProductoId { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public int UsuarioId { get; set; }
        public double TotalCompra { get; set; }
        public int TipoPagoId { get; set; }
    
        public virtual Marcas Marcas { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}