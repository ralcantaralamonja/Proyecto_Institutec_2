using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCG_Institutec
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioAlumno" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioAlumno
    {
        [OperationContract]
        Boolean InsertarAlumno(AlumnoDC objAlumnoDC);

        [OperationContract]
        Boolean ActualizarAlumno(AlumnoDC objAlumnoDC);

        [OperationContract]
        Boolean EliminarAlumno(String strCodigo);


        [OperationContract]
        AlumnoDC ConsultarAlumno(String strCodigo);
        
        [OperationContract]
        List<AlumnoDC> ListarAlumno();



        //Adicionales...


    }

    [DataContract]
    [Serializable]
    public class AlumnoDC 
    {
        [DataMember]
        public String IdAlum { get; set; }

        [DataMember]
        public String Ndocum { get; set; }

        [DataMember]
        public String NomAlu { get; set; }

        [DataMember]
        public String ApePat { get; set; }

        [DataMember]
        public String ApeMat { get; set; }

        [DataMember]
        public String Id_Ubi { get; set; }

        [DataMember]
        public String Sexoal { get; set; }

        [DataMember]
        public DateTime FecNac { get; set; }

        [DataMember]
        public String CorAlu { get; set; }

        [DataMember]
        public String TelAlu { get; set; }

        [DataMember]
        public String Usu_Registro { get; set; }

        [DataMember]
        public bool Estado { get; set; }

        [DataMember]
        public String CodCar { get; set; }

        [DataMember]
        public byte[] Foto { get; set; }

        [DataMember]
        public String direccion { get; set; }









        //[DataMember]
        //public String DescCar { get; set; }
        
        [DataMember]
        public DateTime Fec_Registro { get; set; }

        [DataMember]
        public DateTime Fec_Ult_Mod { get; set; }

        //[DataMember]
        //public String Usu_Ult_Mod { get; set; }

        //[DataMember]
        //public String departamento { get; set; }

        //[DataMember]
        //public String distrito { get; set; }

        //[DataMember]
        //public String IdFacu { get; set; }

        //[DataMember]
        //public String DescFacu { get; set; }
    }
}
