using SensorStandard.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SensorStandard
{
	public static class Extensions
	{
		//private static bool isValid = true;
		//private static Exception error;

		//public static bool IsValid<T>(this T message, out Exception exception) where T: MrsMessage
		//{
  //          try
  //          {
  //              isValid = true;
  //              XmlDocument asset = new XmlDocument();

  //              // add basic types schema
  //              TextReader reader = new StringReader(Resources.BasicTypes);
  //              XmlTextReader schemaReader = new XmlTextReader(reader);
  //              XmlSchema schema = XmlSchema.Read(schemaReader, ValidationCallBack);
  //              asset.Schemas.Add(schema);
		//		reader.Dispose();
		//		schemaReader.Dispose();

		//		// add command message schema
		//		var reader1 = new StringReader(Resources.ControlMessage);
		//		var schemaReader1 = new XmlTextReader(reader1);
  //              var schema1 = XmlSchema.Read(schemaReader1, ValidationCallBack);
  //              asset.Schemas.Add(schema1);
		//		reader1.Dispose();
		//		schemaReader1.Dispose();

		//		// add indication schema
		//		var reader2 = new StringReader(Resources.SensorIndicationReport);
  //              var schemaReader2 = new XmlTextReader(reader2);
  //              var schema2 = XmlSchema.Read(schemaReader2, ValidationCallBack);
  //              asset.Schemas.Add(schema2);
		//		reader2.Dispose();
		//		schemaReader2.Dispose();

		//		// add status schema
		//		var reader3 = new StringReader(Resources.SensorStatusReport);
		//		var schemaReader3 = new XmlTextReader(reader3);
		//		var schema3 = XmlSchema.Read(schemaReader3, ValidationCallBack);
  //              asset.Schemas.Add(schema3);
		//		reader3.Dispose();
		//		schemaReader3.Dispose();

		//		// add configuration schema
		//		var reader4 = new StringReader(Resources.SensorConfiguration);
		//		var schemaReader4 = new XmlTextReader(reader4);
		//		var schema4 = XmlSchema.Read(schemaReader4, ValidationCallBack);
  //              asset.Schemas.Add(schema4);
		//		reader4.Dispose();
		//		schemaReader4.Dispose();

		//		// add subscription schema
		//		var reader5 = new StringReader(Resources.SubscriptionConfiguration);
		//		var schemaReader5 = new XmlTextReader(reader5);
		//		var schema5 = XmlSchema.Read(schemaReader5, ValidationCallBack);
  //              asset.Schemas.Add(schema5);
		//		reader5.Dispose();
		//		schemaReader5.Dispose();

		//		asset.Load(new StringReader(message.ToXml()));

  //              asset.Validate(ValidationCallBack);
  //              exception = error;

		//		return isValid;
  //          }
  //          catch (Exception ex)
  //          {
	 //           exception = ex;
	 //           return false;
  //          }
		//}

		//public static string ToXml<T>(this T message, 
		//	XmlAttributeOverrides overrides = null, 
		//	Type[] extraTypes = null, 
		//	XmlRootAttribute root = null, 
		//	string defaultNamespace = null) where T : MrsMessage
		//{
		//	var serializer = new XmlSerializer(message.GetType(), overrides, extraTypes, root, defaultNamespace);
		//	var writer = new StringWriter();
		//	serializer.Serialize(writer, message);

		//	return writer.ToString();
		//}

		//public static string ToJson<T>(this T obj) where T : MrsMessage
		//{
		//	return JsonConvert.SerializeObject(obj, Formatting.Indented);
		//}

		//public static bool ValidateJson<T>(this T json, out Exception exception) where T : MrsMessage
		//{
		//	JSchema schema = JSchema.Load(new JsonTextReader(new StringReader(Resources.BasicTypes_json)));
		//	switch (json.MrsMessageType)
		//	{
		//		case MrsMessageTypes.DeviceConfiguration:
		//			schema = JSchema.Load(new JsonTextReader(new StringReader(Resources.SensorConfiguration_json)));
		//			break;
		//		case MrsMessageTypes.DeviceStatusReport:
		//			schema = JSchema.Load(new JsonTextReader(new StringReader(Resources.SensorStatusReport_json)));
		//			break;
		//		case MrsMessageTypes.DeviceSubscriptionConfiguration:
		//			schema = JSchema.Load(new JsonTextReader(new StringReader(Resources.SubscriptionConfiguration_json)));
		//			break;
		//		case MrsMessageTypes.DeviceIndicationReport:
		//			schema = JSchema.Load(new JsonTextReader(new StringReader(Resources.SensorIndicationReport_json)));
		//			break;
		//		case MrsMessageTypes.CommandMessage:
		//			schema = JSchema.Load(new JsonTextReader(new StringReader(Resources.ControlMessage_json)));
		//			break;
		//	}

		//	JObject message = JObject.FromObject(json);
		//	var value = message.IsValid(schema, out IList<ValidationError> errors);
		//	exception = new Exception(string.Join("\n", errors.Select(e => e.Message)));
		//	return value;
		//}

		//private static void ValidationCallBack(object sender, ValidationEventArgs args)
		//{
		//	if (args.Severity == XmlSeverityType.Warning)
		//	{
		//		Console.WriteLine("\tWarning: Matching schema not found. No validation occurred." + args.Message);
		//	}
		//	//else
		//	//{
		//	//    Console.WriteLine("\tValidation error: " + args.Message);
		//	//}
		//	error = args.Exception;
		//	isValid = false;
		//}
	}
}
