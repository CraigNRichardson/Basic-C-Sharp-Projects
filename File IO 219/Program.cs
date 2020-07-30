using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_219
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter a number: ");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Craig\Desktop\C#Projects\Logs\log.txt", text);
            string textReturn = File.ReadAllText(@"C:\Users\Craig\Desktop\C#Projects\Logs\log.txt");
            Console.WriteLine(textReturn);
            Console.ReadLine();

        }
    }
}
