﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntegracjaSystemowProjekt_Client.WCFServiceST {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LaptopsResponse", Namespace="http://schemas.datacontract.org/2004/07/ISP.WCF.Models")]
    [System.SerializableAttribute()]
    public partial class LaptopsResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IntegracjaSystemowProjekt_Client.WCFServiceST.Laptop[] LaptopsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IntegracjaSystemowProjekt_Client.WCFServiceST.ResponseState StateField;
        
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
        public IntegracjaSystemowProjekt_Client.WCFServiceST.Laptop[] Laptops {
            get {
                return this.LaptopsField;
            }
            set {
                if ((object.ReferenceEquals(this.LaptopsField, value) != true)) {
                    this.LaptopsField = value;
                    this.RaisePropertyChanged("Laptops");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public IntegracjaSystemowProjekt_Client.WCFServiceST.ResponseState State {
            get {
                return this.StateField;
            }
            set {
                if ((this.StateField.Equals(value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Laptop", Namespace="http://schemas.datacontract.org/2004/07/ISP.WCF.Models")]
    [System.SerializableAttribute()]
    public partial class Laptop : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DiskSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DiskTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DriveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> FrequencyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GpuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsTouchableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ManufacturerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> NumberOfPhysicalCoresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProcessorNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RamField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResolutionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ScreenDiagonalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ScreenSurfaceTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VramField;
        
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
        public string DiskSize {
            get {
                return this.DiskSizeField;
            }
            set {
                if ((object.ReferenceEquals(this.DiskSizeField, value) != true)) {
                    this.DiskSizeField = value;
                    this.RaisePropertyChanged("DiskSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DiskType {
            get {
                return this.DiskTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.DiskTypeField, value) != true)) {
                    this.DiskTypeField = value;
                    this.RaisePropertyChanged("DiskType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Drive {
            get {
                return this.DriveField;
            }
            set {
                if ((object.ReferenceEquals(this.DriveField, value) != true)) {
                    this.DriveField = value;
                    this.RaisePropertyChanged("Drive");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Frequency {
            get {
                return this.FrequencyField;
            }
            set {
                if ((this.FrequencyField.Equals(value) != true)) {
                    this.FrequencyField = value;
                    this.RaisePropertyChanged("Frequency");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Gpu {
            get {
                return this.GpuField;
            }
            set {
                if ((object.ReferenceEquals(this.GpuField, value) != true)) {
                    this.GpuField = value;
                    this.RaisePropertyChanged("Gpu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
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
        public bool IsTouchable {
            get {
                return this.IsTouchableField;
            }
            set {
                if ((this.IsTouchableField.Equals(value) != true)) {
                    this.IsTouchableField = value;
                    this.RaisePropertyChanged("IsTouchable");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ManufacturerName {
            get {
                return this.ManufacturerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ManufacturerNameField, value) != true)) {
                    this.ManufacturerNameField = value;
                    this.RaisePropertyChanged("ManufacturerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> NumberOfPhysicalCores {
            get {
                return this.NumberOfPhysicalCoresField;
            }
            set {
                if ((this.NumberOfPhysicalCoresField.Equals(value) != true)) {
                    this.NumberOfPhysicalCoresField = value;
                    this.RaisePropertyChanged("NumberOfPhysicalCores");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Os {
            get {
                return this.OsField;
            }
            set {
                if ((object.ReferenceEquals(this.OsField, value) != true)) {
                    this.OsField = value;
                    this.RaisePropertyChanged("Os");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProcessorName {
            get {
                return this.ProcessorNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProcessorNameField, value) != true)) {
                    this.ProcessorNameField = value;
                    this.RaisePropertyChanged("ProcessorName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ram {
            get {
                return this.RamField;
            }
            set {
                if ((object.ReferenceEquals(this.RamField, value) != true)) {
                    this.RamField = value;
                    this.RaisePropertyChanged("Ram");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Resolution {
            get {
                return this.ResolutionField;
            }
            set {
                if ((object.ReferenceEquals(this.ResolutionField, value) != true)) {
                    this.ResolutionField = value;
                    this.RaisePropertyChanged("Resolution");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ScreenDiagonal {
            get {
                return this.ScreenDiagonalField;
            }
            set {
                if ((object.ReferenceEquals(this.ScreenDiagonalField, value) != true)) {
                    this.ScreenDiagonalField = value;
                    this.RaisePropertyChanged("ScreenDiagonal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ScreenSurfaceType {
            get {
                return this.ScreenSurfaceTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ScreenSurfaceTypeField, value) != true)) {
                    this.ScreenSurfaceTypeField = value;
                    this.RaisePropertyChanged("ScreenSurfaceType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Vram {
            get {
                return this.VramField;
            }
            set {
                if ((object.ReferenceEquals(this.VramField, value) != true)) {
                    this.VramField = value;
                    this.RaisePropertyChanged("Vram");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ResponseState", Namespace="http://schemas.datacontract.org/2004/07/ISP.WCF.Models")]
    public enum ResponseState : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        OK = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NotFound = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFServiceST.ILaptopService")]
    public interface ILaptopService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILaptopService/GetLaptopCountByManufacturer", ReplyAction="http://tempuri.org/ILaptopService/GetLaptopCountByManufacturerResponse")]
        int GetLaptopCountByManufacturer(string manufacturerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILaptopService/GetLaptopCountByManufacturer", ReplyAction="http://tempuri.org/ILaptopService/GetLaptopCountByManufacturerResponse")]
        System.Threading.Tasks.Task<int> GetLaptopCountByManufacturerAsync(string manufacturerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILaptopService/GetLaptopCountByScreenAspectRatio", ReplyAction="http://tempuri.org/ILaptopService/GetLaptopCountByScreenAspectRatioResponse")]
        int GetLaptopCountByScreenAspectRatio(string aspectRatio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILaptopService/GetLaptopCountByScreenAspectRatio", ReplyAction="http://tempuri.org/ILaptopService/GetLaptopCountByScreenAspectRatioResponse")]
        System.Threading.Tasks.Task<int> GetLaptopCountByScreenAspectRatioAsync(string aspectRatio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILaptopService/GetListOfScreenAspectRatios", ReplyAction="http://tempuri.org/ILaptopService/GetListOfScreenAspectRatiosResponse")]
        string[] GetListOfScreenAspectRatios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILaptopService/GetListOfScreenAspectRatios", ReplyAction="http://tempuri.org/ILaptopService/GetListOfScreenAspectRatiosResponse")]
        System.Threading.Tasks.Task<string[]> GetListOfScreenAspectRatiosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILaptopService/GetListOfScreenSurfaceTypes", ReplyAction="http://tempuri.org/ILaptopService/GetListOfScreenSurfaceTypesResponse")]
        string[] GetListOfScreenSurfaceTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILaptopService/GetListOfScreenSurfaceTypes", ReplyAction="http://tempuri.org/ILaptopService/GetListOfScreenSurfaceTypesResponse")]
        System.Threading.Tasks.Task<string[]> GetListOfScreenSurfaceTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILaptopService/GetListOfManufacturerNames", ReplyAction="http://tempuri.org/ILaptopService/GetListOfManufacturerNamesResponse")]
        string[] GetListOfManufacturerNames();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILaptopService/GetListOfManufacturerNames", ReplyAction="http://tempuri.org/ILaptopService/GetListOfManufacturerNamesResponse")]
        System.Threading.Tasks.Task<string[]> GetListOfManufacturerNamesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILaptopService/GetLaptopsByScreenType", ReplyAction="http://tempuri.org/ILaptopService/GetLaptopsByScreenTypeResponse")]
        IntegracjaSystemowProjekt_Client.WCFServiceST.LaptopsResponse GetLaptopsByScreenType(string screenType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILaptopService/GetLaptopsByScreenType", ReplyAction="http://tempuri.org/ILaptopService/GetLaptopsByScreenTypeResponse")]
        System.Threading.Tasks.Task<IntegracjaSystemowProjekt_Client.WCFServiceST.LaptopsResponse> GetLaptopsByScreenTypeAsync(string screenType);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILaptopServiceChannel : IntegracjaSystemowProjekt_Client.WCFServiceST.ILaptopService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LaptopServiceClient : System.ServiceModel.ClientBase<IntegracjaSystemowProjekt_Client.WCFServiceST.ILaptopService>, IntegracjaSystemowProjekt_Client.WCFServiceST.ILaptopService {
        
        public LaptopServiceClient() {
        }
        
        public LaptopServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LaptopServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LaptopServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LaptopServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetLaptopCountByManufacturer(string manufacturerName) {
            return base.Channel.GetLaptopCountByManufacturer(manufacturerName);
        }
        
        public System.Threading.Tasks.Task<int> GetLaptopCountByManufacturerAsync(string manufacturerName) {
            return base.Channel.GetLaptopCountByManufacturerAsync(manufacturerName);
        }
        
        public int GetLaptopCountByScreenAspectRatio(string aspectRatio) {
            return base.Channel.GetLaptopCountByScreenAspectRatio(aspectRatio);
        }
        
        public System.Threading.Tasks.Task<int> GetLaptopCountByScreenAspectRatioAsync(string aspectRatio) {
            return base.Channel.GetLaptopCountByScreenAspectRatioAsync(aspectRatio);
        }
        
        public string[] GetListOfScreenAspectRatios() {
            return base.Channel.GetListOfScreenAspectRatios();
        }
        
        public System.Threading.Tasks.Task<string[]> GetListOfScreenAspectRatiosAsync() {
            return base.Channel.GetListOfScreenAspectRatiosAsync();
        }
        
        public string[] GetListOfScreenSurfaceTypes() {
            return base.Channel.GetListOfScreenSurfaceTypes();
        }
        
        public System.Threading.Tasks.Task<string[]> GetListOfScreenSurfaceTypesAsync() {
            return base.Channel.GetListOfScreenSurfaceTypesAsync();
        }
        
        public string[] GetListOfManufacturerNames() {
            return base.Channel.GetListOfManufacturerNames();
        }
        
        public System.Threading.Tasks.Task<string[]> GetListOfManufacturerNamesAsync() {
            return base.Channel.GetListOfManufacturerNamesAsync();
        }
        
        public IntegracjaSystemowProjekt_Client.WCFServiceST.LaptopsResponse GetLaptopsByScreenType(string screenType) {
            return base.Channel.GetLaptopsByScreenType(screenType);
        }
        
        public System.Threading.Tasks.Task<IntegracjaSystemowProjekt_Client.WCFServiceST.LaptopsResponse> GetLaptopsByScreenTypeAsync(string screenType) {
            return base.Channel.GetLaptopsByScreenTypeAsync(screenType);
        }
    }
}
