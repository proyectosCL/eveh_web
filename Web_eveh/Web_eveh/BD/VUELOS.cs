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
    
    public partial class VUELOS
    {
        public VUELOS()
        {
            this.TRIPULACION = new HashSet<TRIPULACION>();
        }
    
        public decimal ID { get; set; }
        public decimal AERODROMOS_ID_ORIGEN { get; set; }
        public decimal AERODROMOS_ID_DESTINO { get; set; }
        public Nullable<decimal> HORAS_VUELO { get; set; }
        public string CONDICION_VUELO { get; set; }
        public string MISION_VUELO { get; set; }
        public System.DateTime FECHA_VUELO { get; set; }
        public decimal AERONAVES_ID { get; set; }
        public string ESTADO_VUELO { get; set; }
    
        public virtual AERODROMOS AERODROMOS { get; set; }
        public virtual AERODROMOS AERODROMOS1 { get; set; }
        public virtual AERONAVES AERONAVES { get; set; }
        public virtual ICollection<TRIPULACION> TRIPULACION { get; set; }
    }
}
