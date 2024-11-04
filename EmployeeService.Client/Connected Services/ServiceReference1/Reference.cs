﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeService.Client.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employment", Namespace="http://schemas.datacontract.org/2004/07/EmployeeService.Models")]
    [System.SerializableAttribute()]
    public partial class Employment : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/EmployeeService.Models")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DisplayNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid EmploymentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
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
        public string DisplayName {
            get {
                return this.DisplayNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DisplayNameField, value) != true)) {
                    this.DisplayNameField = value;
                    this.RaisePropertyChanged("DisplayName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailId {
            get {
                return this.EmailIdField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailIdField, value) != true)) {
                    this.EmailIdField = value;
                    this.RaisePropertyChanged("EmailId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid EmploymentId {
            get {
                return this.EmploymentIdField;
            }
            set {
                if ((this.EmploymentIdField.Equals(value) != true)) {
                    this.EmploymentIdField = value;
                    this.RaisePropertyChanged("EmploymentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmploymentTypes", ReplyAction="http://tempuri.org/IService1/GetEmploymentTypesResponse")]
        EmployeeService.Client.ServiceReference1.Employment[] GetEmploymentTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmploymentTypes", ReplyAction="http://tempuri.org/IService1/GetEmploymentTypesResponse")]
        System.Threading.Tasks.Task<EmployeeService.Client.ServiceReference1.Employment[]> GetEmploymentTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUsersByEmploymentType", ReplyAction="http://tempuri.org/IService1/GetUsersByEmploymentTypeResponse")]
        EmployeeService.Client.ServiceReference1.User[] GetUsersByEmploymentType(System.Guid employmentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUsersByEmploymentType", ReplyAction="http://tempuri.org/IService1/GetUsersByEmploymentTypeResponse")]
        System.Threading.Tasks.Task<EmployeeService.Client.ServiceReference1.User[]> GetUsersByEmploymentTypeAsync(System.Guid employmentId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : EmployeeService.Client.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<EmployeeService.Client.ServiceReference1.IService1>, EmployeeService.Client.ServiceReference1.IService1 {
        
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
        
        public EmployeeService.Client.ServiceReference1.Employment[] GetEmploymentTypes() {
            return base.Channel.GetEmploymentTypes();
        }
        
        public System.Threading.Tasks.Task<EmployeeService.Client.ServiceReference1.Employment[]> GetEmploymentTypesAsync() {
            return base.Channel.GetEmploymentTypesAsync();
        }
        
        public EmployeeService.Client.ServiceReference1.User[] GetUsersByEmploymentType(System.Guid employmentId) {
            return base.Channel.GetUsersByEmploymentType(employmentId);
        }
        
        public System.Threading.Tasks.Task<EmployeeService.Client.ServiceReference1.User[]> GetUsersByEmploymentTypeAsync(System.Guid employmentId) {
            return base.Channel.GetUsersByEmploymentTypeAsync(employmentId);
        }
    }
}