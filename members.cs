using System;
using System.Collections.Generic;

namespace Heist
{

    class Member
    {
        public Member(string name, int skillLevel, decimal courageFactor)
        {
            Name = name;
            SkillLevel = skillLevel;
            CourageFactor = courageFactor;
        }

        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public decimal CourageFactor { get; set; }
    }
}