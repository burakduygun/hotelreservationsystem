using System;

namespace HotelReservationSystem.Entities.Soyut
{
    public interface IUlasimRezervasyon
    {
        int Koltuk { get; set; }
        string ÇikisYeri { get; set; }
        string VarisYeri { get; set; }
        DateTime GidisTarihi { get; set; }
        DateTime DonusTarihi { get; set; }
        decimal Fiyat { get; set; }
    }
}
