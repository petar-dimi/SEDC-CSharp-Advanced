using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04Task01
{
    public class PrintInConsole
    {
        // Generic method to print a single item
        public void Print<T>(T item)
        {
            Console.WriteLine(item);
        }

        // Generic method to print a collection of items
        public void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
