using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This was writtern in the master");
            Console.WriteLine("This was also writtern in the master");
            Console.WriteLine("This was writtern in branch 2");

            Console.WriteLine("This was written in branch2 after the first rebase.");
            Console.WriteLine("This was writtern in branch 2");
        }
    }
}
