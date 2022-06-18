using System;
using System.Windows.Forms;
using HotelReservationSystem.Bilgi;

namespace HotelReservationSystem.Forms
{
    public partial class SoruForms : Form
    {
        GenelBilgi _genelBilgi;
        DetayliBilgi _detayliBilgi;
        int _toplamFiyat = 0;

        public SoruForms(GenelBilgi genelBilgi, DetayliBilgi detayliBilgi, int toplamFiyat)
        {
            InitializeComponent();
            _genelBilgi = genelBilgi;
            _detayliBilgi = detayliBilgi;
            _toplamFiyat = toplamFiyat;
        }

        private void btnEvet_Click(object sender, EventArgs e)
        {
            _genelBilgi.GidisTarihi = default(DateTime);
            _genelBilgi.DonusTarihi = default(DateTime);
            _detayliBilgi.Ad = string.Empty;
            _detayliBilgi.Soyad = string.Empty;
            _detayliBilgi.GidisYeri = string.Empty;
            _detayliBilgi.TCNo = string.Empty;
            _detayliBilgi.CepNo = string.Empty;
            _toplamFiyat = 0;
            _genelBilgi.KonaklamaSekli = string.Empty;
            _genelBilgi.UlasimSekli = string.Empty;
            RezervasyonIptalForms rf = new RezervasyonIptalForms(_genelBilgi, _detayliBilgi, _toplamFiyat);
            rf.Show();
            this.Hide();
        }

        private void btnHayır_Click(object sender, EventArgs e)
        {
            RezervasyonIptalForms rf = new RezervasyonIptalForms(_genelBilgi, _detayliBilgi, _toplamFiyat);
            rf.Show();
            this.Hide();
        }
    }
}
