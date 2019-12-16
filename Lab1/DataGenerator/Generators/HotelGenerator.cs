using Generator_v._2.Entities;
using System;

namespace Generator_v._2.Generators
{
    class HotelGenerator : GeneratorBase<Hotel>
    {
        private City[] cities;
        private Company[] companies;

        public HotelGenerator(int size, City[] cities, Company[] companies) : base(size)
        {
            this.cities = cities;
            this.companies = companies;
        }

        protected override Hotel MakeItem()
        {
            int id = GetId();
            string hotelName = DataStore.GetRandomHotel();
            int cityId = GetCityId();

            if (InCompany())
                return new Hotel(id, hotelName, cityId, GetCompanyId());

            return new Hotel(id, hotelName, cityId);
        }

        private int GetCityId()
        {
            return cities[random.Next(cities.Length)].Id;
        }
        
        private int GetCompanyId()
        {
            return companies[random.Next(companies.Length)].Id;
        }

        private bool InCompany()
        {
            return random.Next(0, 2) > 0;
        }
    }
}
