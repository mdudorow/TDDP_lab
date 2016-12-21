//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Reflection.AssemblyVersionAttribute("0.0.0.0")]
[assembly: global::Microsoft.Dss.Core.Attributes.ServiceDeclarationAttribute(global::Microsoft.Dss.Core.Attributes.DssServiceDeclaration.Proxy, SourceAssemblyKey="User.ServiceTutorial1.Y2006.M06, Version=0.0.0.0, Culture=neutral, PublicKeyToken" +
    "=9425fde5d986f051")]
[assembly: global::System.Security.SecurityTransparentAttribute()]
[assembly: global::System.Security.SecurityRulesAttribute(global::System.Security.SecurityRuleSet.Level1)]

namespace RoboticsServiceTutorial1.Proxy {
    
    
    [global::Microsoft.Dss.Core.Attributes.DataContractAttribute(Namespace="http://schemas.microsoft.com/2006/06/servicetutorial1.user.html")]
    [global::System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.microsoft.com/2006/06/servicetutorial1.user.html", ElementName="ServiceTutorial1State")]
    public class ServiceTutorial1State : global::Microsoft.Dss.Core.IDssSerializable, global::System.ICloneable {
        
        public ServiceTutorial1State() {
        }
        
        private string _Member;
        
        [global::Microsoft.Dss.Core.Attributes.DataMemberAttribute(Order=-1)]
        public string Member {
            get {
                return this._Member;
            }
            set {
                this._Member = value;
            }
        }
        
        /// <summary>
        ///Copies the data member values of the current ServiceTutorial1State to the specified target object
        ///</summary>
        ///<param name="target">target object (must be an instance of)</param>
        public virtual void CopyTo(Microsoft.Dss.Core.IDssSerializable target) {
            global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State typedTarget = ((global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State)(target));
            typedTarget._Member = this._Member;
        }
        
        /// <summary>
        ///Clones ServiceTutorial1State
        ///</summary>
        ///<returns>cloned value</returns>
        public virtual object Clone() {
            global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State target0 = new global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State();
            this.CopyTo(target0);
            return target0;
        }
        
        /// <summary>
        ///Serializes the data member values of the current ServiceTutorial1State to the specified writer
        ///</summary>
        ///<param name="writer">the writer to which to serialize</param>
        public virtual void Serialize(System.IO.BinaryWriter writer) {
            if ((this._Member == null)) {
                writer.Write(((byte)(0)));
            }
            else {
                writer.Write(((byte)(1)));
                writer.Write(this._Member);
            }
        }
        
        /// <summary>
        ///Deserializes ServiceTutorial1State
        ///</summary>
        ///<param name="reader">the reader from which to deserialize</param>
        ///<returns>deserialized ServiceTutorial1State</returns>
        public virtual object Deserialize(System.IO.BinaryReader reader) {
            if ((reader.ReadByte() != 0)) {
                this._Member = reader.ReadString();
            }
            return this;
        }
    }
    
    [global::System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public class Get : global::Microsoft.Dss.ServiceModel.Dssp.Get<global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType, global:: Microsoft.Ccr.Core.PortSet<global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State, global:: W3C.Soap.Fault>> {
        
        public Get() {
        }
        
        public Get(global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body) : 
                base(body) {
        }
        
        public Get(global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body, global::Microsoft.Ccr.Core.PortSet<global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State, global:: W3C.Soap.Fault> responsePort) : 
                base(body, responsePort) {
        }
    }
    
    [global::System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public class Replace : global::Microsoft.Dss.ServiceModel.Dssp.Replace<global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State, global:: Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.DefaultReplaceResponseType, global:: W3C.Soap.Fault>> {
        
        public Replace() {
        }
        
        public Replace(global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State body) : 
                base(body) {
        }
        
        public Replace(global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State body, global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.DefaultReplaceResponseType, global:: W3C.Soap.Fault> responsePort) : 
                base(body, responsePort) {
        }
    }
    
    [global::System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public class ServiceTutorial1Operations : global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup, global:: Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop, global:: RoboticsServiceTutorial1.Proxy.Get, global:: Microsoft.Dss.Core.DsspHttp.HttpGet, global:: RoboticsServiceTutorial1.Proxy.Replace> {
        
        public ServiceTutorial1Operations() {
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.LookupResponse, global::W3C.Soap.Fault> DsspDefaultLookup() {
            global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType();
            global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice DsspDefaultLookup(out global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup operation) {
            global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType();
            operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.LookupResponse, global::W3C.Soap.Fault> DsspDefaultLookup(global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType body) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType();
            }
            global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice DsspDefaultLookup(global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType body, out global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup operation) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.LookupRequestType();
            }
            operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultLookup(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.DefaultDropResponseType, global::W3C.Soap.Fault> DsspDefaultDrop() {
            global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType();
            global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice DsspDefaultDrop(out global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop operation) {
            global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType();
            operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.DefaultDropResponseType, global::W3C.Soap.Fault> DsspDefaultDrop(global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType body) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType();
            }
            global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice DsspDefaultDrop(global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType body, out global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop operation) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.DropRequestType();
            }
            operation = new global::Microsoft.Dss.ServiceModel.Dssp.DsspDefaultDrop(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State, global:: W3C.Soap.Fault> Get() {
            global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType();
            global::RoboticsServiceTutorial1.Proxy.Get operation = new global::RoboticsServiceTutorial1.Proxy.Get(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice Get(out global::RoboticsServiceTutorial1.Proxy.Get operation) {
            global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body = new global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType();
            operation = new global::RoboticsServiceTutorial1.Proxy.Get(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State, global:: W3C.Soap.Fault> Get(global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType();
            }
            global::RoboticsServiceTutorial1.Proxy.Get operation = new global::RoboticsServiceTutorial1.Proxy.Get(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice Get(global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType body, out global::RoboticsServiceTutorial1.Proxy.Get operation) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.ServiceModel.Dssp.GetRequestType();
            }
            operation = new global::RoboticsServiceTutorial1.Proxy.Get(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.Core.DsspHttp.HttpResponseType, global::W3C.Soap.Fault> HttpGet() {
            global::Microsoft.Dss.Core.DsspHttp.HttpGetRequestType body = new global::Microsoft.Dss.Core.DsspHttp.HttpGetRequestType();
            global::Microsoft.Dss.Core.DsspHttp.HttpGet operation = new global::Microsoft.Dss.Core.DsspHttp.HttpGet(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice HttpGet(out global::Microsoft.Dss.Core.DsspHttp.HttpGet operation) {
            global::Microsoft.Dss.Core.DsspHttp.HttpGetRequestType body = new global::Microsoft.Dss.Core.DsspHttp.HttpGetRequestType();
            operation = new global::Microsoft.Dss.Core.DsspHttp.HttpGet(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.Core.DsspHttp.HttpResponseType, global::W3C.Soap.Fault> HttpGet(global::Microsoft.Dss.Core.DsspHttp.HttpGetRequestType body) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.Core.DsspHttp.HttpGetRequestType();
            }
            global::Microsoft.Dss.Core.DsspHttp.HttpGet operation = new global::Microsoft.Dss.Core.DsspHttp.HttpGet(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice HttpGet(global::Microsoft.Dss.Core.DsspHttp.HttpGetRequestType body, out global::Microsoft.Dss.Core.DsspHttp.HttpGet operation) {
            if ((body == null)) {
                body = new global::Microsoft.Dss.Core.DsspHttp.HttpGetRequestType();
            }
            operation = new global::Microsoft.Dss.Core.DsspHttp.HttpGet(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.DefaultReplaceResponseType, global:: W3C.Soap.Fault> Replace() {
            global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State body = new global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State();
            global::RoboticsServiceTutorial1.Proxy.Replace operation = new global::RoboticsServiceTutorial1.Proxy.Replace(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice Replace(out global::RoboticsServiceTutorial1.Proxy.Replace operation) {
            global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State body = new global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State();
            operation = new global::RoboticsServiceTutorial1.Proxy.Replace(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.PortSet<global::Microsoft.Dss.ServiceModel.Dssp.DefaultReplaceResponseType, global:: W3C.Soap.Fault> Replace(global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State body) {
            if ((body == null)) {
                body = new global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State();
            }
            global::RoboticsServiceTutorial1.Proxy.Replace operation = new global::RoboticsServiceTutorial1.Proxy.Replace(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
        
        public virtual global::Microsoft.Ccr.Core.Choice Replace(global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State body, out global::RoboticsServiceTutorial1.Proxy.Replace operation) {
            if ((body == null)) {
                body = new global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1State();
            }
            operation = new global::RoboticsServiceTutorial1.Proxy.Replace(body);
            this.Post(operation);
            return operation.ResponsePort;
        }
    }
    
    [global::System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    [global::System.ComponentModel.DescriptionAttribute("Demonstrates how to write a basic service.")]
    [global::System.ComponentModel.DisplayNameAttribute("(User) Service Tutorial 1: Creating a Service")]
    public class Contract {
        
        public const string Identifier = "http://schemas.microsoft.com/2006/06/servicetutorial1.user.html";
        
        /// <summary>Creates a new instance of the service.</summary>
        /// <param name="constructorServicePort">Service constructor port</param>
        /// <param name="service">service path</param>
        /// <param name="partners">the partners of the service instance</param>
        /// <returns>create service response port</returns>
        public static global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse> CreateService(global::Microsoft.Dss.Services.Constructor.ConstructorPort constructorServicePort, string service, params Microsoft.Dss.ServiceModel.Dssp.PartnerType[] partners) {
            global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse> result = new global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse>();
            global::Microsoft.Dss.ServiceModel.Dssp.ServiceInfoType serviceInfo = new global::Microsoft.Dss.ServiceModel.Dssp.ServiceInfoType("http://schemas.microsoft.com/2006/06/servicetutorial1.user.html", service);
            if ((partners != null)) {
                serviceInfo.PartnerList = new System.Collections.Generic.List<Microsoft.Dss.ServiceModel.Dssp.PartnerType>(partners);
            }
            global::Microsoft.Dss.Services.Constructor.Create create = new global::Microsoft.Dss.Services.Constructor.Create(serviceInfo, result);
            constructorServicePort.Post(create);
            return result;
        }
        
        /// <summary>Creates a new instance of the service.</summary>
        /// <param name="constructorServicePort">Service constructor port</param>
        /// <param name="partners">the partners of the service instance</param>
        /// <returns>create service response port</returns>
        public static global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse> CreateService(global::Microsoft.Dss.Services.Constructor.ConstructorPort constructorServicePort, params Microsoft.Dss.ServiceModel.Dssp.PartnerType[] partners) {
            global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse> result = new global::Microsoft.Dss.ServiceModel.Dssp.DsspResponsePort<Microsoft.Dss.ServiceModel.Dssp.CreateResponse>();
            global::Microsoft.Dss.ServiceModel.Dssp.ServiceInfoType serviceInfo = new global::Microsoft.Dss.ServiceModel.Dssp.ServiceInfoType("http://schemas.microsoft.com/2006/06/servicetutorial1.user.html", null);
            if ((partners != null)) {
                serviceInfo.PartnerList = new System.Collections.Generic.List<Microsoft.Dss.ServiceModel.Dssp.PartnerType>(partners);
            }
            global::Microsoft.Dss.Services.Constructor.Create create = new global::Microsoft.Dss.Services.Constructor.Create(serviceInfo, result);
            constructorServicePort.Post(create);
            return result;
        }
    }
    
    public class CombinedOperationsPort : global::Microsoft.Dss.Core.DssCombinedOperationsPort {
        
        public CombinedOperationsPort() {
            this.ServiceTutorial1Operations = new global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1Operations();
            base.Initialize(new global::Microsoft.Dss.Core.DssOperationsPortMetadata(this.ServiceTutorial1Operations, "http://schemas.microsoft.com/2006/06/servicetutorial1.user.html", "ServiceTutorial1Operations", ""));
        }
        
        public global::RoboticsServiceTutorial1.Proxy.ServiceTutorial1Operations ServiceTutorial1Operations;
    }
}
