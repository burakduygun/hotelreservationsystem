using System;
using System.Collections.Generic;
using HotelReservationSystem.Entities.Soyut;

namespace HotelReservationSystem.Depo.Soyut
{
    public interface IKonaklamaDepo
    {
        List<IKonaklamaDepo> KonaklamaGetir();
        string Konum { get; set; }
        decimal GunlukFiyat { get; set; }
    }
}