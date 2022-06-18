using System;
using System.Collections.Generic;

namespace HotelReservationSystem.Depo.Soyut
{
    public interface IUlasimDepo
    {
        List<IUlasimDepo> UlasimGetir();
        string ÇikisYeri { get; set; }
        string VarisYeri { get; set; }
        decimal Fiyat { get; set; }

    }
}