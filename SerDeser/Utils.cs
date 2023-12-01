using System.Text.Json;
using System.Xml.Serialization;

namespace SerDeser
{
    public static class Utils
    {
        public static List<Person> JsonDeserialize()
        {
            using (StreamReader reader = new StreamReader("SomeJson.json"))
            {
                string jsonData = reader.ReadToEnd();

                return JsonSerializer.Deserialize<List<Person>>(jsonData)!;
            }
        }

        public static void XmlSerialize(List<Person> data)
        {
            using (StreamWriter writer = new StreamWriter("SomeXml.xml"))
            {
                
                XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));

                serializer.Serialize(writer, data);
            }
        }
    }
}
