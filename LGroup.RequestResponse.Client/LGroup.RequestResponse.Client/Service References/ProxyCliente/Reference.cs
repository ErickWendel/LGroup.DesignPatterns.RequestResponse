﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LGroup.RequestResponse.Client.ProxyCliente {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RequestClienteDTO", Namespace="http://schemas.datacontract.org/2004/07/LGroup.RequestResponse.DataTransferObject" +
        ".Delivery")]
    [System.SerializableAttribute()]
    public partial class RequestClienteDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LGroup.RequestResponse.Client.ProxyCliente.ClienteDTO ClienteField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LGroup.RequestResponse.Client.ProxyCliente.ClienteDTO Cliente {
            get {
                return this.ClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.ClienteField, value) != true)) {
                    this.ClienteField = value;
                    this.RaisePropertyChanged("Cliente");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ClienteDTO", Namespace="http://schemas.datacontract.org/2004/07/LGroup.RequestResponse.DataTransferObject" +
        "")]
    [System.SerializableAttribute()]
    public partial class ClienteDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefoneField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefone {
            get {
                return this.TelefoneField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefoneField, value) != true)) {
                    this.TelefoneField = value;
                    this.RaisePropertyChanged("Telefone");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseClienteDTO", Namespace="http://schemas.datacontract.org/2004/07/LGroup.RequestResponse.DataTransferObject" +
        ".Delivery")]
    [System.SerializableAttribute()]
    public partial class ResponseClienteDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LGroup.RequestResponse.Client.ProxyCliente.ClienteDTO[] ClientesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataExecucaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensagemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan TempoExecucaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LGroup.RequestResponse.Client.ProxyCliente.TipoResposta TipoMensagemField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LGroup.RequestResponse.Client.ProxyCliente.ClienteDTO[] Clientes {
            get {
                return this.ClientesField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientesField, value) != true)) {
                    this.ClientesField = value;
                    this.RaisePropertyChanged("Clientes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataExecucao {
            get {
                return this.DataExecucaoField;
            }
            set {
                if ((this.DataExecucaoField.Equals(value) != true)) {
                    this.DataExecucaoField = value;
                    this.RaisePropertyChanged("DataExecucao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensagem {
            get {
                return this.MensagemField;
            }
            set {
                if ((object.ReferenceEquals(this.MensagemField, value) != true)) {
                    this.MensagemField = value;
                    this.RaisePropertyChanged("Mensagem");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan TempoExecucao {
            get {
                return this.TempoExecucaoField;
            }
            set {
                if ((this.TempoExecucaoField.Equals(value) != true)) {
                    this.TempoExecucaoField = value;
                    this.RaisePropertyChanged("TempoExecucao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LGroup.RequestResponse.Client.ProxyCliente.TipoResposta TipoMensagem {
            get {
                return this.TipoMensagemField;
            }
            set {
                if ((this.TipoMensagemField.Equals(value) != true)) {
                    this.TipoMensagemField = value;
                    this.RaisePropertyChanged("TipoMensagem");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TipoResposta", Namespace="http://schemas.datacontract.org/2004/07/LGroup.RequestResonse.ValueObject")]
    public enum TipoResposta : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Aviso = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Erro = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Sucesso = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyCliente.IClienteService")]
    public interface IClienteService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Listar", ReplyAction="http://tempuri.org/IClienteService/ListarResponse")]
        LGroup.RequestResponse.Client.ProxyCliente.ResponseClienteDTO Listar(LGroup.RequestResponse.Client.ProxyCliente.RequestClienteDTO request_);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Listar", ReplyAction="http://tempuri.org/IClienteService/ListarResponse")]
        System.Threading.Tasks.Task<LGroup.RequestResponse.Client.ProxyCliente.ResponseClienteDTO> ListarAsync(LGroup.RequestResponse.Client.ProxyCliente.RequestClienteDTO request_);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Cadastrar", ReplyAction="http://tempuri.org/IClienteService/CadastrarResponse")]
        LGroup.RequestResponse.Client.ProxyCliente.ResponseClienteDTO Cadastrar(LGroup.RequestResponse.Client.ProxyCliente.RequestClienteDTO request_);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IClienteService/Cadastrar", ReplyAction="http://tempuri.org/IClienteService/CadastrarResponse")]
        System.Threading.Tasks.Task<LGroup.RequestResponse.Client.ProxyCliente.ResponseClienteDTO> CadastrarAsync(LGroup.RequestResponse.Client.ProxyCliente.RequestClienteDTO request_);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClienteServiceChannel : LGroup.RequestResponse.Client.ProxyCliente.IClienteService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClienteServiceClient : System.ServiceModel.ClientBase<LGroup.RequestResponse.Client.ProxyCliente.IClienteService>, LGroup.RequestResponse.Client.ProxyCliente.IClienteService {
        
        public ClienteServiceClient() {
        }
        
        public ClienteServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClienteServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LGroup.RequestResponse.Client.ProxyCliente.ResponseClienteDTO Listar(LGroup.RequestResponse.Client.ProxyCliente.RequestClienteDTO request_) {
            return base.Channel.Listar(request_);
        }
        
        public System.Threading.Tasks.Task<LGroup.RequestResponse.Client.ProxyCliente.ResponseClienteDTO> ListarAsync(LGroup.RequestResponse.Client.ProxyCliente.RequestClienteDTO request_) {
            return base.Channel.ListarAsync(request_);
        }
        
        public LGroup.RequestResponse.Client.ProxyCliente.ResponseClienteDTO Cadastrar(LGroup.RequestResponse.Client.ProxyCliente.RequestClienteDTO request_) {
            return base.Channel.Cadastrar(request_);
        }
        
        public System.Threading.Tasks.Task<LGroup.RequestResponse.Client.ProxyCliente.ResponseClienteDTO> CadastrarAsync(LGroup.RequestResponse.Client.ProxyCliente.RequestClienteDTO request_) {
            return base.Channel.CadastrarAsync(request_);
        }
    }
}
