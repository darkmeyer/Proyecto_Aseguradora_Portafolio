﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Seguro.Web.ServicioSeguro {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioSeguro.IServicioSeguro")]
    public interface IServicioSeguro {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioSeguro/leerCliente", ReplyAction="http://tempuri.org/IServicioSeguro/leerClienteResponse")]
        string leerCliente(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioSeguro/leerCliente", ReplyAction="http://tempuri.org/IServicioSeguro/leerClienteResponse")]
        System.Threading.Tasks.Task<string> leerClienteAsync(string xml);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioSeguroChannel : Seguro.Web.ServicioSeguro.IServicioSeguro, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioSeguroClient : System.ServiceModel.ClientBase<Seguro.Web.ServicioSeguro.IServicioSeguro>, Seguro.Web.ServicioSeguro.IServicioSeguro {
        
        public ServicioSeguroClient() {
        }
        
        public ServicioSeguroClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioSeguroClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioSeguroClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioSeguroClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string leerCliente(string xml) {
            return base.Channel.leerCliente(xml);
        }
        
        public System.Threading.Tasks.Task<string> leerClienteAsync(string xml) {
            return base.Channel.leerClienteAsync(xml);
        }
    }
}
