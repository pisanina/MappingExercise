using System;
using System.Collections.Generic;
using System.Text;

namespace MappingExercise2
{
    public class Member
    {
        public Member(string firstName, string lastName, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string City { get; private set; }
    }
}
