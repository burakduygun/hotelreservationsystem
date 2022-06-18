using System;
using System.Collections.Generic;
using HotelReservationSystem.Depo.Soyut;

namespace HotelReservationSystem.Depo.Somut
{
    public class OtobusDepo : IUlasimDepo
    {
        public List<IUlasimDepo> UlasimGetir()
        {
            return new List<IUlasimDepo>()
            {
                new OtobusDepo()
                {
                    ÇikisYeri = "İzmir",
                    VarisYeri = "Fethiye",
                    Fiyat = 200
                },
                new OtobusDepo()
                {
                    ÇikisYeri = "Fethiye",
                    VarisYeri = "İzmir",
                    Fiyat = 200
                },
                  new OtobusDepo()
                {
                    ÇikisYeri = "İzmir",
                    VarisYeri = "Antalya",
                    Fiyat = 250
                },
                new OtobusDepo()
                {
                    ÇikisYeri = "Antalya",
                    VarisYeri = "İzmir",
                    Fiyat = 250
                },
                new OtobusDepo()
                {
                    ÇikisYeri = "İzmir",
                    VarisYeri = "İstanbul",
                    Fiyat = 350
                },
                new OtobusDepo()
                {
                    ÇikisYeri = "İstanbul",
                    VarisYeri = "İzmir",
                    Fiyat = 350
                },
                new OtobusDepo()
                {
                    ÇikisYeri = "İstanbul",
                    VarisYeri = "Fethiye",
                    Fiyat = 400
                },
                new OtobusDepo()
                {
                    ÇikisYeri = "Fethiye",
                    VarisYeri = "İstanbul",
                    Fiyat = 400
                },
                  new OtobusDepo()
                {
                    ÇikisYeri = "İstanbul",
                    VarisYeri = "Antalya",
                    Fiyat = 450
                },
                new OtobusDepo()
                {
                    ÇikisYeri = "Antalya",
                    VarisYeri = "İstanbul",
                    Fiyat = 450
                },
            };
        }

        public string ÇikisYeri { get; set; }
        public string VarisYeri { get; set; }
        public decimal Fiyat { get; set; }
    }
}