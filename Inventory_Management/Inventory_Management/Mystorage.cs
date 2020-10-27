using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Collections.ObjectModel;
using Inventory_Management;

namespace MYStorage 
{
    internal class MYStorage
    {
        public static void WriteXml<T>(T data, string file)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T)); //
            FileStream stream;
            stream = new FileStream(file, FileMode.Create);
            serializer.Serialize(stream, data);
            stream.Close();
        }

        public static T ReadXml<T>(string file)
        {
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    return (T)serializer.Deserialize(sr);
                }
            }
            catch // (Exception)
            {

                return default(T);
            }
        }

        //internal static void WriteXml<T>(ObservableCollection<Item> item, string v)
        //{
          //  throw new NotImplementedException();
       // }
    }
}
