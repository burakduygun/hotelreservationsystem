using System;
using System.Collections.Generic;
using HotelReservationSystem.Entities.Soyut;

namespace HotelReservationSystem.Entities.Somut
{
    class OtobusRezervasyon : IUlasimRezervasyon
    {
        public int Koltuk { get; set; }
        public string ÇikisYeri { get; set; }
        public string VarisYeri { get; set; }
        public DateTime GidisTarihi { get; set; }
        public DateTime DonusTarihi { get; set; }
        public decimal Fiyat { get; set; }
    }
}
