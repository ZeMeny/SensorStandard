using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SensorStandard
{
    public static class Exensions
    {
        public static string ToXml<T>(this T obj, XmlAttributeOverrides overrides = null,
            Type[] extraTypes = null) where T : MrsMessage
        {
            return XmlSerializerCache.Serialize(obj, extraTypes, overrides);
        }
    }
}
