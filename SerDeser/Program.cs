namespace SerDeser
{
    public class Program
    {
        static void Main(string[] args)
        {
            Utils.XmlSerialize(Utils.JsonDeserialize());
        }
    }
}