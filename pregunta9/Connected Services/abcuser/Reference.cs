﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pregunta9.abcuser {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="abcuser.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/usuarios", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet usuarios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/usuarios", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> usuariosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ModificarUsuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void ModificarUsuario(int id, string nombre, string tipoUs, string ci, System.DateTime fecha, int telefono, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ModificarUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task ModificarUsuarioAsync(int id, string nombre, string tipoUs, string ci, System.DateTime fecha, int telefono, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarUsuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void EliminarUsuario(int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task EliminarUsuarioAsync(int idUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarUsuario", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void AgregarUsuario(string nombre, string tipoUs, string ci, System.DateTime fecha, int telefono, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarUsuario", ReplyAction="*")]
        System.Threading.Tasks.Task AgregarUsuarioAsync(string nombre, string tipoUs, string ci, System.DateTime fecha, int telefono, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VerificarUsuarioExiste", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool VerificarUsuarioExiste(string nombre, string ci);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/VerificarUsuarioExiste", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> VerificarUsuarioExisteAsync(string nombre, string ci);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : pregunta9.abcuser.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<pregunta9.abcuser.WebService1Soap>, pregunta9.abcuser.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public System.Data.DataSet usuarios() {
            return base.Channel.usuarios();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> usuariosAsync() {
            return base.Channel.usuariosAsync();
        }
        
        public void ModificarUsuario(int id, string nombre, string tipoUs, string ci, System.DateTime fecha, int telefono, string pwd) {
            base.Channel.ModificarUsuario(id, nombre, tipoUs, ci, fecha, telefono, pwd);
        }
        
        public System.Threading.Tasks.Task ModificarUsuarioAsync(int id, string nombre, string tipoUs, string ci, System.DateTime fecha, int telefono, string pwd) {
            return base.Channel.ModificarUsuarioAsync(id, nombre, tipoUs, ci, fecha, telefono, pwd);
        }
        
        public void EliminarUsuario(int idUsuario) {
            base.Channel.EliminarUsuario(idUsuario);
        }
        
        public System.Threading.Tasks.Task EliminarUsuarioAsync(int idUsuario) {
            return base.Channel.EliminarUsuarioAsync(idUsuario);
        }
        
        public void AgregarUsuario(string nombre, string tipoUs, string ci, System.DateTime fecha, int telefono, string pwd) {
            base.Channel.AgregarUsuario(nombre, tipoUs, ci, fecha, telefono, pwd);
        }
        
        public System.Threading.Tasks.Task AgregarUsuarioAsync(string nombre, string tipoUs, string ci, System.DateTime fecha, int telefono, string pwd) {
            return base.Channel.AgregarUsuarioAsync(nombre, tipoUs, ci, fecha, telefono, pwd);
        }
        
        public bool VerificarUsuarioExiste(string nombre, string ci) {
            return base.Channel.VerificarUsuarioExiste(nombre, ci);
        }
        
        public System.Threading.Tasks.Task<bool> VerificarUsuarioExisteAsync(string nombre, string ci) {
            return base.Channel.VerificarUsuarioExisteAsync(nombre, ci);
        }
    }
}
