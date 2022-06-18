using System.Text;
using HotelReservationSystem.Bilgi;
using HotelReservationSystem.Builder.Soyut;

namespace HotelReservationSystem.Builder.Somut
{
    public class HTMLRaporBuilder : RaporBuilder
    {
        public HTMLRaporBuilder(RaporBilgi raporBilgi) : base(raporBilgi)
        {
        }

        public override string HeaderGetir()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format("<h2>GenelBilgi</h2> <p>{0}</p> <p>{1}</p> <p>{2}</p> <p>{3}</p>", Bilgi.genelBilgi.GidisTarihi.ToString("d  M  yyyy"), Bilgi.genelBilgi.DonusTarihi.ToString("d  M  yyyy"), Bilgi.genelBilgi.KonaklamaSekli, Bilgi.genelBilgi.UlasimSekli));

            return sb.ToString();
        }

        public override string İcerikGetir()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format("<h2>DetayliBilgi</h2> <p>{0}</p> <p>{1}</p> <p>{2}</p> <p>{3}</p> <p>{4}</p>", Bilgi.detayliBilgi.Ad, Bilgi.detayliBilgi.Soyad, Bilgi.detayliBilgi.GidisYeri, Bilgi.detayliBilgi.TCNo, Bilgi.detayliBilgi.CepNo));

            return sb.ToString();
        }

        public override string FooterGetir()
        {
            return string.Format("<h2>Fiyat</h2> <p>{0}</p>", this.Bilgi.fiyat);
        }
    }
}
