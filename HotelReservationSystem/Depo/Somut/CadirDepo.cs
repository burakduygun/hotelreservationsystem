using System;
using System.Collections.Generic;
using HotelReservationSystem.Depo.Soyut;

namespace HotelReservationSystem.Depo.Somut
{
    public class CadirDepo : IKonaklamaDepo
    {
        public string Konum { get; set; }
        public decimal GunlukFiyat { get; set; }

        public List<IKonaklamaDepo> KonaklamaGetir()
        {
            return new List<IKonaklamaDepo>()
            {
                new CadirDepo()
                {
                    GunlukFiyat = 300,
                    Konum = "İstanbul"
                },
                new CadirDepo()
                {
                    GunlukFiyat = 350,
                    Konum = "İzmir"
                },
                new CadirDepo()
                {
                    GunlukFiyat = 450,
                    Konum = "Antalya"
                },
                 new CadirDepo()
                {
                    GunlukFiyat = 400,
                    Konum = "Fethiye"
                }
            };
        }
    }
}