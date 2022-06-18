using HotelReservationSystem.Builder.Soyut;

namespace HotelReservationSystem.Builder.Somut
{
    class RaporYonetici
    {
        private RaporBuilder Builder;
        public RaporYonetici(RaporBuilder builder)
        {
            Builder = builder;
        }
        public string RaporGetir()
        {
            string product = Builder.CiktiGetir();
            return product;
        }
        public string RaporİnsaEt()
        {
            string product = Builder.HeaderGetir();
            product += Builder.İcerikGetir();
            product += Builder.FooterGetir();
            return product;
        }
    }
}
