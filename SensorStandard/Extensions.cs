using SensorStandard.Properties;
using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using SensorStandard.MrsTypes;

namespace SensorStandard
{
	public static class Extensions
	{
		private static bool isValid = true;
		private static Exception error;

		public static bool IsValid<T>(this T message, out Exception exception) where T: MrsMessage
		{
			isValid = true;
			XmlDocument asset = new XmlDocument();

			// add configuration schema
			TextReader reader = new StringReader(Resources.SensorConfiguration);
			XmlTextReader schemaReader = new XmlTextReader(reader);
			XmlSchema schema = XmlSchema.Read(schemaReader, ValidationCallBack);
			asset.Schemas.Add(schema);

			// add basic types schema
			reader = new StringReader(Resources.BasicTypes);
			schemaReader = new XmlTextReader(reader);
			schema = XmlSchema.Read(schemaReader, ValidationCallBack);
			asset.Schemas.Add(schema);

			// add command message schema
			reader = new StringReader(Resources.ControlMessage);
			schemaReader = new XmlTextReader(reader);
			schema = XmlSchema.Read(schemaReader, ValidationCallBack);
			asset.Schemas.Add(schema);

			// add subscription schema
			reader = new StringReader(Resources.SubscriptionConfiguration);
			schemaReader = new XmlTextReader(reader);
			schema = XmlSchema.Read(schemaReader, ValidationCallBack);
			asset.Schemas.Add(schema);

			// add indication schema
			reader = new StringReader(Resources.SensorIndicationReport);
			schemaReader = new XmlTextReader(reader);
			schema = XmlSchema.Read(schemaReader, ValidationCallBack);
			asset.Schemas.Add(schema);

			// add status schema
			reader = new StringReader(Resources.SensorStatusReport);
			schemaReader = new XmlTextReader(reader);
			schema = XmlSchema.Read(schemaReader, ValidationCallBack);
			asset.Schemas.Add(schema);

			asset.Load(new StringReader(message.ToXml()));
			
			asset.Validate(ValidationCallBack);
			exception = error;
			return isValid;
		}

		public static string ToXml<T>(this T message) where T : MrsMessage
		{
			var serializer = new XmlSerializer(message.GetType());
			var writer = new StringWriter();
			serializer.Serialize(writer, message);

			return writer.ToString();
		}

		private static void ValidationCallBack(object sender, ValidationEventArgs args)
		{
			if (args.Severity == XmlSeverityType.Warning)
			{
				Console.WriteLine("\tWarning: Matching schema not found. No validation occurred." + args.Message);
			}
			//else
			//{
			//    Console.WriteLine("\tValidation error: " + args.Message);
			//}
			error = args.Exception;
			isValid = false;
		}
	}
}
