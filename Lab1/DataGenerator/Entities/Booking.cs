using System;

namespace Generator_v._2.Entities
{
    public class Booking
    {
        public int Id { get; private set; }
        public int GuestId { get; private set; }
        public int RoomId { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public Booking(int id, int guestId, int roomId, DateTime startDate, DateTime endDate)
        {
            Id = id;
            GuestId = guestId;
            RoomId = roomId;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override string ToString()
        {
            return Id.ToString() + Program.fieldTerminator + GuestId.ToString() + Program.fieldTerminator + RoomId.ToString() + Program.fieldTerminator + StartDate + Program.fieldTerminator + EndDate;
        }
    }
}
