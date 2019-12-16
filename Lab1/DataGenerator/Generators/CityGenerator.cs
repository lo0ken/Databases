using Generator_v._2.Entities;
using System;

namespace Generator_v._2.Generators
{
    class CityGenerator : GeneratorBase<City>
    {
        private static int indexOfCurrentCity = 0;

        public CityGenerator() : base(DataStore.Cities.Length)
        {
        }

        protected override City MakeItem()
        {
            int id = GetId();
            string cityName = DataStore.Cities[indexOfCurrentCity++];

            return new City(id, cityName);
        }
    }
}
