using HotelReservationSystem.Bilgi;

namespace HotelReservationSystem.Builder.Soyut
{
    public abstract class RaporBuilder
    {
        protected RaporBilgi Bilgi;

        public RaporBuilder(RaporBilgi raporBilgi)
        {
            Bilgi = raporBilgi;
        }

        public string CiktiGetir()
        {
            string cikti = HeaderGetir();
            cikti += İcerikGetir();
            cikti += FooterGetir();
            return cikti;
        }

        public abstract string HeaderGetir();
        public abstract string İcerikGetir();
        public abstract string FooterGetir();
    }
}
