﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProxySeccion
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SeccionDC", Namespace="http://schemas.datacontract.org/2004/07/WCG_Institutec")]
    public partial class SeccionDC : object
    {
        
        private short ActivoField;
        
        private short ActivoCursoField;
        
        private string EstadoField;
        
        private System.DateTime Fec_RegistroField;
        
        private System.DateTime Fec_Ult_ModField;
        
        private System.TimeSpan HoraFinField;
        
        private System.TimeSpan HoraIniField;
        
        private string IdCentField;
        
        private string IdCodsField;
        
        private string IdCursField;
        
        private string IdProfField;
        
        private string NomCurField;
        
        private string Usu_RegistroField;
        
        private string Usu_Ult_ModField;
        
        private short VacanteField;
        
        private string diaField;
        
        private string nomLocalField;
        
        private string nomProfesorField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Activo
        {
            get
            {
                return this.ActivoField;
            }
            set
            {
                this.ActivoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short ActivoCurso
        {
            get
            {
                return this.ActivoCursoField;
            }
            set
            {
                this.ActivoCursoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado
        {
            get
            {
                return this.EstadoField;
            }
            set
            {
                this.EstadoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fec_Registro
        {
            get
            {
                return this.Fec_RegistroField;
            }
            set
            {
                this.Fec_RegistroField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fec_Ult_Mod
        {
            get
            {
                return this.Fec_Ult_ModField;
            }
            set
            {
                this.Fec_Ult_ModField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan HoraFin
        {
            get
            {
                return this.HoraFinField;
            }
            set
            {
                this.HoraFinField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan HoraIni
        {
            get
            {
                return this.HoraIniField;
            }
            set
            {
                this.HoraIniField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdCent
        {
            get
            {
                return this.IdCentField;
            }
            set
            {
                this.IdCentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdCods
        {
            get
            {
                return this.IdCodsField;
            }
            set
            {
                this.IdCodsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdCurs
        {
            get
            {
                return this.IdCursField;
            }
            set
            {
                this.IdCursField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdProf
        {
            get
            {
                return this.IdProfField;
            }
            set
            {
                this.IdProfField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomCur
        {
            get
            {
                return this.NomCurField;
            }
            set
            {
                this.NomCurField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Usu_Registro
        {
            get
            {
                return this.Usu_RegistroField;
            }
            set
            {
                this.Usu_RegistroField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Usu_Ult_Mod
        {
            get
            {
                return this.Usu_Ult_ModField;
            }
            set
            {
                this.Usu_Ult_ModField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Vacante
        {
            get
            {
                return this.VacanteField;
            }
            set
            {
                this.VacanteField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string dia
        {
            get
            {
                return this.diaField;
            }
            set
            {
                this.diaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nomLocal
        {
            get
            {
                return this.nomLocalField;
            }
            set
            {
                this.nomLocalField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nomProfesor
        {
            get
            {
                return this.nomProfesorField;
            }
            set
            {
                this.nomProfesorField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxySeccion.IServicioSeccion")]
    public interface IServicioSeccion
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioSeccion/EliminarSeccion", ReplyAction="http://tempuri.org/IServicioSeccion/EliminarSeccionResponse")]
        bool EliminarSeccion(string strCodigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioSeccion/EliminarSeccion", ReplyAction="http://tempuri.org/IServicioSeccion/EliminarSeccionResponse")]
        System.Threading.Tasks.Task<bool> EliminarSeccionAsync(string strCodigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioSeccion/ConsultarSeccion", ReplyAction="http://tempuri.org/IServicioSeccion/ConsultarSeccionResponse")]
        ProxySeccion.SeccionDC ConsultarSeccion(string strCodigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioSeccion/ConsultarSeccion", ReplyAction="http://tempuri.org/IServicioSeccion/ConsultarSeccionResponse")]
        System.Threading.Tasks.Task<ProxySeccion.SeccionDC> ConsultarSeccionAsync(string strCodigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioSeccion/ListarSeccion", ReplyAction="http://tempuri.org/IServicioSeccion/ListarSeccionResponse")]
        System.Collections.Generic.List<ProxySeccion.SeccionDC> ListarSeccion();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioSeccion/ListarSeccion", ReplyAction="http://tempuri.org/IServicioSeccion/ListarSeccionResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ProxySeccion.SeccionDC>> ListarSeccionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioSeccion/ActualizarSeccion", ReplyAction="http://tempuri.org/IServicioSeccion/ActualizarSeccionResponse")]
        bool ActualizarSeccion(ProxySeccion.SeccionDC objSeccionDC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioSeccion/ActualizarSeccion", ReplyAction="http://tempuri.org/IServicioSeccion/ActualizarSeccionResponse")]
        System.Threading.Tasks.Task<bool> ActualizarSeccionAsync(ProxySeccion.SeccionDC objSeccionDC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioSeccion/InsertarSeccion", ReplyAction="http://tempuri.org/IServicioSeccion/InsertarSeccionResponse")]
        bool InsertarSeccion(ProxySeccion.SeccionDC objSeccionDC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioSeccion/InsertarSeccion", ReplyAction="http://tempuri.org/IServicioSeccion/InsertarSeccionResponse")]
        System.Threading.Tasks.Task<bool> InsertarSeccionAsync(ProxySeccion.SeccionDC objSeccionDC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioSeccion/ListarCursos", ReplyAction="http://tempuri.org/IServicioSeccion/ListarCursosResponse")]
        System.Collections.Generic.List<ProxySeccion.SeccionDC> ListarCursos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioSeccion/ListarCursos", ReplyAction="http://tempuri.org/IServicioSeccion/ListarCursosResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ProxySeccion.SeccionDC>> ListarCursosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioSeccion/ListarProfesores", ReplyAction="http://tempuri.org/IServicioSeccion/ListarProfesoresResponse")]
        System.Collections.Generic.List<ProxySeccion.SeccionDC> ListarProfesores();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioSeccion/ListarProfesores", ReplyAction="http://tempuri.org/IServicioSeccion/ListarProfesoresResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ProxySeccion.SeccionDC>> ListarProfesoresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioSeccion/ListarLocales", ReplyAction="http://tempuri.org/IServicioSeccion/ListarLocalesResponse")]
        System.Collections.Generic.List<ProxySeccion.SeccionDC> ListarLocales();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioSeccion/ListarLocales", ReplyAction="http://tempuri.org/IServicioSeccion/ListarLocalesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ProxySeccion.SeccionDC>> ListarLocalesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IServicioSeccionChannel : ProxySeccion.IServicioSeccion, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class ServicioSeccionClient : System.ServiceModel.ClientBase<ProxySeccion.IServicioSeccion>, ProxySeccion.IServicioSeccion
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServicioSeccionClient() : 
                base(ServicioSeccionClient.GetDefaultBinding(), ServicioSeccionClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IServicioSeccion.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicioSeccionClient(EndpointConfiguration endpointConfiguration) : 
                base(ServicioSeccionClient.GetBindingForEndpoint(endpointConfiguration), ServicioSeccionClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicioSeccionClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServicioSeccionClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicioSeccionClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServicioSeccionClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicioSeccionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public bool EliminarSeccion(string strCodigo)
        {
            return base.Channel.EliminarSeccion(strCodigo);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarSeccionAsync(string strCodigo)
        {
            return base.Channel.EliminarSeccionAsync(strCodigo);
        }
        
        public ProxySeccion.SeccionDC ConsultarSeccion(string strCodigo)
        {
            return base.Channel.ConsultarSeccion(strCodigo);
        }
        
        public System.Threading.Tasks.Task<ProxySeccion.SeccionDC> ConsultarSeccionAsync(string strCodigo)
        {
            return base.Channel.ConsultarSeccionAsync(strCodigo);
        }
        
        public System.Collections.Generic.List<ProxySeccion.SeccionDC> ListarSeccion()
        {
            return base.Channel.ListarSeccion();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ProxySeccion.SeccionDC>> ListarSeccionAsync()
        {
            return base.Channel.ListarSeccionAsync();
        }
        
        public bool ActualizarSeccion(ProxySeccion.SeccionDC objSeccionDC)
        {
            return base.Channel.ActualizarSeccion(objSeccionDC);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarSeccionAsync(ProxySeccion.SeccionDC objSeccionDC)
        {
            return base.Channel.ActualizarSeccionAsync(objSeccionDC);
        }
        
        public bool InsertarSeccion(ProxySeccion.SeccionDC objSeccionDC)
        {
            return base.Channel.InsertarSeccion(objSeccionDC);
        }
        
        public System.Threading.Tasks.Task<bool> InsertarSeccionAsync(ProxySeccion.SeccionDC objSeccionDC)
        {
            return base.Channel.InsertarSeccionAsync(objSeccionDC);
        }
        
        public System.Collections.Generic.List<ProxySeccion.SeccionDC> ListarCursos()
        {
            return base.Channel.ListarCursos();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ProxySeccion.SeccionDC>> ListarCursosAsync()
        {
            return base.Channel.ListarCursosAsync();
        }
        
        public System.Collections.Generic.List<ProxySeccion.SeccionDC> ListarProfesores()
        {
            return base.Channel.ListarProfesores();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ProxySeccion.SeccionDC>> ListarProfesoresAsync()
        {
            return base.Channel.ListarProfesoresAsync();
        }
        
        public System.Collections.Generic.List<ProxySeccion.SeccionDC> ListarLocales()
        {
            return base.Channel.ListarLocales();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ProxySeccion.SeccionDC>> ListarLocalesAsync()
        {
            return base.Channel.ListarLocalesAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServicioSeccion))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServicioSeccion))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Design_Time_Addresses/WCG_Institutec/ServicioSeccion/");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ServicioSeccionClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IServicioSeccion);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ServicioSeccionClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IServicioSeccion);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IServicioSeccion,
        }
    }
}
