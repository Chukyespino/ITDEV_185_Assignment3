using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Assignment3
{
    class mainContoler
    {
        List<string> names = new List<string>();

        public void userinterface()
        {
            while (true)
            {
                int select;
                string name;
                Console.WriteLine("Enter 1 for Name Input.");
                Console.WriteLine("Enter 2 for List Display.");
                Console.WriteLine("Enter 3 to Exit.");

                select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        Console.WriteLine("Enter new name: ");
                        name = Console.ReadLine();
                        list(name);
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Name list:");
                        display();
                        Console.WriteLine();
                        break;
                    case 3:
                        close();
                        break;

                }
            }
        }

        public void list(string name)
        {
            string listName = name;
            names.Add(listName);

        }
        public void display()
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
        public void close()
        {
            Console.Clear();
            Console.WriteLine("Good Bye...");
            Thread.Sleep(2000);
            Environment.Exit(-1);
        }
    }
}