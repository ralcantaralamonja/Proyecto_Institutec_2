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
    
    public partial class Tb_Seccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Seccion()
        {
            this.TB_Matricula = new HashSet<TB_Matricula>();
        }
    
        public string IdCods { get; set; }
        public string IdCurs { get; set; }
        public string IdProf { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<byte> Vacant { get; set; }
        public string DIA { get; set; }
        public string IdCent { get; set; }
        public Nullable<System.DateTime> Fec_Registro { get; set; }
        public string Usu_Registro { get; set; }
        public Nullable<System.DateTime> Fec_Ult_Mod { get; set; }
        public string Usu_Ult_Mod { get; set; }
        public Nullable<System.TimeSpan> HorIni { get; set; }
        public Nullable<System.TimeSpan> HorFin { get; set; }
    
        public virtual Tb_Curso Tb_Curso { get; set; }
        public virtual TB_local TB_local { get; set; }
        public virtual TB_Profesor TB_Profesor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Matricula> TB_Matricula { get; set; }
    }
}
