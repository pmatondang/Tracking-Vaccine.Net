﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RSTrackingVaccine.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="akun", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLogin")]
    [System.SerializableAttribute()]
    public partial class akun : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string roleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usernameField;
        
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
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string role {
            get {
                return this.roleField;
            }
            set {
                if ((object.ReferenceEquals(this.roleField, value) != true)) {
                    this.roleField = value;
                    this.RaisePropertyChanged("role");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string username {
            get {
                return this.usernameField;
            }
            set {
                if ((object.ReferenceEquals(this.usernameField, value) != true)) {
                    this.usernameField = value;
                    this.RaisePropertyChanged("username");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Pendaftaran", ReplyAction="http://tempuri.org/IService1/PendaftaranResponse")]
        RSTrackingVaccine.ServiceReference2.akun Pendaftaran(RSTrackingVaccine.ServiceReference2.akun data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Pendaftaran", ReplyAction="http://tempuri.org/IService1/PendaftaranResponse")]
        System.Threading.Tasks.Task<RSTrackingVaccine.ServiceReference2.akun> PendaftaranAsync(RSTrackingVaccine.ServiceReference2.akun data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        bool Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAccount", ReplyAction="http://tempuri.org/IService1/GetAccountResponse")]
        RSTrackingVaccine.ServiceReference2.akun GetAccount(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAccount", ReplyAction="http://tempuri.org/IService1/GetAccountResponse")]
        System.Threading.Tasks.Task<RSTrackingVaccine.ServiceReference2.akun> GetAccountAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : RSTrackingVaccine.ServiceReference2.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<RSTrackingVaccine.ServiceReference2.IService1>, RSTrackingVaccine.ServiceReference2.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public RSTrackingVaccine.ServiceReference2.akun Pendaftaran(RSTrackingVaccine.ServiceReference2.akun data) {
            return base.Channel.Pendaftaran(data);
        }
        
        public System.Threading.Tasks.Task<RSTrackingVaccine.ServiceReference2.akun> PendaftaranAsync(RSTrackingVaccine.ServiceReference2.akun data) {
            return base.Channel.PendaftaranAsync(data);
        }
        
        public bool Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public RSTrackingVaccine.ServiceReference2.akun GetAccount(string username) {
            return base.Channel.GetAccount(username);
        }
        
        public System.Threading.Tasks.Task<RSTrackingVaccine.ServiceReference2.akun> GetAccountAsync(string username) {
            return base.Channel.GetAccountAsync(username);
        }
    }
}