﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinanceApp.usermanagement.service {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="usermanagement.service.UserManagementServiceSoap")]
    public interface UserManagementServiceSoap {
        
        // CODEGEN: Generating message contract since element name username from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/registerUser", ReplyAction="*")]
        FinanceApp.usermanagement.service.registerUserResponse registerUser(FinanceApp.usermanagement.service.registerUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/registerUser", ReplyAction="*")]
        System.Threading.Tasks.Task<FinanceApp.usermanagement.service.registerUserResponse> registerUserAsync(FinanceApp.usermanagement.service.registerUserRequest request);
        
        // CODEGEN: Generating message contract since element name username from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/loginUser", ReplyAction="*")]
        FinanceApp.usermanagement.service.loginUserResponse loginUser(FinanceApp.usermanagement.service.loginUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/loginUser", ReplyAction="*")]
        System.Threading.Tasks.Task<FinanceApp.usermanagement.service.loginUserResponse> loginUserAsync(FinanceApp.usermanagement.service.loginUserRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class registerUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="registerUser", Namespace="http://tempuri.org/", Order=0)]
        public FinanceApp.usermanagement.service.registerUserRequestBody Body;
        
        public registerUserRequest() {
        }
        
        public registerUserRequest(FinanceApp.usermanagement.service.registerUserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class registerUserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public registerUserRequestBody() {
        }
        
        public registerUserRequestBody(string username, string password) {
            this.username = username;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class registerUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="registerUserResponse", Namespace="http://tempuri.org/", Order=0)]
        public FinanceApp.usermanagement.service.registerUserResponseBody Body;
        
        public registerUserResponse() {
        }
        
        public registerUserResponse(FinanceApp.usermanagement.service.registerUserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class registerUserResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool registerUserResult;
        
        public registerUserResponseBody() {
        }
        
        public registerUserResponseBody(bool registerUserResult) {
            this.registerUserResult = registerUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class loginUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="loginUser", Namespace="http://tempuri.org/", Order=0)]
        public FinanceApp.usermanagement.service.loginUserRequestBody Body;
        
        public loginUserRequest() {
        }
        
        public loginUserRequest(FinanceApp.usermanagement.service.loginUserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class loginUserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string username;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public loginUserRequestBody() {
        }
        
        public loginUserRequestBody(string username, string password) {
            this.username = username;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class loginUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="loginUserResponse", Namespace="http://tempuri.org/", Order=0)]
        public FinanceApp.usermanagement.service.loginUserResponseBody Body;
        
        public loginUserResponse() {
        }
        
        public loginUserResponse(FinanceApp.usermanagement.service.loginUserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class loginUserResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int loginUserResult;
        
        public loginUserResponseBody() {
        }
        
        public loginUserResponseBody(int loginUserResult) {
            this.loginUserResult = loginUserResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UserManagementServiceSoapChannel : FinanceApp.usermanagement.service.UserManagementServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserManagementServiceSoapClient : System.ServiceModel.ClientBase<FinanceApp.usermanagement.service.UserManagementServiceSoap>, FinanceApp.usermanagement.service.UserManagementServiceSoap {
        
        public UserManagementServiceSoapClient() {
        }
        
        public UserManagementServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserManagementServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserManagementServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserManagementServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FinanceApp.usermanagement.service.registerUserResponse FinanceApp.usermanagement.service.UserManagementServiceSoap.registerUser(FinanceApp.usermanagement.service.registerUserRequest request) {
            return base.Channel.registerUser(request);
        }
        
        public bool registerUser(string username, string password) {
            FinanceApp.usermanagement.service.registerUserRequest inValue = new FinanceApp.usermanagement.service.registerUserRequest();
            inValue.Body = new FinanceApp.usermanagement.service.registerUserRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            FinanceApp.usermanagement.service.registerUserResponse retVal = ((FinanceApp.usermanagement.service.UserManagementServiceSoap)(this)).registerUser(inValue);
            return retVal.Body.registerUserResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FinanceApp.usermanagement.service.registerUserResponse> FinanceApp.usermanagement.service.UserManagementServiceSoap.registerUserAsync(FinanceApp.usermanagement.service.registerUserRequest request) {
            return base.Channel.registerUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<FinanceApp.usermanagement.service.registerUserResponse> registerUserAsync(string username, string password) {
            FinanceApp.usermanagement.service.registerUserRequest inValue = new FinanceApp.usermanagement.service.registerUserRequest();
            inValue.Body = new FinanceApp.usermanagement.service.registerUserRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            return ((FinanceApp.usermanagement.service.UserManagementServiceSoap)(this)).registerUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FinanceApp.usermanagement.service.loginUserResponse FinanceApp.usermanagement.service.UserManagementServiceSoap.loginUser(FinanceApp.usermanagement.service.loginUserRequest request) {
            return base.Channel.loginUser(request);
        }
        
        public int loginUser(string username, string password) {
            FinanceApp.usermanagement.service.loginUserRequest inValue = new FinanceApp.usermanagement.service.loginUserRequest();
            inValue.Body = new FinanceApp.usermanagement.service.loginUserRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            FinanceApp.usermanagement.service.loginUserResponse retVal = ((FinanceApp.usermanagement.service.UserManagementServiceSoap)(this)).loginUser(inValue);
            return retVal.Body.loginUserResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<FinanceApp.usermanagement.service.loginUserResponse> FinanceApp.usermanagement.service.UserManagementServiceSoap.loginUserAsync(FinanceApp.usermanagement.service.loginUserRequest request) {
            return base.Channel.loginUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<FinanceApp.usermanagement.service.loginUserResponse> loginUserAsync(string username, string password) {
            FinanceApp.usermanagement.service.loginUserRequest inValue = new FinanceApp.usermanagement.service.loginUserRequest();
            inValue.Body = new FinanceApp.usermanagement.service.loginUserRequestBody();
            inValue.Body.username = username;
            inValue.Body.password = password;
            return ((FinanceApp.usermanagement.service.UserManagementServiceSoap)(this)).loginUserAsync(inValue);
        }
    }
}
