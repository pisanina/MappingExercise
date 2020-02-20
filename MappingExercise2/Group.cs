using System;
using System.Collections.Generic;
using System.Text;

namespace MappingExercise2
{
    public class Group
    {
        public Group(string key)
        {
            Key = key;
            Fellows = new List<Fellow>();
        }

        public void AddFellow(Fellow fellow)
        {
            Fellows.Add(fellow);
        }

        public string Key { get; private set; } // localisation/team name
        public ICollection<Fellow> Fellows { get;  private set; }
    }
}
