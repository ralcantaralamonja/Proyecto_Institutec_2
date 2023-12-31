﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProxyUsuario
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UsuarioDC", Namespace="http://schemas.datacontract.org/2004/07/WCG_Institutec")]
    public partial class UsuarioDC : object
    {
        
        private short Est_UsuarioField;
        
        private System.DateTime Fec_RegistroField;
        
        private string Login_UsuarioField;
        
        private short Niv_UsuarioField;
        
        private string Pass_UsuarioField;
        
        private string Usu_RegistroField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Est_Usuario
        {
            get
            {
                return this.Est_UsuarioField;
            }
            set
            {
                this.Est_UsuarioField = value;
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
        public string Login_Usuario
        {
            get
            {
                return this.Login_UsuarioField;
            }
            set
            {
                this.Login_UsuarioField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Niv_Usuario
        {
            get
            {
                return this.Niv_UsuarioField;
            }
            set
            {
                this.Niv_UsuarioField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pass_Usuario
        {
            get
            {
                return this.Pass_UsuarioField;
            }
            set
            {
                this.Pass_UsuarioField = value;
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyUsuario.IServicioUsuario")]
    public interface IServicioUsuario
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/ConsultarUsuario", ReplyAction="http://tempuri.org/IServicioUsuario/ConsultarUsuarioResponse")]
        ProxyUsuario.UsuarioDC ConsultarUsuario(string strLogin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioUsuario/ConsultarUsuario", ReplyAction="http://tempuri.org/IServicioUsuario/ConsultarUsuarioResponse")]
        System.Threading.Tasks.Task<ProxyUsuario.UsuarioDC> ConsultarUsuarioAsync(string strLogin);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IServicioUsuarioChannel : ProxyUsuario.IServicioUsuario, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class ServicioUsuarioClient : System.ServiceModel.ClientBase<ProxyUsuario.IServicioUsuario>, ProxyUsuario.IServicioUsuario
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ServicioUsuarioClient() : 
                base(ServicioUsuarioClient.GetDefaultBinding(), ServicioUsuarioClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IServicioUsuario.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicioUsuarioClient(EndpointConfiguration endpointConfiguration) : 
                base(ServicioUsuarioClient.GetBindingForEndpoint(endpointConfiguration), ServicioUsuarioClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicioUsuarioClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ServicioUsuarioClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicioUsuarioClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ServicioUsuarioClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ServicioUsuarioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public ProxyUsuario.UsuarioDC ConsultarUsuario(string strLogin)
        {
            return base.Channel.ConsultarUsuario(strLogin);
        }
        
        public System.Threading.Tasks.Task<ProxyUsuario.UsuarioDC> ConsultarUsuarioAsync(string strLogin)
        {
            return base.Channel.ConsultarUsuarioAsync(strLogin);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServicioUsuario))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServicioUsuario))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Design_Time_Addresses/WCG_Institutec/ServicioUsuario/");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ServicioUsuarioClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IServicioUsuario);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ServicioUsuarioClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IServicioUsuario);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IServicioUsuario,
        }
    }
}
