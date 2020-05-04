using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorStandard.MrsTypes;

namespace SensorStandard
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "urn:SNSR_STD", ConfigurationName = "SNSR_STDSOAPPort")]
    public interface SNSR_STDSOAPPort
    {
		/// <remarks/>
		// CODEGEN: Generating message contract since the operation doDeviceConfiguration is neither RPC nor document wrapped.
		[System.ServiceModel.OperationContractAttribute(Action = "doDeviceConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AreaMeasuringType))]
        doDeviceConfigurationResponse doDeviceConfiguration(doDeviceConfigurationRequest request);

		/// <remarks/>
		[System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "doDeviceConfiguration", ReplyAction = "*")]
        System.IAsyncResult BegindoDeviceConfiguration(doDeviceConfigurationRequest request, System.AsyncCallback callback, object asyncState);

		/// <remarks/>
		doDeviceConfigurationResponse EnddoDeviceConfiguration(System.IAsyncResult result);

		/// <remarks/>
		// CODEGEN: Generating message contract since the operation doDeviceSubscriptionConfiguration is neither RPC nor document wrapped.
		[System.ServiceModel.OperationContractAttribute(Action = "doDeviceSubscriptionConfiguration", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AreaMeasuringType))]
        doDeviceSubscriptionConfigurationResponse doDeviceSubscriptionConfiguration(doDeviceSubscriptionConfigurationRequest request);

		/// <remarks/>
		[System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "doDeviceSubscriptionConfiguration", ReplyAction = "*")]
        System.IAsyncResult BegindoDeviceSubscriptionConfiguration(doDeviceSubscriptionConfigurationRequest request, System.AsyncCallback callback, object asyncState);

		/// <remarks/>
		doDeviceSubscriptionConfigurationResponse EnddoDeviceSubscriptionConfiguration(System.IAsyncResult result);

		/// <remarks/>
		// CODEGEN: Generating message contract since the operation doCommandMessage is neither RPC nor document wrapped.
		[System.ServiceModel.OperationContractAttribute(Action = "doCommandMessage", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AreaMeasuringType))]
        doCommandMessageResponse doCommandMessage(doCommandMessageRequest request);

		/// <remarks/>
		[System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "doCommandMessage", ReplyAction = "*")]
        System.IAsyncResult BegindoCommandMessage(doCommandMessageRequest request, System.AsyncCallback callback, object asyncState);

		/// <remarks/>
		doCommandMessageResponse EnddoCommandMessage(System.IAsyncResult result);

		/// <remarks/>
		// CODEGEN: Generating message contract since the operation doDeviceStatusReport is neither RPC nor document wrapped.
		[System.ServiceModel.OperationContractAttribute(Action = "doDeviceStatusReport", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AreaMeasuringType))]
        doCommandMessageResponse doDeviceStatusReport(doDeviceStatusReportRequest request);

		/// <remarks/>
		[System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "doDeviceStatusReport", ReplyAction = "*")]
        System.IAsyncResult BegindoDeviceStatusReport(doDeviceStatusReportRequest request, System.AsyncCallback callback, object asyncState);

		/// <remarks/>
		doCommandMessageResponse EnddoDeviceStatusReport(System.IAsyncResult result);

		/// <remarks/>
		// CODEGEN: Generating message contract since the operation doDeviceIndicationReport is neither RPC nor document wrapped.
		[System.ServiceModel.OperationContractAttribute(Action = "doDeviceIndicationReport", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AreaMeasuringType))]
        doCommandMessageResponse doDeviceIndicationReport(doDeviceIndicationReportRequest request);

		/// <remarks/>
		[System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "doDeviceIndicationReport", ReplyAction = "*")]
        System.IAsyncResult BegindoDeviceIndicationReport(doDeviceIndicationReportRequest request, System.AsyncCallback callback, object asyncState);

		/// <remarks/>
		doCommandMessageResponse EnddoDeviceIndicationReport(System.IAsyncResult result);
    }

	/// <remarks/>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class doDeviceIndicationReportRequest
    {

		/// <remarks/>
		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:SNSR_STD", Order = 0)]
        public DeviceIndicationReport DeviceIndicationReport;

		/// <remarks/>
		public doDeviceIndicationReportRequest()
        {
        }

		/// <remarks/>
		public doDeviceIndicationReportRequest(DeviceIndicationReport DeviceIndicationReport)
        {
            this.DeviceIndicationReport = DeviceIndicationReport;
        }
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
	public partial class doCommandMessageRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:SNSR_STD", Order = 0)]
		public CommandMessage CommandMessage;

		public doCommandMessageRequest()
		{
		}

		public doCommandMessageRequest(CommandMessage CommandMessage)
		{
			this.CommandMessage = CommandMessage;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
	public partial class doCommandMessageResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:SNSR_STD", Order = 0)]
		public DeviceStatusReport DeviceStatusReport;

		public doCommandMessageResponse()
		{
		}

		public doCommandMessageResponse(DeviceStatusReport DeviceStatusReport)
		{
			this.DeviceStatusReport = DeviceStatusReport;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
	public partial class doDeviceStatusReportRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:SNSR_STD", Order = 0)]
		public DeviceStatusReport DeviceStatusReport;

		public doDeviceStatusReportRequest()
		{
		}

		public doDeviceStatusReportRequest(DeviceStatusReport DeviceStatusReport)
		{
			this.DeviceStatusReport = DeviceStatusReport;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
	public partial class doDeviceConfigurationRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:SNSR_STD", Order = 0)]
		public DeviceConfiguration DeviceConfiguration;

		public doDeviceConfigurationRequest()
		{
		}

		public doDeviceConfigurationRequest(DeviceConfiguration DeviceConfiguration)
		{
			this.DeviceConfiguration = DeviceConfiguration;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
	public partial class doDeviceConfigurationResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:SNSR_STD", Order = 0)]
		public DeviceConfiguration DeviceConfiguration;

		public doDeviceConfigurationResponse()
		{
		}

		public doDeviceConfigurationResponse(DeviceConfiguration DeviceConfiguration)
		{
			this.DeviceConfiguration = DeviceConfiguration;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
	public partial class doDeviceSubscriptionConfigurationRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:SNSR_STD", Order = 0)]
		public DeviceSubscriptionConfiguration DeviceSubscriptionConfiguration;

		public doDeviceSubscriptionConfigurationRequest()
		{
		}

		public doDeviceSubscriptionConfigurationRequest(DeviceSubscriptionConfiguration DeviceSubscriptionConfiguration)
		{
			this.DeviceSubscriptionConfiguration = DeviceSubscriptionConfiguration;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
	public partial class doDeviceSubscriptionConfigurationResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "urn:SNSR_STD", Order = 0)]
		public DeviceSubscriptionConfiguration DeviceSubscriptionConfiguration;

		public doDeviceSubscriptionConfigurationResponse()
		{
		}

		public doDeviceSubscriptionConfigurationResponse(DeviceSubscriptionConfiguration DeviceSubscriptionConfiguration)
		{
			this.DeviceSubscriptionConfiguration = DeviceSubscriptionConfiguration;
		}
	}


	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SNSR_STDSOAPPortChannel : SNSR_STDSOAPPort, System.ServiceModel.IClientChannel
    {
    }

	/// <remarks/>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SNSR_STDSOAPPortClient : System.ServiceModel.ClientBase<SNSR_STDSOAPPort>, SNSR_STDSOAPPort
	{

		/// <remarks/>
		public SNSR_STDSOAPPortClient()
		{
		}

		/// <remarks/>
		public SNSR_STDSOAPPortClient(string endpointConfigurationName) :
			base(endpointConfigurationName)
		{
		}

		/// <remarks/>
		public SNSR_STDSOAPPortClient(string endpointConfigurationName, string remoteAddress) :
			base(endpointConfigurationName, remoteAddress)
		{
		}

		/// <remarks/>
		public SNSR_STDSOAPPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
			base(endpointConfigurationName, remoteAddress)
		{
		}

		/// <remarks/>
		public SNSR_STDSOAPPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
			base(binding, remoteAddress)
		{
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		doDeviceConfigurationResponse SNSR_STDSOAPPort.doDeviceConfiguration(doDeviceConfigurationRequest request)
		{
			return base.Channel.doDeviceConfiguration(request);
		}

		/// <remarks/>
		public void doDeviceConfiguration(ref DeviceConfiguration DeviceConfiguration)
		{
			doDeviceConfigurationRequest inValue = new doDeviceConfigurationRequest();
			inValue.DeviceConfiguration = DeviceConfiguration;
			doDeviceConfigurationResponse retVal = ((SNSR_STDSOAPPort)(this)).doDeviceConfiguration(inValue);
			DeviceConfiguration = retVal.DeviceConfiguration;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.IAsyncResult SNSR_STDSOAPPort.BegindoDeviceConfiguration(doDeviceConfigurationRequest request, System.AsyncCallback callback, object asyncState)
		{
			return base.Channel.BegindoDeviceConfiguration(request, callback, asyncState);
		}

		/// <remarks/>
		public System.IAsyncResult BegindoDeviceConfiguration(DeviceConfiguration DeviceConfiguration, System.AsyncCallback callback, object asyncState)
		{
			doDeviceConfigurationRequest inValue = new doDeviceConfigurationRequest();
			inValue.DeviceConfiguration = DeviceConfiguration;
			return ((SNSR_STDSOAPPort)(this)).BegindoDeviceConfiguration(inValue, callback, asyncState);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		doDeviceConfigurationResponse SNSR_STDSOAPPort.EnddoDeviceConfiguration(System.IAsyncResult result)
		{
			return base.Channel.EnddoDeviceConfiguration(result);
		}

		/// <remarks/>
		public DeviceConfiguration EnddoDeviceConfiguration(System.IAsyncResult result)
		{
			doDeviceConfigurationResponse retVal = ((SNSR_STDSOAPPort)(this)).EnddoDeviceConfiguration(result);
			return retVal.DeviceConfiguration;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		doDeviceSubscriptionConfigurationResponse SNSR_STDSOAPPort.doDeviceSubscriptionConfiguration(doDeviceSubscriptionConfigurationRequest request)
		{
			return base.Channel.doDeviceSubscriptionConfiguration(request);
		}

		/// <remarks/>
		public void doDeviceSubscriptionConfiguration(ref DeviceSubscriptionConfiguration DeviceSubscriptionConfiguration)
		{
			doDeviceSubscriptionConfigurationRequest inValue = new doDeviceSubscriptionConfigurationRequest();
			inValue.DeviceSubscriptionConfiguration = DeviceSubscriptionConfiguration;
			doDeviceSubscriptionConfigurationResponse retVal = ((SNSR_STDSOAPPort)(this)).doDeviceSubscriptionConfiguration(inValue);
			DeviceSubscriptionConfiguration = retVal.DeviceSubscriptionConfiguration;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.IAsyncResult SNSR_STDSOAPPort.BegindoDeviceSubscriptionConfiguration(doDeviceSubscriptionConfigurationRequest request, System.AsyncCallback callback, object asyncState)
		{
			return base.Channel.BegindoDeviceSubscriptionConfiguration(request, callback, asyncState);
		}

		/// <remarks/>
		public System.IAsyncResult BegindoDeviceSubscriptionConfiguration(DeviceSubscriptionConfiguration DeviceSubscriptionConfiguration, System.AsyncCallback callback, object asyncState)
		{
			doDeviceSubscriptionConfigurationRequest inValue = new doDeviceSubscriptionConfigurationRequest();
			inValue.DeviceSubscriptionConfiguration = DeviceSubscriptionConfiguration;
			return ((SNSR_STDSOAPPort)(this)).BegindoDeviceSubscriptionConfiguration(inValue, callback, asyncState);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		doDeviceSubscriptionConfigurationResponse SNSR_STDSOAPPort.EnddoDeviceSubscriptionConfiguration(System.IAsyncResult result)
		{
			return base.Channel.EnddoDeviceSubscriptionConfiguration(result);
		}

		/// <remarks/>
		public DeviceSubscriptionConfiguration EnddoDeviceSubscriptionConfiguration(System.IAsyncResult result)
		{
			doDeviceSubscriptionConfigurationResponse retVal = ((SNSR_STDSOAPPort)(this)).EnddoDeviceSubscriptionConfiguration(result);
			return retVal.DeviceSubscriptionConfiguration;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		doCommandMessageResponse SNSR_STDSOAPPort.doCommandMessage(doCommandMessageRequest request)
		{
			return base.Channel.doCommandMessage(request);
		}

		/// <remarks/>
		public DeviceStatusReport doCommandMessage(CommandMessage CommandMessage)
		{
			doCommandMessageRequest inValue = new doCommandMessageRequest();
			inValue.CommandMessage = CommandMessage;
			doCommandMessageResponse retVal = ((SNSR_STDSOAPPort)(this)).doCommandMessage(inValue);
			return retVal.DeviceStatusReport;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.IAsyncResult SNSR_STDSOAPPort.BegindoCommandMessage(doCommandMessageRequest request, System.AsyncCallback callback, object asyncState)
		{
			return base.Channel.BegindoCommandMessage(request, callback, asyncState);
		}

		/// <remarks/>
		public System.IAsyncResult BegindoCommandMessage(CommandMessage CommandMessage, System.AsyncCallback callback, object asyncState)
		{
			doCommandMessageRequest inValue = new doCommandMessageRequest();
			inValue.CommandMessage = CommandMessage;
			return ((SNSR_STDSOAPPort)(this)).BegindoCommandMessage(inValue, callback, asyncState);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		doCommandMessageResponse SNSR_STDSOAPPort.EnddoCommandMessage(System.IAsyncResult result)
		{
			return base.Channel.EnddoCommandMessage(result);
		}

		/// <remarks/>
		public DeviceStatusReport EnddoCommandMessage(System.IAsyncResult result)
		{
			doCommandMessageResponse retVal = ((SNSR_STDSOAPPort)(this)).EnddoCommandMessage(result);
			return retVal.DeviceStatusReport;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		doCommandMessageResponse SNSR_STDSOAPPort.doDeviceStatusReport(doDeviceStatusReportRequest request)
		{
			return base.Channel.doDeviceStatusReport(request);
		}

		/// <remarks/>
		public void doDeviceStatusReport(ref DeviceStatusReport DeviceStatusReport)
		{
			doDeviceStatusReportRequest inValue = new doDeviceStatusReportRequest();
			inValue.DeviceStatusReport = DeviceStatusReport;
			doCommandMessageResponse retVal = ((SNSR_STDSOAPPort)(this)).doDeviceStatusReport(inValue);
			DeviceStatusReport = retVal.DeviceStatusReport;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.IAsyncResult SNSR_STDSOAPPort.BegindoDeviceStatusReport(doDeviceStatusReportRequest request, System.AsyncCallback callback, object asyncState)
		{
			return base.Channel.BegindoDeviceStatusReport(request, callback, asyncState);
		}

		/// <remarks/>
		public System.IAsyncResult BegindoDeviceStatusReport(DeviceStatusReport DeviceStatusReport, System.AsyncCallback callback, object asyncState)
		{
			doDeviceStatusReportRequest inValue = new doDeviceStatusReportRequest();
			inValue.DeviceStatusReport = DeviceStatusReport;
			return ((SNSR_STDSOAPPort)(this)).BegindoDeviceStatusReport(inValue, callback, asyncState);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		doCommandMessageResponse SNSR_STDSOAPPort.EnddoDeviceStatusReport(System.IAsyncResult result)
		{
			return base.Channel.EnddoDeviceStatusReport(result);
		}

		/// <remarks/>
		public DeviceStatusReport EnddoDeviceStatusReport(System.IAsyncResult result)
		{
			doCommandMessageResponse retVal = ((SNSR_STDSOAPPort)(this)).EnddoDeviceStatusReport(result);
			return retVal.DeviceStatusReport;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		doCommandMessageResponse SNSR_STDSOAPPort.doDeviceIndicationReport(doDeviceIndicationReportRequest request)
		{
			return base.Channel.doDeviceIndicationReport(request);
		}

		/// <remarks/>
		public DeviceStatusReport doDeviceIndicationReport(DeviceIndicationReport DeviceIndicationReport)
		{
			doDeviceIndicationReportRequest inValue = new doDeviceIndicationReportRequest();
			inValue.DeviceIndicationReport = DeviceIndicationReport;
			doCommandMessageResponse retVal = ((SNSR_STDSOAPPort)(this)).doDeviceIndicationReport(inValue);
			return retVal.DeviceStatusReport;
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		System.IAsyncResult SNSR_STDSOAPPort.BegindoDeviceIndicationReport(doDeviceIndicationReportRequest request, System.AsyncCallback callback, object asyncState)
		{
			return base.Channel.BegindoDeviceIndicationReport(request, callback, asyncState);
		}

		/// <remarks/>
		public System.IAsyncResult BegindoDeviceIndicationReport(DeviceIndicationReport DeviceIndicationReport, System.AsyncCallback callback, object asyncState)
		{
			doDeviceIndicationReportRequest inValue = new doDeviceIndicationReportRequest();
			inValue.DeviceIndicationReport = DeviceIndicationReport;
			return ((SNSR_STDSOAPPort)(this)).BegindoDeviceIndicationReport(inValue, callback, asyncState);
		}

		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
		doCommandMessageResponse SNSR_STDSOAPPort.EnddoDeviceIndicationReport(System.IAsyncResult result)
		{
			return base.Channel.EnddoDeviceIndicationReport(result);
		}

		/// <remarks/>
		public DeviceStatusReport EnddoDeviceIndicationReport(System.IAsyncResult result)
		{
			doCommandMessageResponse retVal = ((SNSR_STDSOAPPort)(this)).EnddoDeviceIndicationReport(result);
			return retVal.DeviceStatusReport;
		}
	}
}
