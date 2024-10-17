using HotelFinder.DataAccess.Abstract;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelFinder.DataAccess.Concrete
{
    public class HotelRepostory : IHotelRepostory
    {
        public Hotel CreateHotel(Hotel hotel)
        {
            using (var hotelDbContect = new HotelDbContext())
            {
                hotelDbContect.Hotels.Add(hotel);
                hotelDbContect.SaveChanges();
                return hotel;
            }
        }

        public void DeleteHotel(int id)
        {
            using (var hotelDbContect = new HotelDbContext())
            {
                var deletedHotel = GetHotelById(id);
                hotelDbContect.Hotels.Remove(deletedHotel);
                hotelDbContect.SaveChanges();
            }
        }

        public List<Hotel> GetAllHotels()
        {
            using(var hotelDbContect = new HotelDbContext())
            {
                return hotelDbContect.Hotels.ToList();
            }
        }

        public Hotel GetHotelById(int id)
        {
            using (var hotelDbContect = new HotelDbContext())
            {
                return hotelDbContect.Hotels.Find(id);
            }
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            using (var hotelDbContect = new HotelDbContext())
            {
                hotelDbContect.Hotels.Update(hotel);
                hotelDbContect.SaveChanges();
                return hotel;
            }
        }
    }
}
