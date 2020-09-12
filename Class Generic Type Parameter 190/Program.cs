using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Generic_Type_Parameter_190
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>();
            employee1.things.Add("Microphone");
            employee1.things.Add("Video Camera");
            employee1.things.Add("Audio Recorder");
            employee1.things.Add("Tripod");

            Employee<int> employee2 = new Employee<int>();
            employee2.things.Add(3);
            employee2.things.Add(14);
            employee2.things.Add(15);
            employee2.things.Add(9);

            foreach (string thing in employee1.things)
            {
                Console.WriteLine(thing);
            }
            
            foreach (int thing in employee2.things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
