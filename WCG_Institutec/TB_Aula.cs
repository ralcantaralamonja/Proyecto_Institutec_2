//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCG_Institutec
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_Aula
    {
        public string IdAula { get; set; }
        public string IdCent { get; set; }
        public Nullable<byte> AfoAul { get; set; }
        public Nullable<bool> Habita { get; set; }
        public Nullable<System.DateTime> Fec_Registro { get; set; }
        public string Usu_Registro { get; set; }
        public Nullable<System.DateTime> Fec_Ult_Mod { get; set; }
        public string Usu_Ult_Mod { get; set; }
    
        public virtual TB_local TB_local { get; set; }
    }
}
