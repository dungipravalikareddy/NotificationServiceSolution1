﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeService.Models
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employment", Namespace="http://schemas.datacontract.org/2004/07/EmployeeService.Models")]
    public partial class Employment : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid IdField;
        
        private string NameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Schema", Namespace="http://schemas.datacontract.org/2004/07/EmployeeService.Models")]
    public partial class Schema : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Guid employmentIdField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid employmentId
        {
            get
            {
                return this.employmentIdField;
            }
            set
            {
                this.employmentIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/EmployeeService.Models")]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DisplayNameField;
        
        private string EmailIdField;
        
        private System.Guid EmploymentIdField;
        
        private System.Guid IdField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DisplayName
        {
            get
            {
                return this.DisplayNameField;
            }
            set
            {
                this.DisplayNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailId
        {
            get
            {
                return this.EmailIdField;
            }
            set
            {
                this.EmailIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid EmploymentId
        {
            get
            {
                return this.EmploymentIdField;
            }
            set
            {
                this.EmploymentIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IService1")]
public interface IService1
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmploymentTypes", ReplyAction="http://tempuri.org/IService1/GetEmploymentTypesResponse")]
    EmployeeService.Models.Employment[] GetEmploymentTypes();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEmploymentTypes", ReplyAction="http://tempuri.org/IService1/GetEmploymentTypesResponse")]
    System.Threading.Tasks.Task<EmployeeService.Models.Employment[]> GetEmploymentTypesAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUsersByEmploymentType", ReplyAction="http://tempuri.org/IService1/GetUsersByEmploymentTypeResponse")]
    EmployeeService.Models.User[] GetUsersByEmploymentType(EmployeeService.Models.Schema payload);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUsersByEmploymentType", ReplyAction="http://tempuri.org/IService1/GetUsersByEmploymentTypeResponse")]
    System.Threading.Tasks.Task<EmployeeService.Models.User[]> GetUsersByEmploymentTypeAsync(EmployeeService.Models.Schema payload);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IService1Channel : IService1, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class Service1Client : System.ServiceModel.ClientBase<IService1>, IService1
{
    
    public Service1Client()
    {
    }
    
    public Service1Client(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public Service1Client(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public EmployeeService.Models.Employment[] GetEmploymentTypes()
    {
        return base.Channel.GetEmploymentTypes();
    }
    
    public System.Threading.Tasks.Task<EmployeeService.Models.Employment[]> GetEmploymentTypesAsync()
    {
        return base.Channel.GetEmploymentTypesAsync();
    }
    
    public EmployeeService.Models.User[] GetUsersByEmploymentType(EmployeeService.Models.Schema payload)
    {
        return base.Channel.GetUsersByEmploymentType(payload);
    }
    
    public System.Threading.Tasks.Task<EmployeeService.Models.User[]> GetUsersByEmploymentTypeAsync(EmployeeService.Models.Schema payload)
    {
        return base.Channel.GetUsersByEmploymentTypeAsync(payload);
    }
}