using System;

namespace Generator_v._2.Entities
{
    public class City
    {
        public int Id { get; private set; }
        public string CityName { get; private set; }

        public City(int id, string cityName)
        {
            Id = id;
            CityName = cityName;
        }

        public override string ToString()
        {
            return Id.ToString() + Program.fieldTerminator + CityName;
        }
    }
}
