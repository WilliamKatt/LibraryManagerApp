using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LM.Common
{
    /// <summary>
    /// XML文件与Model实体转换帮助类
    /// </summary>
    public static class XmlUtil
    {
        /// <summary>
        /// XML文件反序列化成实体对象
        /// </summary>
        /// <param name="xmlFilePath">XML文件的绝对路径</param>
        /// <param name="type">反序列化XML为哪种对象类型</param>
        /// <returns></returns>
        public static object DeserializeFromXml(string xmlFilePath, Type type)
        {
            object result = null;
            if (File.Exists(xmlFilePath))
            {
                using (StreamReader reader = new StreamReader(xmlFilePath))
                {
                    XmlSerializer xs = new XmlSerializer(type);
                    result = xs.Deserialize(reader);
                }
            }
            return result;
        }

        /// <summary>
        /// 实体对象序列化成XML文件
        ///当需要将多个对象实例序列化到同一个XML文件中的时候,xmlRootName就是所有对象共同的根节点名称,如果不指定,.net会默认给一个名称(ArrayOf+实体类名称)
        /// </summary>
        /// <param name="srcObject">实体对象的实例</param>
        /// <param name="type">实体对象的类型</param>
        /// <param name="xmlFilePath">xml文件的绝对路径</param>
        /// <param name="xmlRootName">xml文件中根节点名称</param>
        public static void SerializeToXml(object srcObject, Type type, string xmlFilePath, string xmlRootName)
        {
            if (srcObject != null && !string.IsNullOrEmpty(xmlFilePath))
            {
                type = type != null ? type : srcObject.GetType();
                using (StreamWriter sw = new StreamWriter(xmlFilePath))
                {
                    XmlSerializer xs = string.IsNullOrEmpty(xmlRootName)?new XmlSerializer(type) :new XmlSerializer(type, new XmlRootAttribute(xmlRootName));
                    xs.Serialize(sw, srcObject);
                }
            }
        }
    }
}
