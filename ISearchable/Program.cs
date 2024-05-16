namespace HomeworkTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string documentText = " Create branded contracts, agreements and price lists within a no-code automation platform.";

            Document document1 = new Document(documentText);

            document1.Search("price");




            string webPageText = "The best text messaging service for business. Start today, and ignite customer engagement.";

            WebPage document2 = new WebPage(webPageText);

            document2.Search("service");
        }
    }
}
