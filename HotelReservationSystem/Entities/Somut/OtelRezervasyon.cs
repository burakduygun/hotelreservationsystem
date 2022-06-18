using System;
using System.Collections.Generic;
using HotelReservationSystem.Entities.Soyut;

namespace HotelReservationSystem.Entities.Somut
{
    class OtelRezervasyon : IKonaklamaRezervasyon
    {
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public string Konum { get; set; }
        public decimal Fiyat { get; set; }
    }
}
