using System;
using System.Collections.Generic;

namespace HeistExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist");
            Console.WriteLine();
            Heister teamMember;

            // Create a way to store several team members.
            List<Heister> heistGroup = new List<Heister>();

            Console.WriteLine("What is the team member's name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is the team member's skill level?");
            string skillLevelString = Console.ReadLine();
            int skillLevel;

            try
            {
                skillLevel = int.Parse(skillLevelString);
            }
            catch (Exception)
            {
                Console.WriteLine($"{skillLevelString} is not a valid skill level. Using a default value of 10");
                skillLevel = 10;
            }

            Console.WriteLine("What is the team member's courage factor?");
            string courageFactorString = Console.ReadLine();
            decimal courageFactor;

            try
            {
                courageFactor = decimal.Parse(courageFactorString);
            }
            catch (Exception)
            {

                Console.WriteLine($"{courageFactorString} is not a valid courage factor. Using a default value of 1.0");
                courageFactor = 1.0M;
            }

            teamMember = new Heister()
            {
                Name = name,
                SkillLevel = skillLevel,
                CourageFactor = courageFactor
            };
            Console.WriteLine($"Name: {teamMember.Name}");
            Console.WriteLine($"Skill Level: {teamMember.SkillLevel}");
            Console.WriteLine($"Courage Factor: {teamMember.CourageFactor}");
            heistGroup.Add(teamMember);



            while (true)
            {
                Console.WriteLine("Enter a new team member's name!");
                string memberName = Console.ReadLine();

                if (name == "")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("What is your skill level");
                    string skill = Console.ReadLine();

                    Console.WriteLine("What is your courage factor");
                    string courage = Console.ReadLine();
                }

            }

        }



    }
}