using System;
using System.Text;

namespace Strings_And_Stringbuilder_125
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your first name?");
            string fName = Console.ReadLine();
            Console.WriteLine("What is your middle name?");
            string mName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lName = Console.ReadLine();

            Console.WriteLine("Hello, " + fName + " " + mName + " " + lName + "!");
            Console.ReadLine();

            Console.WriteLine("Help me write a story, won't you?\nWe'll take turns writing sentences.\nI'll go first...");
            StringBuilder sb = new StringBuilder();
            sb.Append("A wombat named Jeremy is terrorizing the neighboring village. ");
            Console.WriteLine(sb);
            Console.WriteLine("Add a sentence please!");
            sb.Append(Console.ReadLine());
            sb.Append(" He keeps breaking into people's garages to drink their automotive fluids. ");
            Console.WriteLine(sb);
            Console.WriteLine("Add another sentence...");
            sb.Append(Console.ReadLine());
            sb.Append(" And after all of that he became an upstanding member of the community, elected to city congress and finally the presidency of the United States!");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
