using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCG_Institutec
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUbigeo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUbigeo
    {
        [OperationContract]
        List<Departamentos> GetDepartamentos();

        [OperationContract]
        List<Provincias> GetProvincias(String IdDepa);

        [OperationContract]
        List<Distritos> GetDistritos(String IdDepa, String IdProv);

    }
    [DataContract]
    [Serializable]
    public class Departamentos
    {
        [DataMember]
        public String IdDepartamento { get; set; }

        [DataMember]
        public String nomDepartamento { get; set; }
    }

    [DataContract]
    [Serializable]
    public class Provincias
    {
        [DataMember]
        public String IdProvincia { get; set; }

        [DataMember]
        public String nomProvincia { get; set; }
    }

    [DataContract]
    [Serializable]
    public class Distritos
    {
        [DataMember]
        public String IdDistrito { get; set; }

        [DataMember]
        public String nomDistrito { get; set; }
    }
}
