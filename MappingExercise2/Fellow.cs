using System;
using System.Collections.Generic;
using System.Text;

namespace MappingExercise2
{
    public class Fellow
    {
        public Fellow(string firstName, string lastName)
        {
            FullName = firstName + " " + lastName;
        }

        public string FullName { get; private set; }
    }
}
