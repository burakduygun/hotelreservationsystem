using System;
using System.Collections.Generic;
using HotelReservationSystem.Bilgi;
using HotelReservationSystem.Depo.Somut;
using HotelReservationSystem.Depo.Soyut;
using HotelReservationSystem.Entities.Somut;
using HotelReservationSystem.Entities.Soyut;
using HotelReservationSystem.Factory.Soyut;

namespace HotelReservationSystem.Factory.Somut
{
    class OtelOtobusFactory : RezervasyonFactory
    {
        public OtelOtobusFactory()
        {
            KonaklamaRezervasyon = new OtelRezervasyon();
            UlasimRezervasyon = new OtobusRezervasyon();
        }
        public override List<IKonaklamaDepo> KonaklamaGetir(DateTime BaslangicTarihi, DateTime BitisTarihi)
        {
            return new OtelDepo().KonaklamaGetir();
        }

        public override List<IUlasimDepo> UlasimGetir(DateTime BaslangicTarihi, DateTime BitisTarihi)
        {
            return new OtobusDepo().UlasimGetir();
        }

        public override void UlasimRezervasyonuYap(UlasimBilgileri ulasimBilgileri, IUlasimDepo secilenUlasim)
        {
            UlasimRezervasyon.ÇikisYeri = secilenUlasim.ÇikisYeri;
            UlasimRezervasyon.VarisYeri = secilenUlasim.VarisYeri;
            UlasimRezervasyon.Fiyat = secilenUlasim.Fiyat;
            UlasimRezervasyon.GidisTarihi = ulasimBilgileri.GidisTarihi;
            UlasimRezervasyon.DonusTarihi = ulasimBilgileri.DonusTarihi;
            UlasimRezervasyon.Koltuk = ulasimBilgileri.Koltuk;
        }

        public override void KonaklamaRezervasyonuYap(KonaklamaBilgileri konaklamaBilgileri, IKonaklamaDepo secilenKonaklama)
        {
            KonaklamaRezervasyon.CikisTarihi = konaklamaBilgileri.CikisTarihi;
            KonaklamaRezervasyon.GirisTarihi = konaklamaBilgileri.GirisTarihi;
            KonaklamaRezervasyon.Konum = secilenKonaklama.Konum;
            KonaklamaRezervasyon.Fiyat = (konaklamaBilgileri.CikisTarihi.Date - konaklamaBilgileri.GirisTarihi.Date).Days * secilenKonaklama.GunlukFiyat;
        }
    }
}
