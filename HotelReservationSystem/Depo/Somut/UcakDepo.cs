using System;
using System.Collections.Generic;
using HotelReservationSystem.Depo.Soyut;
using HotelReservationSystem.Entities.Somut;
using HotelReservationSystem.Entities.Soyut;

namespace HotelReservationSystem.Depo.Somut
{
    public class UcakDepo : IUlasimDepo
    {
        public List<IUlasimDepo> UlasimGetir()
        {
            return new List<IUlasimDepo>()
            {
                new UcakDepo()
                {
                    ÇikisYeri = "İzmir",
                    VarisYeri = "Fethiye",
                    Fiyat = 300
                },
                new UcakDepo()
                {
                    ÇikisYeri = "Fethiye",
                    VarisYeri = "İzmir",
                    Fiyat = 300
                },
                new UcakDepo()
                {
                    ÇikisYeri = "İzmir",
                    VarisYeri = "Antalya",
                    Fiyat = 400
                },
                new UcakDepo()
                {
                    ÇikisYeri = "Antalya",
                    VarisYeri = "İzmir",
                    Fiyat = 400
                },
                new UcakDepo()
                {
                    ÇikisYeri = "İzmir",
                    VarisYeri = "İstanbul",
                    Fiyat = 450
                },
                new UcakDepo()
                {
                    ÇikisYeri = "İstanbul",
                    VarisYeri = "İzmir",
                    Fiyat = 450
                },
                new UcakDepo()
                {
                    ÇikisYeri = "İstanbul",
                    VarisYeri = "Antalya",
                    Fiyat = 350
                },
                new UcakDepo()
                {
                    ÇikisYeri = "Antalya",
                    VarisYeri = "İstanbul",
                    Fiyat = 350
                },
                new UcakDepo()
                {
                    ÇikisYeri = "İstanbul",
                    VarisYeri = "Fethiye",
                    Fiyat = 400
                },
                new UcakDepo()
                {
                    ÇikisYeri = "Fethiye",
                    VarisYeri = "İstanbul",
                    Fiyat = 400
                },
            };
        }

        public string ÇikisYeri { get; set; }
        public string VarisYeri { get; set; }
        public decimal Fiyat { get; set; }
    }
}