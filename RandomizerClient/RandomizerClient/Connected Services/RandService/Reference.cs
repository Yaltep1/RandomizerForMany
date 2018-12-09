﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RandomizerClient.RandService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RandService.IController")]
    public interface IController {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IController/controller", ReplyAction="http://tempuri.org/IController/controllerResponse")]
        void controller();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IController/controller", ReplyAction="http://tempuri.org/IController/controllerResponse")]
        System.Threading.Tasks.Task controllerAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IController/loginUser", ReplyAction="http://tempuri.org/IController/loginUserResponse")]
        bool loginUser(string log, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IController/loginUser", ReplyAction="http://tempuri.org/IController/loginUserResponse")]
        System.Threading.Tasks.Task<bool> loginUserAsync(string log, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IController/logout", ReplyAction="http://tempuri.org/IController/logoutResponse")]
        void logout();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IController/logout", ReplyAction="http://tempuri.org/IController/logoutResponse")]
        System.Threading.Tasks.Task logoutAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IController/randomize", ReplyAction="http://tempuri.org/IController/randomizeResponse")]
        System.Collections.Generic.Stack<string> randomize(string start, string end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IController/randomize", ReplyAction="http://tempuri.org/IController/randomizeResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Stack<string>> randomizeAsync(string start, string end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IController/tryIncertReq", ReplyAction="http://tempuri.org/IController/tryIncertReqResponse")]
        bool tryIncertReq(string start, string end);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IController/tryIncertReq", ReplyAction="http://tempuri.org/IController/tryIncertReqResponse")]
        System.Threading.Tasks.Task<bool> tryIncertReqAsync(string start, string end);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IControllerChannel : RandomizerClient.RandService.IController, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ControllerClient : System.ServiceModel.ClientBase<RandomizerClient.RandService.IController>, RandomizerClient.RandService.IController {
        
        public ControllerClient() {
        }
        
        public ControllerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ControllerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ControllerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ControllerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void controller() {
            base.Channel.controller();
        }
        
        public System.Threading.Tasks.Task controllerAsync() {
            return base.Channel.controllerAsync();
        }
        
        public bool loginUser(string log, string pass) {
            return base.Channel.loginUser(log, pass);
        }
        
        public System.Threading.Tasks.Task<bool> loginUserAsync(string log, string pass) {
            return base.Channel.loginUserAsync(log, pass);
        }
        
        public void logout() {
            base.Channel.logout();
        }
        
        public System.Threading.Tasks.Task logoutAsync() {
            return base.Channel.logoutAsync();
        }
        
        public System.Collections.Generic.Stack<string> randomize(string start, string end) {
            return base.Channel.randomize(start, end);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Stack<string>> randomizeAsync(string start, string end) {
            return base.Channel.randomizeAsync(start, end);
        }
        
        public bool tryIncertReq(string start, string end) {
            return base.Channel.tryIncertReq(start, end);
        }
        
        public System.Threading.Tasks.Task<bool> tryIncertReqAsync(string start, string end) {
            return base.Channel.tryIncertReqAsync(start, end);
        }
    }
}