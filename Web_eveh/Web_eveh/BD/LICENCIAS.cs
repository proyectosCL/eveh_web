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
    
    public partial class LICENCIAS
    {
        public decimal ID { get; set; }
        public decimal NUMERO { get; set; }
        public decimal TIPOS_LICENCIAS_ID { get; set; }
        public System.DateTime FECHA_VENCIMIENTO { get; set; }
        public decimal HORAS_VUELO { get; set; }
        public decimal DIAS_VUELO { get; set; }
        public decimal PILOTOS_ID { get; set; }
    
        public virtual PILOTOS PILOTOS { get; set; }
        public virtual TIPOS_LICENCIAS TIPOS_LICENCIAS { get; set; }
    }
}
