using Generator_v._2.Entities;
using Generator_v._2.Generators;
using System;
using System.Collections.Generic;
using System.IO;

namespace Generator_v._2
{
    class Program
    {
        public static char fieldTerminator = '\t';

        private static readonly string guestsPath = "guests.txt";
        private static readonly string companiesPath = "companies.txt";
        private static readonly string citiesPath = "cities.txt";
        private static readonly string hotelsPath = "hotels.txt";
        private static readonly string roomsPath = "rooms.txt";
        private static readonly string bookingsPath = "bookings.txt";

        private static void WriteDataToFile<T> (string filePath, IEnumerable<T> data)
        {
            StreamWriter writer = new StreamWriter(filePath);

            foreach (var item in data)
                writer.WriteLine(item);

            writer.Close();
        }


        static void Main(string[] args)
        {
            var guestGenerator = new GuestGenerator(500);
            var cityGenerator = new CityGenerator();
            var companyGenerator = new CompanyGenerator();
            

            var guests = guestGenerator.Generate();
            var cities = cityGenerator.Generate();
            var companies = companyGenerator.Generate();

            var hotelGenerator = new HotelGenerator(1000, cities, companies);
            var hotels = hotelGenerator.Generate();


            var roomGenerator = new RoomGenerator(2000, hotels);
            var rooms = roomGenerator.Generate();

            var bookingGenerator = new BookingGenerator(3000, guests, rooms);
            var bookings = bookingGenerator.Generate();

            WriteDataToFile(guestsPath, guests);
            WriteDataToFile(citiesPath, cities);
            WriteDataToFile(companiesPath, companies);
            WriteDataToFile(hotelsPath, hotels);
            WriteDataToFile(roomsPath, rooms);
            WriteDataToFile(bookingsPath, bookings);
        }
    }
}
