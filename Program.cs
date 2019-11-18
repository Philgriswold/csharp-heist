using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your Heist!");

            Dictionary<string, string> teamMember = new Dictionary<string, string>();
            string name = "Bill";
            string skill = "9";
            string courage = "1.4";

            Console.WriteLine("What is your name?");
            string newName = Console.ReadLine();
        }
    }
}