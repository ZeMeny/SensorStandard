using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
