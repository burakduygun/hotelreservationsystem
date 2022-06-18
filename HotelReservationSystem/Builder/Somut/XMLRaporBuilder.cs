using System.Text;
using HotelReservationSystem.Bilgi;
using HotelReservationSystem.Builder.Soyut;

namespace HotelReservationSystem.Builder.Somut
{
    class XMLRaporBuilder : RaporBuilder
    {
        public XMLRaporBuilder(RaporBilgi raporBilgi) : base(raporBilgi)
        {
        }

        public override string HeaderGetir()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format("<GenelBilgi>\n <GidisTarihi>{0}</GidisTarihi>\n <DonusTarihi>{1}</DonusTarihi>\n <KonaklamaSekli>{2}</KonaklamaSekli>\n <UlasimSekli>{3}</UlasimSekli>\n</GenelBilgi>\n",
                Bilgi.genelBilgi.GidisTarihi.ToString("d  M  yyyy"), Bilgi.genelBilgi.DonusTarihi.ToString("d  M  yyyy"), Bilgi.genelBilgi.KonaklamaSekli, Bilgi.genelBilgi.UlasimSekli));

            return sb.ToString();
        }
        public override string FooterGetir()
        {
            return string.Format("<Footer>\n <Fiyat>{0}</Fiyat>\n</Footer>", this.Bilgi.fiyat);
        }

        public override string İcerikGetir()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format("<DetayliBilgi>\n <Ad>{0}</Ad>\n <Soyad>{1}</Soyad>\n <GidisYeri>{2}</GidisYeri>\n <TCNo>{3}</TCNo>\n <CepNo>{4}</CepNo>\n</DetayliBilgi>\n",
                Bilgi.detayliBilgi.Ad, Bilgi.detayliBilgi.Soyad, Bilgi.detayliBilgi.GidisYeri, Bilgi.detayliBilgi.TCNo, Bilgi.detayliBilgi.CepNo));

            return sb.ToString();
        }
    }
}
