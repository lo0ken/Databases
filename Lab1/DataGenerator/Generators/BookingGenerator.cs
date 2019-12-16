using Generator_v._2.Entities;
using System;

namespace Generator_v._2.Generators
{
    class BookingGenerator : GeneratorBase<Booking>
    {
        private Guest[] guests;
        private Room[] rooms;

        private DateTime leftBound = new DateTime(2017, 1, 1);
        private DateTime rightBound = new DateTime(2019, 9, 14);

        private int bookingMinDays = 1;
        private int bookingMaxDays = 20;

        public BookingGenerator(int size, Guest[] guests, Room[] rooms) : base(size)
        {
            this.guests = guests;
            this.rooms = rooms;
        }

        protected override Booking MakeItem()
        {
            int id = GetId();
            int guestId = GetGuestId();
            int roomId = GetRoomId();
            DateTime startDate = GetStartDate();
            DateTime endDate = GetEndDate(startDate);

            return new Booking(id, guestId, roomId, startDate, endDate);
        }

        private int GetGuestId()
        {
            return guests[random.Next(guests.Length)].Id;
        }

        private int GetRoomId()
        {
            return rooms[random.Next(rooms.Length)].Id;
        }

        private DateTime GetStartDate()
        {
            TimeSpan difference = rightBound - leftBound;
            int daysToStartDate = random.Next((int)difference.TotalDays);
            return leftBound + TimeSpan.FromDays(daysToStartDate);
        }

        private DateTime GetEndDate(DateTime startDate)
        {
            return startDate.AddDays(random.Next(bookingMinDays, bookingMaxDays));
        }
    }
}
