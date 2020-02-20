using System;
using System.Collections.Generic;
using System.Text;

namespace MappingExercise
{
    public class Group
    {
        public string Key { get; set; } // localisation/team name
        public IEnumerable<Fellow> Fellows { get; set; }
    }
}
