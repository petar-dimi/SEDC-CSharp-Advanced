namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Document doc = new Document("This is a text document containing various words for searching.");

            
            WebPage webPage = new WebPage("<html><body>This is a webpage containing HTML content and keywords.</body></html>");

            
            string searchKeyword = "words";
            bool foundInDoc = doc.Search(searchKeyword);
            Console.WriteLine(foundInDoc ? $"'{searchKeyword}' found in Document." : $"'{searchKeyword}' not found in Document.");

           
            searchKeyword = "HTML";
            bool foundInWebPage = webPage.Search(searchKeyword);
            Console.WriteLine(foundInWebPage ? $"'{searchKeyword}' found in WebPage." : $"'{searchKeyword}' not found in WebPage.");
        }
    }
}
