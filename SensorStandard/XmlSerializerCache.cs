using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace SensorStandard
{
    public static class XmlSerializerCache
    {
        private static readonly object _syncToken = new object();
        private static readonly Dictionary<string, XmlSerializer> XmlSerializerCacheForUtils = new Dictionary<string, XmlSerializer>();

        public static XmlSerializer GetSerializer<T>()
        {
            return GetSerializer<T>(null);
        }

        public static XmlSerializer GetSerializer<T>(Type[] extraTypes, XmlAttributeOverrides overrides = null)
        {
            return GetSerializer(typeof(T), extraTypes, overrides);
        }

        public static XmlSerializer GetSerializer(Type mainType)
        {
            return GetSerializer(mainType, null);
        }

        public static XmlSerializer GetSerializer(Type mainType, Type[] extraTypes, XmlAttributeOverrides overrides = null)
        {
            string signature = mainType.FullName;
            if (extraTypes != null)
            {
                foreach (var type in extraTypes)
                {
                    signature += "-" + type.FullName;
                }
            }

            XmlSerializer xmlEventSerializer;
            if (XmlSerializerCacheForUtils.ContainsKey(signature))
            {
                xmlEventSerializer = XmlSerializerCacheForUtils[signature];
            }
            else
            {
                if (extraTypes == null)
                {
                    xmlEventSerializer = new XmlSerializer(mainType, overrides);
                }
                else
                {
                    xmlEventSerializer = new XmlSerializer(mainType, overrides, extraTypes, null, null);
                }
                XmlSerializerCacheForUtils.Add(signature, xmlEventSerializer);
            }

            return xmlEventSerializer;
        }

        public static T Deserialize<T>(XDocument xmldata)
        {
            return Deserialize<T>(xmldata, null);
        }

        public static T Deserialize<T>(XDocument xmlData, Type[] extraTypes)
        {
            lock (_syncToken)
            {
                T result = default;
                try
                {
                    using (XmlReader reader = xmlData.Root.CreateReader())
                    {
                        XmlSerializer serializer = GetSerializer<T>(extraTypes);
                        result = (T)serializer.Deserialize(reader);
                    }
                        
                    return result;
                }
                catch (Exception ex)
                {
                    throw new Exception("Could not deserialize to " + typeof(T).Name, ex);
                }
            }
        }

        public static T Deserialize<T>(string xmlData)
        {
            return Deserialize<T>(xmlData, null);
        }

        public static T Deserialize<T>(string xmlData, Type[] extraTypes, XmlAttributeOverrides overrides = null)
        {
            lock (_syncToken)
            {
                T result = default;
                try
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        using (StreamWriter writer = new StreamWriter(stream))
                        {
                            writer.Write(xmlData);
                            writer.Flush();
                            stream.Position = 0;
                            XmlSerializer serializer = GetSerializer<T>(extraTypes, overrides);
                            result = (T)serializer.Deserialize(stream);
                            writer.Close();
                        }
                    }
                    return result;
                }
                catch (Exception ex)
                {
                    throw new Exception("Could not deserialize to " + typeof(T).Name, ex);
                }
            }
        }

        public static string Serialize<T>(T obj, XmlAttributeOverrides overrides = null)
        {
            return Serialize(obj, null, overrides);
        }

        public static string Serialize<T>(T obj, Type[] extraTypes, XmlAttributeOverrides overrides = null)
        {
            lock (_syncToken)
            {
                XDocument xml = null;
                try
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                        ns.Add("snsr_std", "urn:SNSR_STD");

                        using (StreamReader reader = new StreamReader(stream))
                        {
                            XmlSerializer serializer = GetSerializer(obj.GetType(), extraTypes, overrides);
                            var settings = new XmlWriterSettings
                            {
                                Indent = true
                            };
                            using (var writer = XmlWriter.Create(stream, settings))
                            {
                                serializer.Serialize(writer, obj);
                                writer.Flush();
                                stream.Position = 0;
                            }
                            xml = XDocument.Load(reader, LoadOptions.None);

                            foreach (var element in xml.Root.Descendants())
                            {
                                PropertyInfo pi = typeof(T).GetProperty(element.Name.LocalName);
                                if (pi != null && pi.IsDefined(typeof(XmlCommentAttribute), false))
                                {
                                    xml.AddFirst(new XComment(
                                        $"{pi.Name}: {pi.GetCustomAttributes(typeof(XmlCommentAttribute), false).Cast<XmlCommentAttribute>().Single().Value}"));
                                }
                            }

                            reader.Close();
                        }
                    }

                    return xml.ToString();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Could not Serialize from {typeof(T).FullName} to xml string", ex);
                }
            }
        }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class XmlCommentAttribute : Attribute
    {
        public string Value { get; set; }
    }
}
