using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCG_Institutec
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IIServiceConsultaAlumno" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IIServiceConsultaAlumno
    {
        [OperationContract]
        void DoWork();
    }
}
