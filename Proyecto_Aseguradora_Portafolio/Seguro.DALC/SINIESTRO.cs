//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Seguro.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class SINIESTRO
    {
        public string ID_SINIESTRO { get; set; }
        public System.DateTime FECHA { get; set; }
        public Nullable<System.DateTime> FECHA_TERMINO { get; set; }
        public string ESTADO { get; set; }
        public decimal DEDUCIBLE_UF { get; set; }
        public Nullable<int> COSTE_REPARACION { get; set; }
        public string CLIENTE_ID_CLIENTE { get; set; }
        public string LIQUIDADOR_ID_LIQUIDADOR { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual LIQUIDADOR LIQUIDADOR { get; set; }
    }
}
