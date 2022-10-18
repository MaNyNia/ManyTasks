using System;
using System.Collections.Generic;
using System.Text;

namespace HW_13
{
    public class Person
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        public Person(string name, string profession, int age, string street, int house, string recipient)
        {
            Name = name;
            Profession = profession;
            Age = age;
            Address = new Address()
            {
                Street = street,
                House = house,
                Recipient = recipient,
            };
        }

        
    }
}
