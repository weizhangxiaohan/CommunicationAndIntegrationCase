﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HQOrderEntryImplementation.HQProductServiceASMXClient {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HQProductServiceASMXClient.ProductServiceSoap")]
    public interface ProductServiceSoap {
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 ProductID 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsProductAvailableForCountry", ReplyAction="*")]
        HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryResponse IsProductAvailableForCountry(HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsProductAvailableForCountry", ReplyAction="*")]
        System.Threading.Tasks.Task<HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryResponse> IsProductAvailableForCountryAsync(HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class IsProductAvailableForCountryRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IsProductAvailableForCountry", Namespace="http://tempuri.org/", Order=0)]
        public HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequestBody Body;
        
        public IsProductAvailableForCountryRequest() {
        }
        
        public IsProductAvailableForCountryRequest(HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class IsProductAvailableForCountryRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ProductID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string countryCode;
        
        public IsProductAvailableForCountryRequestBody() {
        }
        
        public IsProductAvailableForCountryRequestBody(string ProductID, string countryCode) {
            this.ProductID = ProductID;
            this.countryCode = countryCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class IsProductAvailableForCountryResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IsProductAvailableForCountryResponse", Namespace="http://tempuri.org/", Order=0)]
        public HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryResponseBody Body;
        
        public IsProductAvailableForCountryResponse() {
        }
        
        public IsProductAvailableForCountryResponse(HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class IsProductAvailableForCountryResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool IsProductAvailableForCountryResult;
        
        public IsProductAvailableForCountryResponseBody() {
        }
        
        public IsProductAvailableForCountryResponseBody(bool IsProductAvailableForCountryResult) {
            this.IsProductAvailableForCountryResult = IsProductAvailableForCountryResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProductServiceSoapChannel : HQOrderEntryImplementation.HQProductServiceASMXClient.ProductServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductServiceSoapClient : System.ServiceModel.ClientBase<HQOrderEntryImplementation.HQProductServiceASMXClient.ProductServiceSoap>, HQOrderEntryImplementation.HQProductServiceASMXClient.ProductServiceSoap {
        
        public ProductServiceSoapClient() {
        }
        
        public ProductServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryResponse HQOrderEntryImplementation.HQProductServiceASMXClient.ProductServiceSoap.IsProductAvailableForCountry(HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequest request) {
            return base.Channel.IsProductAvailableForCountry(request);
        }
        
        public bool IsProductAvailableForCountry(string ProductID, string countryCode) {
            HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequest inValue = new HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequest();
            inValue.Body = new HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequestBody();
            inValue.Body.ProductID = ProductID;
            inValue.Body.countryCode = countryCode;
            HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryResponse retVal = ((HQOrderEntryImplementation.HQProductServiceASMXClient.ProductServiceSoap)(this)).IsProductAvailableForCountry(inValue);
            return retVal.Body.IsProductAvailableForCountryResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryResponse> HQOrderEntryImplementation.HQProductServiceASMXClient.ProductServiceSoap.IsProductAvailableForCountryAsync(HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequest request) {
            return base.Channel.IsProductAvailableForCountryAsync(request);
        }
        
        public System.Threading.Tasks.Task<HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryResponse> IsProductAvailableForCountryAsync(string ProductID, string countryCode) {
            HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequest inValue = new HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequest();
            inValue.Body = new HQOrderEntryImplementation.HQProductServiceASMXClient.IsProductAvailableForCountryRequestBody();
            inValue.Body.ProductID = ProductID;
            inValue.Body.countryCode = countryCode;
            return ((HQOrderEntryImplementation.HQProductServiceASMXClient.ProductServiceSoap)(this)).IsProductAvailableForCountryAsync(inValue);
        }
    }
}
