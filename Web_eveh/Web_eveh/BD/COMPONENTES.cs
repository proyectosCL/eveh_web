//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_eveh.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class COMPONENTES
    {
        public COMPONENTES()
        {
            this.COMPONENTES1 = new HashSet<COMPONENTES>();
            this.DETALLES_MANTENIMIENTOS = new HashSet<DETALLES_MANTENIMIENTOS>();
        }
    
        public decimal ID { get; set; }
        public string DESCRIPCION { get; set; }
        public string FABRICANTE { get; set; }
        public decimal HORAS_VUELO { get; set; }
        public decimal DIAS_VUELO { get; set; }
        public decimal TIPOS_COMPONENTES_ID { get; set; }
        public Nullable<decimal> COMPONENTES_ID { get; set; }
        public Nullable<decimal> AERONAVES_ID { get; set; }
    
        public virtual AERONAVES AERONAVES { get; set; }
        public virtual ICollection<COMPONENTES> COMPONENTES1 { get; set; }
        public virtual COMPONENTES COMPONENTES2 { get; set; }
        public virtual TIPOS_COMPONENTES TIPOS_COMPONENTES { get; set; }
        public virtual ICollection<DETALLES_MANTENIMIENTOS> DETALLES_MANTENIMIENTOS { get; set; }
    }
}
