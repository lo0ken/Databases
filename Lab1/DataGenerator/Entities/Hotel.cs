using System;

namespace Generator_v._2.Entities
{
    public class Hotel
    {
        public int Id { get; private set; }
        public string HotelName { get; private set; }
        public int CityId { get; private set; }
        public int CompanyId { get; private set; }

        public Hotel(int id, string hotelName, int cityId)
        {
            Id = id;
            HotelName = hotelName;
            CityId = cityId;
        }

        public Hotel(int id, string hotelName, int cityId, int companyId)
        {
            Id = id;
            HotelName = hotelName;
            CityId = cityId;
            CompanyId = companyId;
        }

        public override string ToString()
        {
            return Id.ToString() + Program.fieldTerminator + HotelName + Program.fieldTerminator + CityId.ToString() + Program.fieldTerminator + CompanyId.ToString();
        }
    }
}
