using System.Text;
using HotelReservationSystem.Bilgi;
using HotelReservationSystem.Builder.Soyut;

namespace HotelReservationSystem.Builder.Somut
{
    public class JsonRaporBuilder : RaporBuilder
    {
        public JsonRaporBuilder(RaporBilgi raporBilgi) : base(raporBilgi)
        {
        }

        public override string HeaderGetir()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format("[{{ \"Gidis Tarih\": \"{0}\", \"Donus Tarih\": \"{1}\", \"Konaklama Sekli\": \"{2}\", \"Ulasım Sekli\": \"{3}\",", Bilgi.genelBilgi.GidisTarihi.ToString("d  M  yyyy"), Bilgi.genelBilgi.DonusTarihi.ToString("d  M  yyyy"), Bilgi.genelBilgi.KonaklamaSekli, Bilgi.genelBilgi.UlasimSekli));
            return sb.ToString();
        }

        public override string İcerikGetir()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format(" \"Ad\": \"{0}\", \"Soyad\": \"{1}\", \"TCNo\": \"{2}\", \"CepNo\": \"{3}\", \"GidisYeri\": \"{4}\", ", Bilgi.detayliBilgi.Ad, Bilgi.detayliBilgi.Soyad, Bilgi.detayliBilgi.TCNo, Bilgi.detayliBilgi.CepNo, Bilgi.detayliBilgi.GidisYeri));
            return sb.ToString();
        }

        public override string FooterGetir()
        {
            return string.Format(" \"Toplam Fiyat\": {0} }}]", this.Bilgi.fiyat);
        }
    }
}
