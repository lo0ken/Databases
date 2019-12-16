using System;

namespace Generator_v._2.Entities
{
    public class Room
    {
        public int Id { get; private set; }
        public decimal Cost { get; }
        public int HotelId { get; private set; }

        

        public Room(int id, decimal cost, int hotelId)
        {
            Id = id;
            Cost = cost;
            HotelId = hotelId;
        }

        public override string ToString()
        {
            return Id.ToString() + Program.fieldTerminator + Cost.ToString() + Program.fieldTerminator + HotelId.ToString();
        }
    }
}
