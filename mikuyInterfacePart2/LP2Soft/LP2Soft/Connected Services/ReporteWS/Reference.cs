﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LP2Soft.ReporteWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://services.lp2soft.pucp.edu.pe/", ConfigurationName="ReporteWS.ReporteWS")]
    public interface ReporteWS {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento arg1 del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2soft.pucp.edu.pe/ReporteWS/generarFacturaVentaRequest", ReplyAction="http://services.lp2soft.pucp.edu.pe/ReporteWS/generarFacturaVentaResponse")]
        LP2Soft.ReporteWS.generarFacturaVentaResponse generarFacturaVenta(LP2Soft.ReporteWS.generarFacturaVentaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2soft.pucp.edu.pe/ReporteWS/generarFacturaVentaRequest", ReplyAction="http://services.lp2soft.pucp.edu.pe/ReporteWS/generarFacturaVentaResponse")]
        System.Threading.Tasks.Task<LP2Soft.ReporteWS.generarFacturaVentaResponse> generarFacturaVentaAsync(LP2Soft.ReporteWS.generarFacturaVentaRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento arg0 del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2soft.pucp.edu.pe/ReporteWS/generarReporteAsistenciaRequest", ReplyAction="http://services.lp2soft.pucp.edu.pe/ReporteWS/generarReporteAsistenciaResponse")]
        LP2Soft.ReporteWS.generarReporteAsistenciaResponse generarReporteAsistencia(LP2Soft.ReporteWS.generarReporteAsistenciaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2soft.pucp.edu.pe/ReporteWS/generarReporteAsistenciaRequest", ReplyAction="http://services.lp2soft.pucp.edu.pe/ReporteWS/generarReporteAsistenciaResponse")]
        System.Threading.Tasks.Task<LP2Soft.ReporteWS.generarReporteAsistenciaResponse> generarReporteAsistenciaAsync(LP2Soft.ReporteWS.generarReporteAsistenciaRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento arg0 del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2soft.pucp.edu.pe/ReporteWS/generarReportePlatosMasVendidosRequ" +
            "est", ReplyAction="http://services.lp2soft.pucp.edu.pe/ReporteWS/generarReportePlatosMasVendidosResp" +
            "onse")]
        LP2Soft.ReporteWS.generarReportePlatosMasVendidosResponse generarReportePlatosMasVendidos(LP2Soft.ReporteWS.generarReportePlatosMasVendidosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2soft.pucp.edu.pe/ReporteWS/generarReportePlatosMasVendidosRequ" +
            "est", ReplyAction="http://services.lp2soft.pucp.edu.pe/ReporteWS/generarReportePlatosMasVendidosResp" +
            "onse")]
        System.Threading.Tasks.Task<LP2Soft.ReporteWS.generarReportePlatosMasVendidosResponse> generarReportePlatosMasVendidosAsync(LP2Soft.ReporteWS.generarReportePlatosMasVendidosRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento arg1 del espacio de nombres  no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2soft.pucp.edu.pe/ReporteWS/generarBoletaVentaRequest", ReplyAction="http://services.lp2soft.pucp.edu.pe/ReporteWS/generarBoletaVentaResponse")]
        LP2Soft.ReporteWS.generarBoletaVentaResponse generarBoletaVenta(LP2Soft.ReporteWS.generarBoletaVentaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://services.lp2soft.pucp.edu.pe/ReporteWS/generarBoletaVentaRequest", ReplyAction="http://services.lp2soft.pucp.edu.pe/ReporteWS/generarBoletaVentaResponse")]
        System.Threading.Tasks.Task<LP2Soft.ReporteWS.generarBoletaVentaResponse> generarBoletaVentaAsync(LP2Soft.ReporteWS.generarBoletaVentaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class generarFacturaVentaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="generarFacturaVenta", Namespace="http://services.lp2soft.pucp.edu.pe/", Order=0)]
        public LP2Soft.ReporteWS.generarFacturaVentaRequestBody Body;
        
        public generarFacturaVentaRequest() {
        }
        
        public generarFacturaVentaRequest(LP2Soft.ReporteWS.generarFacturaVentaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class generarFacturaVentaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int arg0;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string arg1;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string arg2;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string arg3;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string arg4;
        
        public generarFacturaVentaRequestBody() {
        }
        
        public generarFacturaVentaRequestBody(int arg0, string arg1, string arg2, string arg3, string arg4) {
            this.arg0 = arg0;
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
            this.arg4 = arg4;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class generarFacturaVentaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="generarFacturaVentaResponse", Namespace="http://services.lp2soft.pucp.edu.pe/", Order=0)]
        public LP2Soft.ReporteWS.generarFacturaVentaResponseBody Body;
        
        public generarFacturaVentaResponse() {
        }
        
        public generarFacturaVentaResponse(LP2Soft.ReporteWS.generarFacturaVentaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class generarFacturaVentaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public byte[] @return;
        
        public generarFacturaVentaResponseBody() {
        }
        
        public generarFacturaVentaResponseBody(byte[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class generarReporteAsistenciaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="generarReporteAsistencia", Namespace="http://services.lp2soft.pucp.edu.pe/", Order=0)]
        public LP2Soft.ReporteWS.generarReporteAsistenciaRequestBody Body;
        
        public generarReporteAsistenciaRequest() {
        }
        
        public generarReporteAsistenciaRequest(LP2Soft.ReporteWS.generarReporteAsistenciaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class generarReporteAsistenciaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string arg0;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string arg1;
        
        public generarReporteAsistenciaRequestBody() {
        }
        
        public generarReporteAsistenciaRequestBody(string arg0, string arg1) {
            this.arg0 = arg0;
            this.arg1 = arg1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class generarReporteAsistenciaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="generarReporteAsistenciaResponse", Namespace="http://services.lp2soft.pucp.edu.pe/", Order=0)]
        public LP2Soft.ReporteWS.generarReporteAsistenciaResponseBody Body;
        
        public generarReporteAsistenciaResponse() {
        }
        
        public generarReporteAsistenciaResponse(LP2Soft.ReporteWS.generarReporteAsistenciaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class generarReporteAsistenciaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public byte[] @return;
        
        public generarReporteAsistenciaResponseBody() {
        }
        
        public generarReporteAsistenciaResponseBody(byte[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class generarReportePlatosMasVendidosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="generarReportePlatosMasVendidos", Namespace="http://services.lp2soft.pucp.edu.pe/", Order=0)]
        public LP2Soft.ReporteWS.generarReportePlatosMasVendidosRequestBody Body;
        
        public generarReportePlatosMasVendidosRequest() {
        }
        
        public generarReportePlatosMasVendidosRequest(LP2Soft.ReporteWS.generarReportePlatosMasVendidosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class generarReportePlatosMasVendidosRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string arg0;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string arg1;
        
        public generarReportePlatosMasVendidosRequestBody() {
        }
        
        public generarReportePlatosMasVendidosRequestBody(string arg0, string arg1) {
            this.arg0 = arg0;
            this.arg1 = arg1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class generarReportePlatosMasVendidosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="generarReportePlatosMasVendidosResponse", Namespace="http://services.lp2soft.pucp.edu.pe/", Order=0)]
        public LP2Soft.ReporteWS.generarReportePlatosMasVendidosResponseBody Body;
        
        public generarReportePlatosMasVendidosResponse() {
        }
        
        public generarReportePlatosMasVendidosResponse(LP2Soft.ReporteWS.generarReportePlatosMasVendidosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class generarReportePlatosMasVendidosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public byte[] @return;
        
        public generarReportePlatosMasVendidosResponseBody() {
        }
        
        public generarReportePlatosMasVendidosResponseBody(byte[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class generarBoletaVentaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="generarBoletaVenta", Namespace="http://services.lp2soft.pucp.edu.pe/", Order=0)]
        public LP2Soft.ReporteWS.generarBoletaVentaRequestBody Body;
        
        public generarBoletaVentaRequest() {
        }
        
        public generarBoletaVentaRequest(LP2Soft.ReporteWS.generarBoletaVentaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class generarBoletaVentaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int arg0;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string arg1;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string arg2;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string arg3;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string arg4;
        
        public generarBoletaVentaRequestBody() {
        }
        
        public generarBoletaVentaRequestBody(int arg0, string arg1, string arg2, string arg3, string arg4) {
            this.arg0 = arg0;
            this.arg1 = arg1;
            this.arg2 = arg2;
            this.arg3 = arg3;
            this.arg4 = arg4;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class generarBoletaVentaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="generarBoletaVentaResponse", Namespace="http://services.lp2soft.pucp.edu.pe/", Order=0)]
        public LP2Soft.ReporteWS.generarBoletaVentaResponseBody Body;
        
        public generarBoletaVentaResponse() {
        }
        
        public generarBoletaVentaResponse(LP2Soft.ReporteWS.generarBoletaVentaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class generarBoletaVentaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public byte[] @return;
        
        public generarBoletaVentaResponseBody() {
        }
        
        public generarBoletaVentaResponseBody(byte[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ReporteWSChannel : LP2Soft.ReporteWS.ReporteWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReporteWSClient : System.ServiceModel.ClientBase<LP2Soft.ReporteWS.ReporteWS>, LP2Soft.ReporteWS.ReporteWS {
        
        public ReporteWSClient() {
        }
        
        public ReporteWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReporteWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReporteWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReporteWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2Soft.ReporteWS.generarFacturaVentaResponse LP2Soft.ReporteWS.ReporteWS.generarFacturaVenta(LP2Soft.ReporteWS.generarFacturaVentaRequest request) {
            return base.Channel.generarFacturaVenta(request);
        }
        
        public byte[] generarFacturaVenta(int arg0, string arg1, string arg2, string arg3, string arg4) {
            LP2Soft.ReporteWS.generarFacturaVentaRequest inValue = new LP2Soft.ReporteWS.generarFacturaVentaRequest();
            inValue.Body = new LP2Soft.ReporteWS.generarFacturaVentaRequestBody();
            inValue.Body.arg0 = arg0;
            inValue.Body.arg1 = arg1;
            inValue.Body.arg2 = arg2;
            inValue.Body.arg3 = arg3;
            inValue.Body.arg4 = arg4;
            LP2Soft.ReporteWS.generarFacturaVentaResponse retVal = ((LP2Soft.ReporteWS.ReporteWS)(this)).generarFacturaVenta(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2Soft.ReporteWS.generarFacturaVentaResponse> LP2Soft.ReporteWS.ReporteWS.generarFacturaVentaAsync(LP2Soft.ReporteWS.generarFacturaVentaRequest request) {
            return base.Channel.generarFacturaVentaAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2Soft.ReporteWS.generarFacturaVentaResponse> generarFacturaVentaAsync(int arg0, string arg1, string arg2, string arg3, string arg4) {
            LP2Soft.ReporteWS.generarFacturaVentaRequest inValue = new LP2Soft.ReporteWS.generarFacturaVentaRequest();
            inValue.Body = new LP2Soft.ReporteWS.generarFacturaVentaRequestBody();
            inValue.Body.arg0 = arg0;
            inValue.Body.arg1 = arg1;
            inValue.Body.arg2 = arg2;
            inValue.Body.arg3 = arg3;
            inValue.Body.arg4 = arg4;
            return ((LP2Soft.ReporteWS.ReporteWS)(this)).generarFacturaVentaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2Soft.ReporteWS.generarReporteAsistenciaResponse LP2Soft.ReporteWS.ReporteWS.generarReporteAsistencia(LP2Soft.ReporteWS.generarReporteAsistenciaRequest request) {
            return base.Channel.generarReporteAsistencia(request);
        }
        
        public byte[] generarReporteAsistencia(string arg0, string arg1) {
            LP2Soft.ReporteWS.generarReporteAsistenciaRequest inValue = new LP2Soft.ReporteWS.generarReporteAsistenciaRequest();
            inValue.Body = new LP2Soft.ReporteWS.generarReporteAsistenciaRequestBody();
            inValue.Body.arg0 = arg0;
            inValue.Body.arg1 = arg1;
            LP2Soft.ReporteWS.generarReporteAsistenciaResponse retVal = ((LP2Soft.ReporteWS.ReporteWS)(this)).generarReporteAsistencia(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2Soft.ReporteWS.generarReporteAsistenciaResponse> LP2Soft.ReporteWS.ReporteWS.generarReporteAsistenciaAsync(LP2Soft.ReporteWS.generarReporteAsistenciaRequest request) {
            return base.Channel.generarReporteAsistenciaAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2Soft.ReporteWS.generarReporteAsistenciaResponse> generarReporteAsistenciaAsync(string arg0, string arg1) {
            LP2Soft.ReporteWS.generarReporteAsistenciaRequest inValue = new LP2Soft.ReporteWS.generarReporteAsistenciaRequest();
            inValue.Body = new LP2Soft.ReporteWS.generarReporteAsistenciaRequestBody();
            inValue.Body.arg0 = arg0;
            inValue.Body.arg1 = arg1;
            return ((LP2Soft.ReporteWS.ReporteWS)(this)).generarReporteAsistenciaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2Soft.ReporteWS.generarReportePlatosMasVendidosResponse LP2Soft.ReporteWS.ReporteWS.generarReportePlatosMasVendidos(LP2Soft.ReporteWS.generarReportePlatosMasVendidosRequest request) {
            return base.Channel.generarReportePlatosMasVendidos(request);
        }
        
        public byte[] generarReportePlatosMasVendidos(string arg0, string arg1) {
            LP2Soft.ReporteWS.generarReportePlatosMasVendidosRequest inValue = new LP2Soft.ReporteWS.generarReportePlatosMasVendidosRequest();
            inValue.Body = new LP2Soft.ReporteWS.generarReportePlatosMasVendidosRequestBody();
            inValue.Body.arg0 = arg0;
            inValue.Body.arg1 = arg1;
            LP2Soft.ReporteWS.generarReportePlatosMasVendidosResponse retVal = ((LP2Soft.ReporteWS.ReporteWS)(this)).generarReportePlatosMasVendidos(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2Soft.ReporteWS.generarReportePlatosMasVendidosResponse> LP2Soft.ReporteWS.ReporteWS.generarReportePlatosMasVendidosAsync(LP2Soft.ReporteWS.generarReportePlatosMasVendidosRequest request) {
            return base.Channel.generarReportePlatosMasVendidosAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2Soft.ReporteWS.generarReportePlatosMasVendidosResponse> generarReportePlatosMasVendidosAsync(string arg0, string arg1) {
            LP2Soft.ReporteWS.generarReportePlatosMasVendidosRequest inValue = new LP2Soft.ReporteWS.generarReportePlatosMasVendidosRequest();
            inValue.Body = new LP2Soft.ReporteWS.generarReportePlatosMasVendidosRequestBody();
            inValue.Body.arg0 = arg0;
            inValue.Body.arg1 = arg1;
            return ((LP2Soft.ReporteWS.ReporteWS)(this)).generarReportePlatosMasVendidosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LP2Soft.ReporteWS.generarBoletaVentaResponse LP2Soft.ReporteWS.ReporteWS.generarBoletaVenta(LP2Soft.ReporteWS.generarBoletaVentaRequest request) {
            return base.Channel.generarBoletaVenta(request);
        }
        
        public byte[] generarBoletaVenta(int arg0, string arg1, string arg2, string arg3, string arg4) {
            LP2Soft.ReporteWS.generarBoletaVentaRequest inValue = new LP2Soft.ReporteWS.generarBoletaVentaRequest();
            inValue.Body = new LP2Soft.ReporteWS.generarBoletaVentaRequestBody();
            inValue.Body.arg0 = arg0;
            inValue.Body.arg1 = arg1;
            inValue.Body.arg2 = arg2;
            inValue.Body.arg3 = arg3;
            inValue.Body.arg4 = arg4;
            LP2Soft.ReporteWS.generarBoletaVentaResponse retVal = ((LP2Soft.ReporteWS.ReporteWS)(this)).generarBoletaVenta(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LP2Soft.ReporteWS.generarBoletaVentaResponse> LP2Soft.ReporteWS.ReporteWS.generarBoletaVentaAsync(LP2Soft.ReporteWS.generarBoletaVentaRequest request) {
            return base.Channel.generarBoletaVentaAsync(request);
        }
        
        public System.Threading.Tasks.Task<LP2Soft.ReporteWS.generarBoletaVentaResponse> generarBoletaVentaAsync(int arg0, string arg1, string arg2, string arg3, string arg4) {
            LP2Soft.ReporteWS.generarBoletaVentaRequest inValue = new LP2Soft.ReporteWS.generarBoletaVentaRequest();
            inValue.Body = new LP2Soft.ReporteWS.generarBoletaVentaRequestBody();
            inValue.Body.arg0 = arg0;
            inValue.Body.arg1 = arg1;
            inValue.Body.arg2 = arg2;
            inValue.Body.arg3 = arg3;
            inValue.Body.arg4 = arg4;
            return ((LP2Soft.ReporteWS.ReporteWS)(this)).generarBoletaVentaAsync(inValue);
        }
    }
}