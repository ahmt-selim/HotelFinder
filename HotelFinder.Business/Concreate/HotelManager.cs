using HotelFinder.Business.Abstract;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.DataAccess.Concrete;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelFinder.Business.Concreate
{
    public class HotelManager : IHotelService
    {
        private IHotelRepostory _hotelRepostory;
        public HotelManager()
        {
            _hotelRepostory = new HotelRepostory();
        }
        public Hotel CreateHotel(Hotel hotel)
        {
            return _hotelRepostory.CreateHotel(hotel);
        }

        public void DeleteHotel(int id)
        {
            _hotelRepostory.DeleteHotel(id);
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotelRepostory.GetAllHotels();
        }

        public Hotel GetHotelById(int id)
        {
            if (id > 0)
            {
                return _hotelRepostory.GetHotelById(id);
            }

            throw new Exception("Id can not be less than 1");
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            return _hotelRepostory.UpdateHotel(hotel);
        }
    }
}
