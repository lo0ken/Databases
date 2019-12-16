
using Generator_v._2.Entities;
using System;

namespace Generator_v._2.Generators
{
    public class GuestGenerator : GeneratorBase<Guest>
    {  
        public GuestGenerator(int size) : base(size)
        {
        }

        private string GeneratePhoneNumber()
        {
            string phoneNumber = "(";

            for (int i = 0; i <= 10; i++)
            {
                if (i == 3)
                    phoneNumber += ") ";
                if (i == 6 || i == 9)
                    phoneNumber += "-";

                phoneNumber += random.Next(0, 9);
            }

            return phoneNumber;
        }

        protected override Guest MakeItem()
        {
            int id = GetId();
            string firstName = DataStore.GetRandomFirstName();
            string lastName = DataStore.GetRandomLastName();
            string phoneNumber = GeneratePhoneNumber();

            return new Guest(id, firstName, lastName, phoneNumber);
        }
    }
}
