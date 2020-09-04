using System;
using System.Collections.Generic;

namespace CList
{
	class Program
	{
        static void Main(string[] args)
        {
            var emplist = new List<String>();

            emplist.Add("Soumya");
            emplist.Add("Mahak");
            emplist.Add("Gautam");
            emplist.Add("Tom");
            emplist.Add("Vinitha");
            emplist.Add("Sravani");

            Console.WriteLine("Employees Present in List:\n");

            int pos = 0;

            foreach (string name in emplist)
            {
                Console.Write("At Position {0}: ", pos);
                Console.WriteLine(name.ToUpper());
                pos++;
            }

            Console.WriteLine(" ");
 
            Console.WriteLine("Removing the employee at index 3\n");
 
            emplist.RemoveAt(3);

            int pos1 = 0;

            foreach (string n in emplist)
            {
                Console.Write("At Position {0}: ", pos1);
                Console.WriteLine(n.ToLower());
                pos1++;
            }
            Console.WriteLine(" ");
            Console.WriteLine("The sorted list of employee names:\n");
            emplist.Sort();
            int pos2=0;
            foreach (var names in emplist)
            {
                Console.Write("At Position {0}: ", pos2);
                Console.WriteLine(names);
                pos2++;
            }
            Console.WriteLine(" ");
            var index = emplist.IndexOf("Vinitha");
            Console.WriteLine($"Vinitha is found at {index}");
        }
	}
}
