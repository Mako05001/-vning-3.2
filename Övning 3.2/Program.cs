using System;
namespace Övning3._2
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Vilket land vann fotboll-VM för damer 2015?");
            string l = Console.ReadLine();
            if (l == "usa")
            {
                Console.WriteLine("Rätt");
            }
            else if (l != "usa")
            {
                Console.WriteLine("Fel");
            }

        }
    }
}
