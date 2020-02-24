using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine("PLease make a selection");
                Console.WriteLine("1: Add Name to List");
                Console.WriteLine("2: Display List");
                Console.WriteLine("3:Quit");

                select = Convert.ToInt32(Console.ReadLine());

                if (select == 3)
                    break;
                Console.Clear();

                switch (select)
                {
                    case 1:
                        Console.WriteLine("Enter Name: ");
                        name = Console.ReadLine();
                        list(name);
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Names In list");
                        display();
                        Console.WriteLine();
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
    }
}