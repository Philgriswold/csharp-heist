using System;
using System.Collections.Generic;
using System.Linq;

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


                List<int> skillNum = new List<int>();

                heistGroup.ForEach(heister =>
                 {
                     skillNum.Add(heister.SkillLevel);
                 });
                int skillSum = skillNum.Sum();
                int bankDifficulty = 100;

                if (skillSum < bankDifficulty)
                {
                    Console.WriteLine("I wouldn't do this");
                }
                else
                {
                    Console.WriteLine("I think you can pull this off");
                }
                //phase 4 started
                Random random = new Random();
                int luckValue = random.Next(-10, 10);
                bankDifficulty += luckValue;
                Console.WriteLine($"Your teams skill level is {skillSum}");
                Console.WriteLine($"The bank's difficulty level is {bankDifficulty}");
            }
        }
    }
}
