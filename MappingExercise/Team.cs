using System;
using System.Collections.Generic;

namespace MappingExercise
{
    public class Team
    {
        public string Localisation { get; set; }
        public string Name { get; set; }
        public IEnumerable<Member> Members { get; set; }
    }
}
