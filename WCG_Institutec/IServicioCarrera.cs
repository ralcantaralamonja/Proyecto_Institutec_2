using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCG_Institutec
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioCarrera" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioCarrera
    {
        [OperationContract]
        Boolean InsertarCarrera(CarreraDC objCarreraDC);

        [OperationContract]
        Boolean ActualizarCarrera(CarreraDC objCarreraDC);

        [OperationContract]
        Boolean EliminarCarrera(String strCodigo);


        [OperationContract]
        CarreraDC ConsultarCarrera(String strCodigo);

        [OperationContract]
        List<CarreraDC> ListarCarrera();



        //Adicionales

        [OperationContract]
        List<CarreraDC> ListarFacultad();
    }

    [DataContract]
    [Serializable]
    public class CarreraDC
    {
        [DataMember]
        public String CodCar { get; set; }

        [DataMember]
        public String IdFacu { get; set; }

        [DataMember]
        public String DesFac { get; set; }

        [DataMember]
        public String DesCar { get; set; }

        [DataMember]
        public DateTime Fec_Registro { get; set; }

        [DataMember]
        public String Usu_Registro { get; set; }

        [DataMember]
        public DateTime Fec_Ult_Mod { get; set; }

        [DataMember]
        public String Usu_Ult_Mod { get; set; }

        [DataMember]
        public Int16 Est_carr { get; set; }

        [DataMember]
        public String Est_carr_String { get; set; }
    }
}
