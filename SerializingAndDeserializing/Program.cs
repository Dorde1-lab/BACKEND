namespace SerializingAndDeserializing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myFirstJsonPath = "E:\\cv\\SEDC\\BACKEND\\BACKEND\\SerializingAndDeserializing\\MyFirstJson.json";
            StreamReader streamReader = new StreamReader(myFirstJsonPath);



            using(streamReader)
            {
                string jsonContent = streamReader.ReadToEnd();
                Console.WriteLine(jsonContent);
            }


        }
    }
}
