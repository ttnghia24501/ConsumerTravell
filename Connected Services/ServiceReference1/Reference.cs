﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumerTravell.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProvinceCity", Namespace="http://schemas.datacontract.org/2004/07/REST_DuLich")]
    [System.SerializableAttribute()]
    public partial class ProvinceCity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaTinhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenTinhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenTpField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsumerTravell.ServiceReference1.Tour[] ToursField;
        
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
        public int MaTinh {
            get {
                return this.MaTinhField;
            }
            set {
                if ((this.MaTinhField.Equals(value) != true)) {
                    this.MaTinhField = value;
                    this.RaisePropertyChanged("MaTinh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenTinh {
            get {
                return this.TenTinhField;
            }
            set {
                if ((object.ReferenceEquals(this.TenTinhField, value) != true)) {
                    this.TenTinhField = value;
                    this.RaisePropertyChanged("TenTinh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenTp {
            get {
                return this.TenTpField;
            }
            set {
                if ((object.ReferenceEquals(this.TenTpField, value) != true)) {
                    this.TenTpField = value;
                    this.RaisePropertyChanged("TenTp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsumerTravell.ServiceReference1.Tour[] Tours {
            get {
                return this.ToursField;
            }
            set {
                if ((object.ReferenceEquals(this.ToursField, value) != true)) {
                    this.ToursField = value;
                    this.RaisePropertyChanged("Tours");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Tour", Namespace="http://schemas.datacontract.org/2004/07/REST_DuLich")]
    [System.SerializableAttribute()]
    public partial class Tour : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DonViTinhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HinhAnhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> KhuyenMaiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> MaTinhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaTourField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> NgayKetThucField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> NgayKhoiHanhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoiDungField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsumerTravell.ServiceReference1.ProvinceCity ProvinceCityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> SoChoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> SoDemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> SoNgayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenTourField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsumerTravell.ServiceReference1.TourBooking[] TourBookingsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> TourHotField;
        
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
        public string DonViTinh {
            get {
                return this.DonViTinhField;
            }
            set {
                if ((object.ReferenceEquals(this.DonViTinhField, value) != true)) {
                    this.DonViTinhField = value;
                    this.RaisePropertyChanged("DonViTinh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HinhAnh {
            get {
                return this.HinhAnhField;
            }
            set {
                if ((object.ReferenceEquals(this.HinhAnhField, value) != true)) {
                    this.HinhAnhField = value;
                    this.RaisePropertyChanged("HinhAnh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> KhuyenMai {
            get {
                return this.KhuyenMaiField;
            }
            set {
                if ((this.KhuyenMaiField.Equals(value) != true)) {
                    this.KhuyenMaiField = value;
                    this.RaisePropertyChanged("KhuyenMai");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> MaTinh {
            get {
                return this.MaTinhField;
            }
            set {
                if ((this.MaTinhField.Equals(value) != true)) {
                    this.MaTinhField = value;
                    this.RaisePropertyChanged("MaTinh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaTour {
            get {
                return this.MaTourField;
            }
            set {
                if ((this.MaTourField.Equals(value) != true)) {
                    this.MaTourField = value;
                    this.RaisePropertyChanged("MaTour");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> NgayKetThuc {
            get {
                return this.NgayKetThucField;
            }
            set {
                if ((this.NgayKetThucField.Equals(value) != true)) {
                    this.NgayKetThucField = value;
                    this.RaisePropertyChanged("NgayKetThuc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> NgayKhoiHanh {
            get {
                return this.NgayKhoiHanhField;
            }
            set {
                if ((this.NgayKhoiHanhField.Equals(value) != true)) {
                    this.NgayKhoiHanhField = value;
                    this.RaisePropertyChanged("NgayKhoiHanh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NoiDung {
            get {
                return this.NoiDungField;
            }
            set {
                if ((object.ReferenceEquals(this.NoiDungField, value) != true)) {
                    this.NoiDungField = value;
                    this.RaisePropertyChanged("NoiDung");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsumerTravell.ServiceReference1.ProvinceCity ProvinceCity {
            get {
                return this.ProvinceCityField;
            }
            set {
                if ((object.ReferenceEquals(this.ProvinceCityField, value) != true)) {
                    this.ProvinceCityField = value;
                    this.RaisePropertyChanged("ProvinceCity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> SoCho {
            get {
                return this.SoChoField;
            }
            set {
                if ((this.SoChoField.Equals(value) != true)) {
                    this.SoChoField = value;
                    this.RaisePropertyChanged("SoCho");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> SoDem {
            get {
                return this.SoDemField;
            }
            set {
                if ((this.SoDemField.Equals(value) != true)) {
                    this.SoDemField = value;
                    this.RaisePropertyChanged("SoDem");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> SoNgay {
            get {
                return this.SoNgayField;
            }
            set {
                if ((this.SoNgayField.Equals(value) != true)) {
                    this.SoNgayField = value;
                    this.RaisePropertyChanged("SoNgay");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenTour {
            get {
                return this.TenTourField;
            }
            set {
                if ((object.ReferenceEquals(this.TenTourField, value) != true)) {
                    this.TenTourField = value;
                    this.RaisePropertyChanged("TenTour");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsumerTravell.ServiceReference1.TourBooking[] TourBookings {
            get {
                return this.TourBookingsField;
            }
            set {
                if ((object.ReferenceEquals(this.TourBookingsField, value) != true)) {
                    this.TourBookingsField = value;
                    this.RaisePropertyChanged("TourBookings");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> TourHot {
            get {
                return this.TourHotField;
            }
            set {
                if ((this.TourHotField.Equals(value) != true)) {
                    this.TourHotField = value;
                    this.RaisePropertyChanged("TourHot");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TourBooking", Namespace="http://schemas.datacontract.org/2004/07/REST_DuLich")]
    [System.SerializableAttribute()]
    public partial class TourBooking : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsumerTravell.ServiceReference1.Customer CustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> DongiaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaDatTourField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> MaKHField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> MaTourField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> SoLuongField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ThanhTienField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsumerTravell.ServiceReference1.Tour TourField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TrangThaiField;
        
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
        public ConsumerTravell.ServiceReference1.Customer Customer {
            get {
                return this.CustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerField, value) != true)) {
                    this.CustomerField = value;
                    this.RaisePropertyChanged("Customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Dongia {
            get {
                return this.DongiaField;
            }
            set {
                if ((this.DongiaField.Equals(value) != true)) {
                    this.DongiaField = value;
                    this.RaisePropertyChanged("Dongia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaDatTour {
            get {
                return this.MaDatTourField;
            }
            set {
                if ((this.MaDatTourField.Equals(value) != true)) {
                    this.MaDatTourField = value;
                    this.RaisePropertyChanged("MaDatTour");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> MaKH {
            get {
                return this.MaKHField;
            }
            set {
                if ((this.MaKHField.Equals(value) != true)) {
                    this.MaKHField = value;
                    this.RaisePropertyChanged("MaKH");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> MaTour {
            get {
                return this.MaTourField;
            }
            set {
                if ((this.MaTourField.Equals(value) != true)) {
                    this.MaTourField = value;
                    this.RaisePropertyChanged("MaTour");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> SoLuong {
            get {
                return this.SoLuongField;
            }
            set {
                if ((this.SoLuongField.Equals(value) != true)) {
                    this.SoLuongField = value;
                    this.RaisePropertyChanged("SoLuong");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ThanhTien {
            get {
                return this.ThanhTienField;
            }
            set {
                if ((this.ThanhTienField.Equals(value) != true)) {
                    this.ThanhTienField = value;
                    this.RaisePropertyChanged("ThanhTien");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsumerTravell.ServiceReference1.Tour Tour {
            get {
                return this.TourField;
            }
            set {
                if ((object.ReferenceEquals(this.TourField, value) != true)) {
                    this.TourField = value;
                    this.RaisePropertyChanged("Tour");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TrangThai {
            get {
                return this.TrangThaiField;
            }
            set {
                if ((object.ReferenceEquals(this.TrangThaiField, value) != true)) {
                    this.TrangThaiField = value;
                    this.RaisePropertyChanged("TrangThai");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/REST_DuLich")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DiachiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> DienthoaiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GioiTinhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaKHField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> NgaySinhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenDangNhapField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenKHField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsumerTravell.ServiceReference1.TourBooking[] TourBookingsField;
        
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
        public string Diachi {
            get {
                return this.DiachiField;
            }
            set {
                if ((object.ReferenceEquals(this.DiachiField, value) != true)) {
                    this.DiachiField = value;
                    this.RaisePropertyChanged("Diachi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Dienthoai {
            get {
                return this.DienthoaiField;
            }
            set {
                if ((this.DienthoaiField.Equals(value) != true)) {
                    this.DienthoaiField = value;
                    this.RaisePropertyChanged("Dienthoai");
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
        public string GioiTinh {
            get {
                return this.GioiTinhField;
            }
            set {
                if ((object.ReferenceEquals(this.GioiTinhField, value) != true)) {
                    this.GioiTinhField = value;
                    this.RaisePropertyChanged("GioiTinh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaKH {
            get {
                return this.MaKHField;
            }
            set {
                if ((this.MaKHField.Equals(value) != true)) {
                    this.MaKHField = value;
                    this.RaisePropertyChanged("MaKH");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> NgaySinh {
            get {
                return this.NgaySinhField;
            }
            set {
                if ((this.NgaySinhField.Equals(value) != true)) {
                    this.NgaySinhField = value;
                    this.RaisePropertyChanged("NgaySinh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenDangNhap {
            get {
                return this.TenDangNhapField;
            }
            set {
                if ((object.ReferenceEquals(this.TenDangNhapField, value) != true)) {
                    this.TenDangNhapField = value;
                    this.RaisePropertyChanged("TenDangNhap");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenKH {
            get {
                return this.TenKHField;
            }
            set {
                if ((object.ReferenceEquals(this.TenKHField, value) != true)) {
                    this.TenKHField = value;
                    this.RaisePropertyChanged("TenKH");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsumerTravell.ServiceReference1.TourBooking[] TourBookings {
            get {
                return this.TourBookingsField;
            }
            set {
                if ((object.ReferenceEquals(this.TourBookingsField, value) != true)) {
                    this.TourBookingsField = value;
                    this.RaisePropertyChanged("TourBookings");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IProvinceCityImp")]
    public interface IProvinceCityImp {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProvinceCityImp/GetProvinceCities", ReplyAction="http://tempuri.org/IProvinceCityImp/GetProvinceCitiesResponse")]
        ConsumerTravell.ServiceReference1.ProvinceCity[] GetProvinceCities();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProvinceCityImp/GetProvinceCities", ReplyAction="http://tempuri.org/IProvinceCityImp/GetProvinceCitiesResponse")]
        System.Threading.Tasks.Task<ConsumerTravell.ServiceReference1.ProvinceCity[]> GetProvinceCitiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProvinceCityImp/CreateProvinceCity", ReplyAction="http://tempuri.org/IProvinceCityImp/CreateProvinceCityResponse")]
        bool CreateProvinceCity(ConsumerTravell.ServiceReference1.ProvinceCity city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProvinceCityImp/CreateProvinceCity", ReplyAction="http://tempuri.org/IProvinceCityImp/CreateProvinceCityResponse")]
        System.Threading.Tasks.Task<bool> CreateProvinceCityAsync(ConsumerTravell.ServiceReference1.ProvinceCity city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProvinceCityImp/UpdateProvinceCity", ReplyAction="http://tempuri.org/IProvinceCityImp/UpdateProvinceCityResponse")]
        bool UpdateProvinceCity(ConsumerTravell.ServiceReference1.ProvinceCity city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProvinceCityImp/UpdateProvinceCity", ReplyAction="http://tempuri.org/IProvinceCityImp/UpdateProvinceCityResponse")]
        System.Threading.Tasks.Task<bool> UpdateProvinceCityAsync(ConsumerTravell.ServiceReference1.ProvinceCity city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProvinceCityImp/DeleteProvinceCity", ReplyAction="http://tempuri.org/IProvinceCityImp/DeleteProvinceCityResponse")]
        bool DeleteProvinceCity(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProvinceCityImp/DeleteProvinceCity", ReplyAction="http://tempuri.org/IProvinceCityImp/DeleteProvinceCityResponse")]
        System.Threading.Tasks.Task<bool> DeleteProvinceCityAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProvinceCityImpChannel : ConsumerTravell.ServiceReference1.IProvinceCityImp, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProvinceCityImpClient : System.ServiceModel.ClientBase<ConsumerTravell.ServiceReference1.IProvinceCityImp>, ConsumerTravell.ServiceReference1.IProvinceCityImp {
        
        public ProvinceCityImpClient() {
        }
        
        public ProvinceCityImpClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProvinceCityImpClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProvinceCityImpClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProvinceCityImpClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ConsumerTravell.ServiceReference1.ProvinceCity[] GetProvinceCities() {
            return base.Channel.GetProvinceCities();
        }
        
        public System.Threading.Tasks.Task<ConsumerTravell.ServiceReference1.ProvinceCity[]> GetProvinceCitiesAsync() {
            return base.Channel.GetProvinceCitiesAsync();
        }
        
        public bool CreateProvinceCity(ConsumerTravell.ServiceReference1.ProvinceCity city) {
            return base.Channel.CreateProvinceCity(city);
        }
        
        public System.Threading.Tasks.Task<bool> CreateProvinceCityAsync(ConsumerTravell.ServiceReference1.ProvinceCity city) {
            return base.Channel.CreateProvinceCityAsync(city);
        }
        
        public bool UpdateProvinceCity(ConsumerTravell.ServiceReference1.ProvinceCity city) {
            return base.Channel.UpdateProvinceCity(city);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateProvinceCityAsync(ConsumerTravell.ServiceReference1.ProvinceCity city) {
            return base.Channel.UpdateProvinceCityAsync(city);
        }
        
        public bool DeleteProvinceCity(int id) {
            return base.Channel.DeleteProvinceCity(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteProvinceCityAsync(int id) {
            return base.Channel.DeleteProvinceCityAsync(id);
        }
    }
}