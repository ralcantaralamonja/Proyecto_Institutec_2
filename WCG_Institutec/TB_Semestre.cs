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
    
    public partial class TB_Semestre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Semestre()
        {
            this.TB_Matricula = new HashSet<TB_Matricula>();
        }
    
        public string IdSeme { get; set; }
        public string Descrp { get; set; }
        public Nullable<System.DateTime> FecInc { get; set; }
        public Nullable<System.DateTime> FecFin { get; set; }
        public Nullable<System.DateTime> Fec_Registro { get; set; }
        public string Usu_Registro { get; set; }
        public Nullable<System.DateTime> Fec_Ult_Mod { get; set; }
        public string Usu_Ult_Mod { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Matricula> TB_Matricula { get; set; }
    }
}
