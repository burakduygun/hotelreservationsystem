using System;

namespace HotelReservationSystem.Entities.Soyut
{
    public interface IKonaklamaRezervasyon
    {
        DateTime GirisTarihi { get; set; }
        DateTime CikisTarihi { get; set; }
        string Konum { get; set; }
        decimal Fiyat { get; set; }
    }
}
