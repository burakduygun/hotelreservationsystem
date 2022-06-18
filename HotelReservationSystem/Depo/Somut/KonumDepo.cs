using System.Collections.Generic;
using HotelReservationSystem.Entities.Somut;

namespace HotelReservationSystem.Depo.Somut
{
    public class KonumDepo
    {
        public List<string> KonumGetir()
        {
            return new List<string>()
            {
                "İstanbul",
                "İzmir",
                "Antalya",
                "Fethiye",
            };
        }
    }
}