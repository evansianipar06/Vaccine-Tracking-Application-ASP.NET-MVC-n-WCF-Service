﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplikasiTrackingVaksin.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Login", Namespace="http://schemas.datacontract.org/2004/07/Project")]
    [System.SerializableAttribute()]
    public partial class Login : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PassswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
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
        public string Passsword {
            get {
                return this.PassswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PassswordField, value) != true)) {
                    this.PassswordField = value;
                    this.RaisePropertyChanged("Passsword");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Role {
            get {
                return this.RoleField;
            }
            set {
                if ((object.ReferenceEquals(this.RoleField, value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Data_Penduduk", Namespace="http://schemas.datacontract.org/2004/07/Project")]
    [System.SerializableAttribute()]
    public partial class Data_Penduduk : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NIKField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string kecamatanField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string kelurahanField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int kode_posField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string kotaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string namaField;
        
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
        public string NIK {
            get {
                return this.NIKField;
            }
            set {
                if ((object.ReferenceEquals(this.NIKField, value) != true)) {
                    this.NIKField = value;
                    this.RaisePropertyChanged("NIK");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string kecamatan {
            get {
                return this.kecamatanField;
            }
            set {
                if ((object.ReferenceEquals(this.kecamatanField, value) != true)) {
                    this.kecamatanField = value;
                    this.RaisePropertyChanged("kecamatan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string kelurahan {
            get {
                return this.kelurahanField;
            }
            set {
                if ((object.ReferenceEquals(this.kelurahanField, value) != true)) {
                    this.kelurahanField = value;
                    this.RaisePropertyChanged("kelurahan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int kode_pos {
            get {
                return this.kode_posField;
            }
            set {
                if ((this.kode_posField.Equals(value) != true)) {
                    this.kode_posField = value;
                    this.RaisePropertyChanged("kode_pos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string kota {
            get {
                return this.kotaField;
            }
            set {
                if ((object.ReferenceEquals(this.kotaField, value) != true)) {
                    this.kotaField = value;
                    this.RaisePropertyChanged("kota");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nama {
            get {
                return this.namaField;
            }
            set {
                if ((object.ReferenceEquals(this.namaField, value) != true)) {
                    this.namaField = value;
                    this.RaisePropertyChanged("nama");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Reg_Vaksin", Namespace="http://schemas.datacontract.org/2004/07/Project")]
    [System.SerializableAttribute()]
    public partial class Reg_Vaksin : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string jenisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string kodeField;
        
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
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string jenis {
            get {
                return this.jenisField;
            }
            set {
                if ((object.ReferenceEquals(this.jenisField, value) != true)) {
                    this.jenisField = value;
                    this.RaisePropertyChanged("jenis");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string kode {
            get {
                return this.kodeField;
            }
            set {
                if ((object.ReferenceEquals(this.kodeField, value) != true)) {
                    this.kodeField = value;
                    this.RaisePropertyChanged("kode");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/auth", ReplyAction="http://tempuri.org/IService1/authResponse")]
        AplikasiTrackingVaksin.ServiceReference1.Login auth(AplikasiTrackingVaksin.ServiceReference1.Login data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/auth", ReplyAction="http://tempuri.org/IService1/authResponse")]
        System.Threading.Tasks.Task<AplikasiTrackingVaksin.ServiceReference1.Login> authAsync(AplikasiTrackingVaksin.ServiceReference1.Login data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        bool Login(string Username, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string Username, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAkun", ReplyAction="http://tempuri.org/IService1/GetAkunResponse")]
        AplikasiTrackingVaksin.ServiceReference1.Login GetAkun(string Username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAkun", ReplyAction="http://tempuri.org/IService1/GetAkunResponse")]
        System.Threading.Tasks.Task<AplikasiTrackingVaksin.ServiceReference1.Login> GetAkunAsync(string Username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/datapenduduk", ReplyAction="http://tempuri.org/IService1/datapendudukResponse")]
        AplikasiTrackingVaksin.ServiceReference1.Data_Penduduk[] datapenduduk();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/datapenduduk", ReplyAction="http://tempuri.org/IService1/datapendudukResponse")]
        System.Threading.Tasks.Task<AplikasiTrackingVaksin.ServiceReference1.Data_Penduduk[]> datapendudukAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/tambahPenduduk", ReplyAction="http://tempuri.org/IService1/tambahPendudukResponse")]
        bool tambahPenduduk(AplikasiTrackingVaksin.ServiceReference1.Data_Penduduk datapenduduk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/tambahPenduduk", ReplyAction="http://tempuri.org/IService1/tambahPendudukResponse")]
        System.Threading.Tasks.Task<bool> tambahPendudukAsync(AplikasiTrackingVaksin.ServiceReference1.Data_Penduduk datapenduduk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPenduduk", ReplyAction="http://tempuri.org/IService1/getPendudukResponse")]
        bool getPenduduk(AplikasiTrackingVaksin.ServiceReference1.Data_Penduduk data_Penduduk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getPenduduk", ReplyAction="http://tempuri.org/IService1/getPendudukResponse")]
        System.Threading.Tasks.Task<bool> getPendudukAsync(AplikasiTrackingVaksin.ServiceReference1.Data_Penduduk data_Penduduk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePenduduk", ReplyAction="http://tempuri.org/IService1/deletePendudukResponse")]
        bool deletePenduduk(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/deletePenduduk", ReplyAction="http://tempuri.org/IService1/deletePendudukResponse")]
        System.Threading.Tasks.Task<bool> deletePendudukAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editPenduduk", ReplyAction="http://tempuri.org/IService1/editPendudukResponse")]
        bool editPenduduk(AplikasiTrackingVaksin.ServiceReference1.Data_Penduduk data_Penduduk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editPenduduk", ReplyAction="http://tempuri.org/IService1/editPendudukResponse")]
        System.Threading.Tasks.Task<bool> editPendudukAsync(AplikasiTrackingVaksin.ServiceReference1.Data_Penduduk data_Penduduk);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData_PendudukById", ReplyAction="http://tempuri.org/IService1/GetData_PendudukByIdResponse")]
        AplikasiTrackingVaksin.ServiceReference1.Data_Penduduk GetData_PendudukById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData_PendudukById", ReplyAction="http://tempuri.org/IService1/GetData_PendudukByIdResponse")]
        System.Threading.Tasks.Task<AplikasiTrackingVaksin.ServiceReference1.Data_Penduduk> GetData_PendudukByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/dataRegVaksin", ReplyAction="http://tempuri.org/IService1/dataRegVaksinResponse")]
        AplikasiTrackingVaksin.ServiceReference1.Reg_Vaksin[] dataRegVaksin();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/dataRegVaksin", ReplyAction="http://tempuri.org/IService1/dataRegVaksinResponse")]
        System.Threading.Tasks.Task<AplikasiTrackingVaksin.ServiceReference1.Reg_Vaksin[]> dataRegVaksinAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/tambahRegVaksin", ReplyAction="http://tempuri.org/IService1/tambahRegVaksinResponse")]
        bool tambahRegVaksin(AplikasiTrackingVaksin.ServiceReference1.Reg_Vaksin regVaksin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/tambahRegVaksin", ReplyAction="http://tempuri.org/IService1/tambahRegVaksinResponse")]
        System.Threading.Tasks.Task<bool> tambahRegVaksinAsync(AplikasiTrackingVaksin.ServiceReference1.Reg_Vaksin regVaksin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/hapusRegVaksin", ReplyAction="http://tempuri.org/IService1/hapusRegVaksinResponse")]
        bool hapusRegVaksin(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/hapusRegVaksin", ReplyAction="http://tempuri.org/IService1/hapusRegVaksinResponse")]
        System.Threading.Tasks.Task<bool> hapusRegVaksinAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editRegVaksin", ReplyAction="http://tempuri.org/IService1/editRegVaksinResponse")]
        bool editRegVaksin(AplikasiTrackingVaksin.ServiceReference1.Reg_Vaksin regVaksin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/editRegVaksin", ReplyAction="http://tempuri.org/IService1/editRegVaksinResponse")]
        System.Threading.Tasks.Task<bool> editRegVaksinAsync(AplikasiTrackingVaksin.ServiceReference1.Reg_Vaksin regVaksin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getRegVaksin", ReplyAction="http://tempuri.org/IService1/getRegVaksinResponse")]
        bool getRegVaksin(AplikasiTrackingVaksin.ServiceReference1.Reg_Vaksin regVaksin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getRegVaksin", ReplyAction="http://tempuri.org/IService1/getRegVaksinResponse")]
        System.Threading.Tasks.Task<bool> getRegVaksinAsync(AplikasiTrackingVaksin.ServiceReference1.Reg_Vaksin regVaksin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getDataRegVaksinById", ReplyAction="http://tempuri.org/IService1/getDataRegVaksinByIdResponse")]
        AplikasiTrackingVaksin.ServiceReference1.Reg_Vaksin getDataRegVaksinById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getDataRegVaksinById", ReplyAction="http://tempuri.org/IService1/getDataRegVaksinByIdResponse")]
        System.Threading.Tasks.Task<AplikasiTrackingVaksin.ServiceReference1.Reg_Vaksin> getDataRegVaksinByIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : AplikasiTrackingVaksin.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<AplikasiTrackingVaksin.ServiceReference1.IService1>, AplikasiTrackingVaksin.ServiceReference1.IService1 {
        
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
        
        public AplikasiTrackingVaksin.ServiceReference1.Login auth(AplikasiTrackingVaksin.ServiceReference1.Login data) {
            return base.Channel.auth(data);
        }
        
        public System.Threading.Tasks.Task<AplikasiTrackingVaksin.ServiceReference1.Login> authAsync(AplikasiTrackingVaksin.ServiceReference1.Login data) {
            return base.Channel.authAsync(data);
        }
        
        public bool Login(string Username, string Password) {
            return base.Channel.Login(Username, Password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string Username, string Password) {
            return base.Channel.LoginAsync(Username, Password);
        }
        
        public AplikasiTrackingVaksin.ServiceReference1.Login GetAkun(string Username) {
            return base.Channel.GetAkun(Username);
        }
        
        public System.Threading.Tasks.Task<AplikasiTrackingVaksin.ServiceReference1.Login> GetAkunAsync(string Username) {
            return base.Channel.GetAkunAsync(Username);
        }
        
        public AplikasiTrackingVaksin.ServiceReference1.Data_Penduduk[] datapenduduk() {
            return base.Channel.datapenduduk();
        }
        
        public System.Threading.Tasks.Task<AplikasiTrackingVaksin.ServiceReference1.Data_Penduduk[]> datapendudukAsync() {
            return base.Channel.datapendudukAsync();
        }
        
        public bool tambahPenduduk(AplikasiTrackingVaksin.ServiceReference1.Data_Penduduk datapenduduk) {
            return base.Channel.tambahPenduduk(datapenduduk);
        }
        
        public System.Threading.Tasks.Task<bool> tambahPendudukAsync(AplikasiTrackingVaksin.ServiceReference1.Data_Penduduk datapenduduk) {
            return base.Channel.tambahPendudukAsync(datapenduduk);
        }
        
        public bool getPenduduk(AplikasiTrackingVaksin.ServiceReference1.Data_Penduduk data_Penduduk) {
            return base.Channel.getPenduduk(data_Penduduk);
        }
        
        public System.Threading.Tasks.Task<bool> getPendudukAsync(AplikasiTrackingVaksin.ServiceReference1.Data_Penduduk data_Penduduk) {
            return base.Channel.getPendudukAsync(data_Penduduk);
        }
        
        public bool deletePenduduk(int id) {
            return base.Channel.deletePenduduk(id);
        }
        
        public System.Threading.Tasks.Task<bool> deletePendudukAsync(int id) {
            return base.Channel.deletePendudukAsync(id);
        }
        
        public bool editPenduduk(AplikasiTrackingVaksin.ServiceReference1.Data_Penduduk data_Penduduk) {
            return base.Channel.editPenduduk(data_Penduduk);
        }
        
        public System.Threading.Tasks.Task<bool> editPendudukAsync(AplikasiTrackingVaksin.ServiceReference1.Data_Penduduk data_Penduduk) {
            return base.Channel.editPendudukAsync(data_Penduduk);
        }
        
        public AplikasiTrackingVaksin.ServiceReference1.Data_Penduduk GetData_PendudukById(int id) {
            return base.Channel.GetData_PendudukById(id);
        }
        
        public System.Threading.Tasks.Task<AplikasiTrackingVaksin.ServiceReference1.Data_Penduduk> GetData_PendudukByIdAsync(int id) {
            return base.Channel.GetData_PendudukByIdAsync(id);
        }
        
        public AplikasiTrackingVaksin.ServiceReference1.Reg_Vaksin[] dataRegVaksin() {
            return base.Channel.dataRegVaksin();
        }
        
        public System.Threading.Tasks.Task<AplikasiTrackingVaksin.ServiceReference1.Reg_Vaksin[]> dataRegVaksinAsync() {
            return base.Channel.dataRegVaksinAsync();
        }
        
        public bool tambahRegVaksin(AplikasiTrackingVaksin.ServiceReference1.Reg_Vaksin regVaksin) {
            return base.Channel.tambahRegVaksin(regVaksin);
        }
        
        public System.Threading.Tasks.Task<bool> tambahRegVaksinAsync(AplikasiTrackingVaksin.ServiceReference1.Reg_Vaksin regVaksin) {
            return base.Channel.tambahRegVaksinAsync(regVaksin);
        }
        
        public bool hapusRegVaksin(int id) {
            return base.Channel.hapusRegVaksin(id);
        }
        
        public System.Threading.Tasks.Task<bool> hapusRegVaksinAsync(int id) {
            return base.Channel.hapusRegVaksinAsync(id);
        }
        
        public bool editRegVaksin(AplikasiTrackingVaksin.ServiceReference1.Reg_Vaksin regVaksin) {
            return base.Channel.editRegVaksin(regVaksin);
        }
        
        public System.Threading.Tasks.Task<bool> editRegVaksinAsync(AplikasiTrackingVaksin.ServiceReference1.Reg_Vaksin regVaksin) {
            return base.Channel.editRegVaksinAsync(regVaksin);
        }
        
        public bool getRegVaksin(AplikasiTrackingVaksin.ServiceReference1.Reg_Vaksin regVaksin) {
            return base.Channel.getRegVaksin(regVaksin);
        }
        
        public System.Threading.Tasks.Task<bool> getRegVaksinAsync(AplikasiTrackingVaksin.ServiceReference1.Reg_Vaksin regVaksin) {
            return base.Channel.getRegVaksinAsync(regVaksin);
        }
        
        public AplikasiTrackingVaksin.ServiceReference1.Reg_Vaksin getDataRegVaksinById(int id) {
            return base.Channel.getDataRegVaksinById(id);
        }
        
        public System.Threading.Tasks.Task<AplikasiTrackingVaksin.ServiceReference1.Reg_Vaksin> getDataRegVaksinByIdAsync(int id) {
            return base.Channel.getDataRegVaksinByIdAsync(id);
        }
    }
}
