using System;
using System.IO;
using System.Threading.Tasks;

namespace Asynchrony
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            FileReader fileReader = new FileReader();    
            Console.WriteLine(fileReader.Adder().GetAwaiter().GetResult());
            Console.ReadKey();
        }
    }
}
