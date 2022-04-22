using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageElements
{
    public class ManageList
    {
        List<String> names = new List<String>() {"Alice", "Bob", "Charlie"};
        public void Run()
        {
            Console.WriteLine("Current contents of the list:");
            foreach (String name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Enter command (+ item, - item, or -- to clear), Enter exit to exit:");
            String input = Console.ReadLine();
            while (input != "exit")
            {
                if (input == null)
                {
                    Console.WriteLine("Invalid Operation");
                }
                else if (input == "--") {
                    names.Clear();
                }
                else if (input[0] == '+')
                {
                    names.Add(input.Substring(1).TrimStart());
                }
                else if (input[0] == '-')
                {
                    names.Remove(input.Substring(1).TrimStart());
                }
                else
                {
                    Console.WriteLine("Invalid Operation");
                }
                Console.WriteLine("Current contents of the list:");
                foreach (String name in names)
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine("Enter command (+ item, - item, or -- to clear), Enter exit to exit:");
                input = Console.ReadLine();
            }
        }
    }
}
