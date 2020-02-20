using System;
using System.Collections.Generic;

namespace MappingExercise2
{
    public class Team
    {
        public Team(string localisation, string name, ICollection<Member> members)
        {
            Localisation = localisation;
            Name = name;
            Members = members;
        }

        public string Localisation { get; private set; }
        public string Name { get; private set; }
        public ICollection<Member> Members { get; private set; }
    }
}
