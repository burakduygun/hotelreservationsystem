using System;
using System.Collections.Generic;
using HotelReservationSystem.Bilgi;
using HotelReservationSystem.Depo.Soyut;
using HotelReservationSystem.Entities.Soyut;

namespace HotelReservationSystem.Factory.Soyut
{
    public abstract class RezervasyonFactory
    {
        public IUlasimRezervasyon UlasimRezervasyon { get; protected set; }
        public IKonaklamaRezervasyon KonaklamaRezervasyon { get; protected set; }
        public abstract List<IKonaklamaDepo> KonaklamaGetir(DateTime BaslangicTarihi, DateTime BitisTarihi);
        public abstract List<IUlasimDepo> UlasimGetir(DateTime BaslangicTarihi, DateTime BitisTarihi);
        public abstract void UlasimRezervasyonuYap(UlasimBilgileri ulasimBilgileri, IUlasimDepo secilenUlasim);
        public abstract void KonaklamaRezervasyonuYap(KonaklamaBilgileri konaklamaBilgileri, IKonaklamaDepo secilenKonaklama);
    }
}