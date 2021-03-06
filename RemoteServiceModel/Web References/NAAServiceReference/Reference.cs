﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace RemoteServiceModel.NAAServiceReference {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="NAAWebServiceSoap", Namespace="http://tempuri.org/")]
    public partial class NAAWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetUniApplicationsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetStudentApplicationOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetStudentApplicationToUpdateOfferOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateStudentApplicationOperationCompleted;
        
        private AuthenticationHeader authenticationHeaderValueField;
        
        private System.Threading.SendOrPostCallback GetUniApplicationsAuthOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetUniApplicationsBEANOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetStudentAppsBEANOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public NAAWebService() {
            this.Url = global::RemoteServiceModel.Properties.Settings.Default.RemoteServiceModel_uk_ac_shu_hallam_webteach_net_NAAWebService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public AuthenticationHeader AuthenticationHeaderValue {
            get {
                return this.authenticationHeaderValueField;
            }
            set {
                this.authenticationHeaderValueField = value;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetUniApplicationsCompletedEventHandler GetUniApplicationsCompleted;
        
        /// <remarks/>
        public event GetStudentApplicationCompletedEventHandler GetStudentApplicationCompleted;
        
        /// <remarks/>
        public event GetStudentApplicationToUpdateOfferCompletedEventHandler GetStudentApplicationToUpdateOfferCompleted;
        
        /// <remarks/>
        public event UpdateStudentApplicationCompletedEventHandler UpdateStudentApplicationCompleted;
        
        /// <remarks/>
        public event GetUniApplicationsAuthCompletedEventHandler GetUniApplicationsAuthCompleted;
        
        /// <remarks/>
        public event GetUniApplicationsBEANCompletedEventHandler GetUniApplicationsBEANCompleted;
        
        /// <remarks/>
        public event GetStudentAppsBEANCompletedEventHandler GetStudentAppsBEANCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetUniApplications", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Application[] GetUniApplications(int uni_id) {
            object[] results = this.Invoke("GetUniApplications", new object[] {
                        uni_id});
            return ((Application[])(results[0]));
        }
        
        /// <remarks/>
        public void GetUniApplicationsAsync(int uni_id) {
            this.GetUniApplicationsAsync(uni_id, null);
        }
        
        /// <remarks/>
        public void GetUniApplicationsAsync(int uni_id, object userState) {
            if ((this.GetUniApplicationsOperationCompleted == null)) {
                this.GetUniApplicationsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUniApplicationsOperationCompleted);
            }
            this.InvokeAsync("GetUniApplications", new object[] {
                        uni_id}, this.GetUniApplicationsOperationCompleted, userState);
        }
        
        private void OnGetUniApplicationsOperationCompleted(object arg) {
            if ((this.GetUniApplicationsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUniApplicationsCompleted(this, new GetUniApplicationsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetStudentApplication", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Application GetStudentApplication(int application_id, int uni_id) {
            object[] results = this.Invoke("GetStudentApplication", new object[] {
                        application_id,
                        uni_id});
            return ((Application)(results[0]));
        }
        
        /// <remarks/>
        public void GetStudentApplicationAsync(int application_id, int uni_id) {
            this.GetStudentApplicationAsync(application_id, uni_id, null);
        }
        
        /// <remarks/>
        public void GetStudentApplicationAsync(int application_id, int uni_id, object userState) {
            if ((this.GetStudentApplicationOperationCompleted == null)) {
                this.GetStudentApplicationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetStudentApplicationOperationCompleted);
            }
            this.InvokeAsync("GetStudentApplication", new object[] {
                        application_id,
                        uni_id}, this.GetStudentApplicationOperationCompleted, userState);
        }
        
        private void OnGetStudentApplicationOperationCompleted(object arg) {
            if ((this.GetStudentApplicationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetStudentApplicationCompleted(this, new GetStudentApplicationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetStudentApplicationToUpdateOffer", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Application GetStudentApplicationToUpdateOffer(int application_id, int uni_id, string offer) {
            object[] results = this.Invoke("GetStudentApplicationToUpdateOffer", new object[] {
                        application_id,
                        uni_id,
                        offer});
            return ((Application)(results[0]));
        }
        
        /// <remarks/>
        public void GetStudentApplicationToUpdateOfferAsync(int application_id, int uni_id, string offer) {
            this.GetStudentApplicationToUpdateOfferAsync(application_id, uni_id, offer, null);
        }
        
        /// <remarks/>
        public void GetStudentApplicationToUpdateOfferAsync(int application_id, int uni_id, string offer, object userState) {
            if ((this.GetStudentApplicationToUpdateOfferOperationCompleted == null)) {
                this.GetStudentApplicationToUpdateOfferOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetStudentApplicationToUpdateOfferOperationCompleted);
            }
            this.InvokeAsync("GetStudentApplicationToUpdateOffer", new object[] {
                        application_id,
                        uni_id,
                        offer}, this.GetStudentApplicationToUpdateOfferOperationCompleted, userState);
        }
        
        private void OnGetStudentApplicationToUpdateOfferOperationCompleted(object arg) {
            if ((this.GetStudentApplicationToUpdateOfferCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetStudentApplicationToUpdateOfferCompleted(this, new GetStudentApplicationToUpdateOfferCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateStudentApplication", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateStudentApplication(int application_id, int uni_id, string offer) {
            this.Invoke("UpdateStudentApplication", new object[] {
                        application_id,
                        uni_id,
                        offer});
        }
        
        /// <remarks/>
        public void UpdateStudentApplicationAsync(int application_id, int uni_id, string offer) {
            this.UpdateStudentApplicationAsync(application_id, uni_id, offer, null);
        }
        
        /// <remarks/>
        public void UpdateStudentApplicationAsync(int application_id, int uni_id, string offer, object userState) {
            if ((this.UpdateStudentApplicationOperationCompleted == null)) {
                this.UpdateStudentApplicationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateStudentApplicationOperationCompleted);
            }
            this.InvokeAsync("UpdateStudentApplication", new object[] {
                        application_id,
                        uni_id,
                        offer}, this.UpdateStudentApplicationOperationCompleted, userState);
        }
        
        private void OnUpdateStudentApplicationOperationCompleted(object arg) {
            if ((this.UpdateStudentApplicationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateStudentApplicationCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AuthenticationHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetUniApplicationsAuth", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Application[] GetUniApplicationsAuth(int uni_id) {
            object[] results = this.Invoke("GetUniApplicationsAuth", new object[] {
                        uni_id});
            return ((Application[])(results[0]));
        }
        
        /// <remarks/>
        public void GetUniApplicationsAuthAsync(int uni_id) {
            this.GetUniApplicationsAuthAsync(uni_id, null);
        }
        
        /// <remarks/>
        public void GetUniApplicationsAuthAsync(int uni_id, object userState) {
            if ((this.GetUniApplicationsAuthOperationCompleted == null)) {
                this.GetUniApplicationsAuthOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUniApplicationsAuthOperationCompleted);
            }
            this.InvokeAsync("GetUniApplicationsAuth", new object[] {
                        uni_id}, this.GetUniApplicationsAuthOperationCompleted, userState);
        }
        
        private void OnGetUniApplicationsAuthOperationCompleted(object arg) {
            if ((this.GetUniApplicationsAuthCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUniApplicationsAuthCompleted(this, new GetUniApplicationsAuthCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetUniApplicationsBEAN", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public UniApplicationBEAN[] GetUniApplicationsBEAN(int UniversityId) {
            object[] results = this.Invoke("GetUniApplicationsBEAN", new object[] {
                        UniversityId});
            return ((UniApplicationBEAN[])(results[0]));
        }
        
        /// <remarks/>
        public void GetUniApplicationsBEANAsync(int UniversityId) {
            this.GetUniApplicationsBEANAsync(UniversityId, null);
        }
        
        /// <remarks/>
        public void GetUniApplicationsBEANAsync(int UniversityId, object userState) {
            if ((this.GetUniApplicationsBEANOperationCompleted == null)) {
                this.GetUniApplicationsBEANOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUniApplicationsBEANOperationCompleted);
            }
            this.InvokeAsync("GetUniApplicationsBEAN", new object[] {
                        UniversityId}, this.GetUniApplicationsBEANOperationCompleted, userState);
        }
        
        private void OnGetUniApplicationsBEANOperationCompleted(object arg) {
            if ((this.GetUniApplicationsBEANCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUniApplicationsBEANCompleted(this, new GetUniApplicationsBEANCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetStudentAppsBEAN", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public StudentAppBEAN[] GetStudentAppsBEAN(int UniversityId, int ApplicationId) {
            object[] results = this.Invoke("GetStudentAppsBEAN", new object[] {
                        UniversityId,
                        ApplicationId});
            return ((StudentAppBEAN[])(results[0]));
        }
        
        /// <remarks/>
        public void GetStudentAppsBEANAsync(int UniversityId, int ApplicationId) {
            this.GetStudentAppsBEANAsync(UniversityId, ApplicationId, null);
        }
        
        /// <remarks/>
        public void GetStudentAppsBEANAsync(int UniversityId, int ApplicationId, object userState) {
            if ((this.GetStudentAppsBEANOperationCompleted == null)) {
                this.GetStudentAppsBEANOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetStudentAppsBEANOperationCompleted);
            }
            this.InvokeAsync("GetStudentAppsBEAN", new object[] {
                        UniversityId,
                        ApplicationId}, this.GetStudentAppsBEANOperationCompleted, userState);
        }
        
        private void OnGetStudentAppsBEANOperationCompleted(object arg) {
            if ((this.GetStudentAppsBEANCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetStudentAppsBEANCompleted(this, new GetStudentAppsBEANCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3062.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/", IsNullable=false)]
    public partial class AuthenticationHeader : System.Web.Services.Protocols.SoapHeader {
        
        private string userField;
        
        private string passField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        public string User {
            get {
                return this.userField;
            }
            set {
                this.userField = value;
            }
        }
        
        /// <remarks/>
        public string Pass {
            get {
                return this.passField;
            }
            set {
                this.passField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3062.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class StudentAppBEAN {
        
        private int universityIdField;
        
        private int applicationIdField;
        
        private string courseNameField;
        
        private string personalStatementField;
        
        private string universityOfferField;
        
        private int applicantIdField;
        
        private string applicantNameField;
        
        private string applicantAddressField;
        
        private string phoneField;
        
        private string emailField;
        
        private System.Nullable<bool> firmField;
        
        /// <remarks/>
        public int UniversityId {
            get {
                return this.universityIdField;
            }
            set {
                this.universityIdField = value;
            }
        }
        
        /// <remarks/>
        public int ApplicationId {
            get {
                return this.applicationIdField;
            }
            set {
                this.applicationIdField = value;
            }
        }
        
        /// <remarks/>
        public string CourseName {
            get {
                return this.courseNameField;
            }
            set {
                this.courseNameField = value;
            }
        }
        
        /// <remarks/>
        public string PersonalStatement {
            get {
                return this.personalStatementField;
            }
            set {
                this.personalStatementField = value;
            }
        }
        
        /// <remarks/>
        public string UniversityOffer {
            get {
                return this.universityOfferField;
            }
            set {
                this.universityOfferField = value;
            }
        }
        
        /// <remarks/>
        public int ApplicantId {
            get {
                return this.applicantIdField;
            }
            set {
                this.applicantIdField = value;
            }
        }
        
        /// <remarks/>
        public string ApplicantName {
            get {
                return this.applicantNameField;
            }
            set {
                this.applicantNameField = value;
            }
        }
        
        /// <remarks/>
        public string ApplicantAddress {
            get {
                return this.applicantAddressField;
            }
            set {
                this.applicantAddressField = value;
            }
        }
        
        /// <remarks/>
        public string Phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }
        
        /// <remarks/>
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> Firm {
            get {
                return this.firmField;
            }
            set {
                this.firmField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3062.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class UniApplicationBEAN {
        
        private int universityIdField;
        
        private int applicationIdField;
        
        private string courseNameField;
        
        private string personalStatementField;
        
        private string universityOfferField;
        
        private int applicantIdField;
        
        private string applicantNameField;
        
        private string applicantAddressField;
        
        private string phoneField;
        
        private string emailField;
        
        private System.Nullable<bool> firmField;
        
        /// <remarks/>
        public int UniversityId {
            get {
                return this.universityIdField;
            }
            set {
                this.universityIdField = value;
            }
        }
        
        /// <remarks/>
        public int ApplicationId {
            get {
                return this.applicationIdField;
            }
            set {
                this.applicationIdField = value;
            }
        }
        
        /// <remarks/>
        public string CourseName {
            get {
                return this.courseNameField;
            }
            set {
                this.courseNameField = value;
            }
        }
        
        /// <remarks/>
        public string PersonalStatement {
            get {
                return this.personalStatementField;
            }
            set {
                this.personalStatementField = value;
            }
        }
        
        /// <remarks/>
        public string UniversityOffer {
            get {
                return this.universityOfferField;
            }
            set {
                this.universityOfferField = value;
            }
        }
        
        /// <remarks/>
        public int ApplicantId {
            get {
                return this.applicantIdField;
            }
            set {
                this.applicantIdField = value;
            }
        }
        
        /// <remarks/>
        public string ApplicantName {
            get {
                return this.applicantNameField;
            }
            set {
                this.applicantNameField = value;
            }
        }
        
        /// <remarks/>
        public string ApplicantAddress {
            get {
                return this.applicantAddressField;
            }
            set {
                this.applicantAddressField = value;
            }
        }
        
        /// <remarks/>
        public string Phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }
        
        /// <remarks/>
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> Firm {
            get {
                return this.firmField;
            }
            set {
                this.firmField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3062.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Application {
        
        private int applicationIdField;
        
        private int applicantIdField;
        
        private string courseNameField;
        
        private int universityIdField;
        
        private string personalStatementField;
        
        private string teacherReferenceField;
        
        private string teacherContactDetailsField;
        
        private string universityOfferField;
        
        private System.Nullable<bool> firmField;
        
        /// <remarks/>
        public int ApplicationId {
            get {
                return this.applicationIdField;
            }
            set {
                this.applicationIdField = value;
            }
        }
        
        /// <remarks/>
        public int ApplicantId {
            get {
                return this.applicantIdField;
            }
            set {
                this.applicantIdField = value;
            }
        }
        
        /// <remarks/>
        public string CourseName {
            get {
                return this.courseNameField;
            }
            set {
                this.courseNameField = value;
            }
        }
        
        /// <remarks/>
        public int UniversityId {
            get {
                return this.universityIdField;
            }
            set {
                this.universityIdField = value;
            }
        }
        
        /// <remarks/>
        public string PersonalStatement {
            get {
                return this.personalStatementField;
            }
            set {
                this.personalStatementField = value;
            }
        }
        
        /// <remarks/>
        public string TeacherReference {
            get {
                return this.teacherReferenceField;
            }
            set {
                this.teacherReferenceField = value;
            }
        }
        
        /// <remarks/>
        public string TeacherContactDetails {
            get {
                return this.teacherContactDetailsField;
            }
            set {
                this.teacherContactDetailsField = value;
            }
        }
        
        /// <remarks/>
        public string UniversityOffer {
            get {
                return this.universityOfferField;
            }
            set {
                this.universityOfferField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> Firm {
            get {
                return this.firmField;
            }
            set {
                this.firmField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void GetUniApplicationsCompletedEventHandler(object sender, GetUniApplicationsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUniApplicationsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetUniApplicationsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Application[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Application[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void GetStudentApplicationCompletedEventHandler(object sender, GetStudentApplicationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetStudentApplicationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetStudentApplicationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Application Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Application)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void GetStudentApplicationToUpdateOfferCompletedEventHandler(object sender, GetStudentApplicationToUpdateOfferCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetStudentApplicationToUpdateOfferCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetStudentApplicationToUpdateOfferCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Application Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Application)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void UpdateStudentApplicationCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void GetUniApplicationsAuthCompletedEventHandler(object sender, GetUniApplicationsAuthCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUniApplicationsAuthCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetUniApplicationsAuthCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Application[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Application[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void GetUniApplicationsBEANCompletedEventHandler(object sender, GetUniApplicationsBEANCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUniApplicationsBEANCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetUniApplicationsBEANCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public UniApplicationBEAN[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((UniApplicationBEAN[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    public delegate void GetStudentAppsBEANCompletedEventHandler(object sender, GetStudentAppsBEANCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3062.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetStudentAppsBEANCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetStudentAppsBEANCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public StudentAppBEAN[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((StudentAppBEAN[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591