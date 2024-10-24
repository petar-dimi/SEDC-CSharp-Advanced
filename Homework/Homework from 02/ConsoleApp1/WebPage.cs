using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class WebPage : Searchable
    {
        private string _htmlContent;

        // Constructor to initialize the webpage's content
        public WebPage(string htmlContent)
        {
            _htmlContent = htmlContent;
        }

        // Implementing the Search method for the webpage
        public bool Search(string word)
        {
            Console.WriteLine("Searching in WebPage...");
            return _htmlContent.Contains(word, StringComparison.OrdinalIgnoreCase);
        }
    }
}
