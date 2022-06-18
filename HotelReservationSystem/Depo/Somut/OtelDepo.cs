using System;
using System.Collections.Generic;
using HotelReservationSystem.Depo.Soyut;

namespace HotelReservationSystem.Depo.Somut
{
    public class OtelDepo : IKonaklamaDepo
    {
        public List<IKonaklamaDepo> KonaklamaGetir()
        {
            return new List<IKonaklamaDepo>()
            {
                new OtelDepo()
                {
                    GunlukFiyat = 450,
                    Konum = "İstanbul"
                },
                new OtelDepo()
                {
                    GunlukFiyat = 400,
                    Konum = "İzmir",
                },
                new OtelDepo()
                {
                    GunlukFiyat = 550,
                    Konum = "Antalya"
                },
                 new OtelDepo()
                {
                    GunlukFiyat = 500,
                    Konum = "Fethiye"
                }
            };
        }

        public string Konum { get; set; }
        public decimal GunlukFiyat { get; set; }
    }
}