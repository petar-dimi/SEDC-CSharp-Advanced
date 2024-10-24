using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Document : Searchable
    {
        private string _content;

        // Constructor to initialize the document's content
        public Document(string content)
        {
            _content = content;
        }

        // Implementing the Search method for the document
        public bool Search(string word)
        {
            Console.WriteLine("Searching in Document...");
            return _content.Contains(word, StringComparison.OrdinalIgnoreCase);
        }
    }
}
