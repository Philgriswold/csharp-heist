using System;
using System.Collections.Generic;

//this code is currently broken

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");

            List<Member> teamMember = new List<Member>();

            Member member1 = new Member("Bill", 9, 1.4m);

            List<string> Questions = new List<string>();


            Console.WriteLine("Enter a new team member's name");
            string newName1 = Console.ReadLine();
            teamMember.Add("Name" + newName1);

            Console.WriteLine("Enter a new team member's skill level");
            string newSkillLevel1 = Console.ReadLine();
            teamMember.Add("Skill level" + newSkillLevel1);

            Console.WriteLine("Enter a new team member's courage factor");
            string newCourageFactor1 = Console.ReadLine();
            teamMember.Add("Courage factor" + newCourageFactor1);

            foreach (KeyValuePair<string, string> in teamMember)
            {
                Console.WriteLine("");
            }
        };
    }
}


// Console.WriteLine("Please enter a new team members name?"),
// Console.WriteLine("Please enter a new team member's skill level")