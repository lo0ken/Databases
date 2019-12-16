using Generator_v._2.Entities;
using System;

namespace Generator_v._2.Generators
{
    class CompanyGenerator : GeneratorBase<Company>
    {
        private static int indexOfCurrentCity = 0;
        public CompanyGenerator() : base(DataStore.Companies.Length)
        {
        }

        protected override Company MakeItem()
        {
            int id = GetId();
            string companyName = DataStore.Companies[indexOfCurrentCity++];

            return new Company(id, companyName);
        }
    }
}
