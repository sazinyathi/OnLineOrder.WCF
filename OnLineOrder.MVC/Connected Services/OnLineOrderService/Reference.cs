﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnLineOrder.MVC.OnLineOrderService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OnLineOrderLoginSesssionResponse", Namespace="http://schemas.datacontract.org/2004/07/OnLineOrderWCF.Models")]
    [System.SerializableAttribute()]
    public partial class OnLineOrderLoginSesssionResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private OnLineOrder.MVC.OnLineOrderService.OnLineOrderError[] ErrorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSucessfulField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OnLineOrderLoginSesssionKeyField;
        
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
        public OnLineOrder.MVC.OnLineOrderService.OnLineOrderError[] Errors {
            get {
                return this.ErrorsField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorsField, value) != true)) {
                    this.ErrorsField = value;
                    this.RaisePropertyChanged("Errors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSucessful {
            get {
                return this.IsSucessfulField;
            }
            set {
                if ((this.IsSucessfulField.Equals(value) != true)) {
                    this.IsSucessfulField = value;
                    this.RaisePropertyChanged("IsSucessful");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OnLineOrderLoginSesssionKey {
            get {
                return this.OnLineOrderLoginSesssionKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.OnLineOrderLoginSesssionKeyField, value) != true)) {
                    this.OnLineOrderLoginSesssionKeyField = value;
                    this.RaisePropertyChanged("OnLineOrderLoginSesssionKey");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="OnLineOrderError", Namespace="http://schemas.datacontract.org/2004/07/OnLineOrderWCF.Models")]
    [System.SerializableAttribute()]
    public partial class OnLineOrderError : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorDescriptionField;
        
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
        public string ErrorCode {
            get {
                return this.ErrorCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorCodeField, value) != true)) {
                    this.ErrorCodeField = value;
                    this.RaisePropertyChanged("ErrorCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorDescription {
            get {
                return this.ErrorDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorDescriptionField, value) != true)) {
                    this.ErrorDescriptionField = value;
                    this.RaisePropertyChanged("ErrorDescription");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="OnLineOrderProductRequest", Namespace="http://schemas.datacontract.org/2004/07/OnLineOrderWCF.Requests")]
    [System.SerializableAttribute()]
    public partial class OnLineOrderProductRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SessionIdField;
        
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
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductDescription {
            get {
                return this.ProductDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductDescriptionField, value) != true)) {
                    this.ProductDescriptionField = value;
                    this.RaisePropertyChanged("ProductDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SessionId {
            get {
                return this.SessionIdField;
            }
            set {
                if ((object.ReferenceEquals(this.SessionIdField, value) != true)) {
                    this.SessionIdField = value;
                    this.RaisePropertyChanged("SessionId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="OnLineOrderCreateProductResponse", Namespace="http://schemas.datacontract.org/2004/07/OnLineOrderWCF")]
    [System.SerializableAttribute()]
    public partial class OnLineOrderCreateProductResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private OnLineOrder.MVC.OnLineOrderService.OnLineOrderError[] ErrorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSucessfulField;
        
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
        public OnLineOrder.MVC.OnLineOrderService.OnLineOrderError[] Errors {
            get {
                return this.ErrorsField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorsField, value) != true)) {
                    this.ErrorsField = value;
                    this.RaisePropertyChanged("Errors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSucessful {
            get {
                return this.IsSucessfulField;
            }
            set {
                if ((this.IsSucessfulField.Equals(value) != true)) {
                    this.IsSucessfulField = value;
                    this.RaisePropertyChanged("IsSucessful");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="OnLineOrderGetAvailableProductsResponse", Namespace="http://schemas.datacontract.org/2004/07/OnLineOrderWCF.Responses")]
    [System.SerializableAttribute()]
    public partial class OnLineOrderGetAvailableProductsResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private OnLineOrder.MVC.OnLineOrderService.OnLineOrderError[] ErrorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private OnLineOrder.MVC.OnLineOrderService.ProductsResponses[] GetAllProductsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private OnLineOrder.MVC.OnLineOrderService.ProductsResponses GetProductField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSucessfulField;
        
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
        public OnLineOrder.MVC.OnLineOrderService.OnLineOrderError[] Errors {
            get {
                return this.ErrorsField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorsField, value) != true)) {
                    this.ErrorsField = value;
                    this.RaisePropertyChanged("Errors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public OnLineOrder.MVC.OnLineOrderService.ProductsResponses[] GetAllProducts {
            get {
                return this.GetAllProductsField;
            }
            set {
                if ((object.ReferenceEquals(this.GetAllProductsField, value) != true)) {
                    this.GetAllProductsField = value;
                    this.RaisePropertyChanged("GetAllProducts");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public OnLineOrder.MVC.OnLineOrderService.ProductsResponses GetProduct {
            get {
                return this.GetProductField;
            }
            set {
                if ((object.ReferenceEquals(this.GetProductField, value) != true)) {
                    this.GetProductField = value;
                    this.RaisePropertyChanged("GetProduct");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSucessful {
            get {
                return this.IsSucessfulField;
            }
            set {
                if ((this.IsSucessfulField.Equals(value) != true)) {
                    this.IsSucessfulField = value;
                    this.RaisePropertyChanged("IsSucessful");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductsResponses", Namespace="http://schemas.datacontract.org/2004/07/OnLineOrderWCF.Responses")]
    [System.SerializableAttribute()]
    public partial class ProductsResponses : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
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
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductDescription {
            get {
                return this.ProductDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductDescriptionField, value) != true)) {
                    this.ProductDescriptionField = value;
                    this.RaisePropertyChanged("ProductDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((this.ProductIdField.Equals(value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="OnLineOrderGetAvailableProductsByProductIdResponse", Namespace="http://schemas.datacontract.org/2004/07/OnLineOrderWCF.Responses")]
    [System.SerializableAttribute()]
    public partial class OnLineOrderGetAvailableProductsByProductIdResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private OnLineOrder.MVC.OnLineOrderService.OnLineOrderError[] ErrorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private OnLineOrder.MVC.OnLineOrderService.ProductsResponses GetProductField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSucessfulField;
        
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
        public OnLineOrder.MVC.OnLineOrderService.OnLineOrderError[] Errors {
            get {
                return this.ErrorsField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorsField, value) != true)) {
                    this.ErrorsField = value;
                    this.RaisePropertyChanged("Errors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public OnLineOrder.MVC.OnLineOrderService.ProductsResponses GetProduct {
            get {
                return this.GetProductField;
            }
            set {
                if ((object.ReferenceEquals(this.GetProductField, value) != true)) {
                    this.GetProductField = value;
                    this.RaisePropertyChanged("GetProduct");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSucessful {
            get {
                return this.IsSucessfulField;
            }
            set {
                if ((this.IsSucessfulField.Equals(value) != true)) {
                    this.IsSucessfulField = value;
                    this.RaisePropertyChanged("IsSucessful");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OnLineOrderService.IOnLineOrder")]
    public interface IOnLineOrder {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnLineOrder/CreateLoginSession", ReplyAction="http://tempuri.org/IOnLineOrder/CreateLoginSessionResponse")]
        OnLineOrder.MVC.OnLineOrderService.OnLineOrderLoginSesssionResponse CreateLoginSession(string username, string passsword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnLineOrder/CreateLoginSession", ReplyAction="http://tempuri.org/IOnLineOrder/CreateLoginSessionResponse")]
        System.Threading.Tasks.Task<OnLineOrder.MVC.OnLineOrderService.OnLineOrderLoginSesssionResponse> CreateLoginSessionAsync(string username, string passsword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnLineOrder/CreateProduct", ReplyAction="http://tempuri.org/IOnLineOrder/CreateProductResponse")]
        OnLineOrder.MVC.OnLineOrderService.OnLineOrderCreateProductResponse CreateProduct(OnLineOrder.MVC.OnLineOrderService.OnLineOrderProductRequest onLineOrderRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnLineOrder/CreateProduct", ReplyAction="http://tempuri.org/IOnLineOrder/CreateProductResponse")]
        System.Threading.Tasks.Task<OnLineOrder.MVC.OnLineOrderService.OnLineOrderCreateProductResponse> CreateProductAsync(OnLineOrder.MVC.OnLineOrderService.OnLineOrderProductRequest onLineOrderRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnLineOrder/GetAllAvailableProducts", ReplyAction="http://tempuri.org/IOnLineOrder/GetAllAvailableProductsResponse")]
        OnLineOrder.MVC.OnLineOrderService.OnLineOrderGetAvailableProductsResponse GetAllAvailableProducts(string sessionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnLineOrder/GetAllAvailableProducts", ReplyAction="http://tempuri.org/IOnLineOrder/GetAllAvailableProductsResponse")]
        System.Threading.Tasks.Task<OnLineOrder.MVC.OnLineOrderService.OnLineOrderGetAvailableProductsResponse> GetAllAvailableProductsAsync(string sessionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnLineOrder/GetAvailableProductsByProductId", ReplyAction="http://tempuri.org/IOnLineOrder/GetAvailableProductsByProductIdResponse")]
        OnLineOrder.MVC.OnLineOrderService.OnLineOrderGetAvailableProductsByProductIdResponse GetAvailableProductsByProductId(string sessionId, int productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOnLineOrder/GetAvailableProductsByProductId", ReplyAction="http://tempuri.org/IOnLineOrder/GetAvailableProductsByProductIdResponse")]
        System.Threading.Tasks.Task<OnLineOrder.MVC.OnLineOrderService.OnLineOrderGetAvailableProductsByProductIdResponse> GetAvailableProductsByProductIdAsync(string sessionId, int productId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOnLineOrderChannel : OnLineOrder.MVC.OnLineOrderService.IOnLineOrder, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OnLineOrderClient : System.ServiceModel.ClientBase<OnLineOrder.MVC.OnLineOrderService.IOnLineOrder>, OnLineOrder.MVC.OnLineOrderService.IOnLineOrder {
        
        public OnLineOrderClient() {
        }
        
        public OnLineOrderClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OnLineOrderClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OnLineOrderClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OnLineOrderClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public OnLineOrder.MVC.OnLineOrderService.OnLineOrderLoginSesssionResponse CreateLoginSession(string username, string passsword) {
            return base.Channel.CreateLoginSession(username, passsword);
        }
        
        public System.Threading.Tasks.Task<OnLineOrder.MVC.OnLineOrderService.OnLineOrderLoginSesssionResponse> CreateLoginSessionAsync(string username, string passsword) {
            return base.Channel.CreateLoginSessionAsync(username, passsword);
        }
        
        public OnLineOrder.MVC.OnLineOrderService.OnLineOrderCreateProductResponse CreateProduct(OnLineOrder.MVC.OnLineOrderService.OnLineOrderProductRequest onLineOrderRequest) {
            return base.Channel.CreateProduct(onLineOrderRequest);
        }
        
        public System.Threading.Tasks.Task<OnLineOrder.MVC.OnLineOrderService.OnLineOrderCreateProductResponse> CreateProductAsync(OnLineOrder.MVC.OnLineOrderService.OnLineOrderProductRequest onLineOrderRequest) {
            return base.Channel.CreateProductAsync(onLineOrderRequest);
        }
        
        public OnLineOrder.MVC.OnLineOrderService.OnLineOrderGetAvailableProductsResponse GetAllAvailableProducts(string sessionId) {
            return base.Channel.GetAllAvailableProducts(sessionId);
        }
        
        public System.Threading.Tasks.Task<OnLineOrder.MVC.OnLineOrderService.OnLineOrderGetAvailableProductsResponse> GetAllAvailableProductsAsync(string sessionId) {
            return base.Channel.GetAllAvailableProductsAsync(sessionId);
        }
        
        public OnLineOrder.MVC.OnLineOrderService.OnLineOrderGetAvailableProductsByProductIdResponse GetAvailableProductsByProductId(string sessionId, int productId) {
            return base.Channel.GetAvailableProductsByProductId(sessionId, productId);
        }
        
        public System.Threading.Tasks.Task<OnLineOrder.MVC.OnLineOrderService.OnLineOrderGetAvailableProductsByProductIdResponse> GetAvailableProductsByProductIdAsync(string sessionId, int productId) {
            return base.Channel.GetAvailableProductsByProductIdAsync(sessionId, productId);
        }
    }
}
