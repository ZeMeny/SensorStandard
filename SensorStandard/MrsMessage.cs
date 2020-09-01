using SensorStandard.MrsTypes;
using SensorStandard.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SensorStandard
{
    public abstract class MrsMessage
    {
        [XmlIgnore]
        public MrsMessageTypes MrsMessageType { get; protected set; }

        public static T Load<T>(string xml) where T: MrsMessage
        {
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                var reader = new StringReader(xml);

                return (T)serializer.Deserialize(reader);
            }
            catch
            {
                return default;
            }
		}

        public bool IsValid(out Exception exception)
        {
            try
            {
                bool isValid = true;
                Exception error = null;

                XmlReaderSettings settings = new XmlReaderSettings
                {
                    ValidationType = ValidationType.Schema,
                    CloseInput = true
                };

                // add basic types schema
                settings.Schemas = new XmlSchemaSet();
                var reader = new StringReader(Resources.BasicTypes);
                settings.Schemas.Add("urn:SNSR_STD", XmlReader.Create(reader));
                reader.Dispose();

                // add command message schema
                reader = new StringReader(Resources.ControlMessage);
                settings.Schemas.Add("urn:SNSR_STD", XmlReader.Create(reader));
                reader.Dispose();

                // add indication schema
                reader = new StringReader(Resources.SensorIndicationReport);
                settings.Schemas.Add("urn:SNSR_STD", XmlReader.Create(reader));
                reader.Dispose();

                // add status schema
                reader = new StringReader(Resources.SensorStatusReport);
                settings.Schemas.Add("urn:SNSR_STD", XmlReader.Create(reader));
                reader.Dispose();

                // add configuration schema
                reader = new StringReader(Resources.SensorConfiguration);
                settings.Schemas.Add("urn:SNSR_STD", XmlReader.Create(reader));
                reader.Dispose();

                // add subscription schema
                reader = new StringReader(Resources.SubscriptionConfiguration);
                settings.Schemas.Add("urn:SNSR_STD", XmlReader.Create(reader));
                reader.Dispose();

                XmlDocument asset = new XmlDocument();
                reader = new StringReader(this.ToXml());
                asset.Load(XmlReader.Create(reader, settings));
                reader.Dispose();

                asset.Validate((sender, args) =>
                {
                    if (args.Severity == XmlSeverityType.Warning)
                    {
                        Console.WriteLine("Warning: Matching schema not found. No validation occurred.\n" + args.Message);
                    }
                    //else
                    //{
                    //    Console.WriteLine("\tValidation error: " + args.Message);
                    //}
                    error = args.Exception;
                    isValid = false;
                });
                exception = error;

                return isValid;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }
    }
}
