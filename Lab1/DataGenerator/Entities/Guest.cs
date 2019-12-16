using System;

namespace Generator_v._2.Entities
{
    public class Guest
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PhoneNumber { get; private set; }

        public Guest(int id, string firstName, string lastName, string phoneNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;           
        }

        public override string ToString()
        {
            return Id.ToString() + Program.fieldTerminator + FirstName + Program.fieldTerminator + LastName + Program.fieldTerminator + PhoneNumber;
        }
    }
}
