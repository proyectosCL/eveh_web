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
    
    public partial class DETALLES_MANTENIMIENTOS
    {
        public decimal MANTENIMIENTOS_ID { get; set; }
        public decimal COMPONENTES_ID { get; set; }
        public decimal PLANES_ID { get; set; }
        public string ESTADO { get; set; }
        public string TAREAS_SELECCIONADAS { get; set; }
    
        public virtual COMPONENTES COMPONENTES { get; set; }
        public virtual MANTENIMIENTOS MANTENIMIENTOS { get; set; }
        public virtual PLANES PLANES { get; set; }
    }
}
