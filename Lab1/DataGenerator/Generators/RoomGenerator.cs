using Generator_v._2.Entities;
using System;

namespace Generator_v._2.Generators
{
    class RoomGenerator : GeneratorBase<Room>
    {
        private Hotel[] hotels;
        public RoomGenerator(int size, Hotel[] hotels) : base(size)
        {
            this.hotels = hotels;
        }

        protected override Room MakeItem()
        {
            int id = GetId();
            decimal cost = GetCost();
            int hotelId = GetHotelId();

            return new Room(id, cost, hotelId);
        }

        private decimal GetCost()
        {
            return random.Next(700, 6000);
        }

        private int GetHotelId()
        {
            return hotels[random.Next(hotels.Length)].Id;
        }
    }
}
