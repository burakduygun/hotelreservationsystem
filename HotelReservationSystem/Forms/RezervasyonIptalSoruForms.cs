using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservationSystem.Bilgi;

namespace HotelReservationSystem.Forms
{
    public partial class RezervasyonIptalSoruForms : Form
    {
        GenelBilgi _genelBilgi;
        DetayliBilgi _detayliBilgi;
        int _toplamFiyat;
        int _ulasimFiyat;
        int _toplamKonaklamaFiyati;

        public RezervasyonIptalSoruForms(GenelBilgi genelBilgi, DetayliBilgi detayliBilgi, int toplamFiyat, int ulasimFiyat, int toplamKonaklamaFiyati)
        {
            InitializeComponent();
            _genelBilgi = genelBilgi;
            _detayliBilgi = detayliBilgi;
            _toplamFiyat = toplamFiyat;
            _toplamKonaklamaFiyati = toplamKonaklamaFiyati;
            _ulasimFiyat = ulasimFiyat;
        }

        private void btnUlasim_Click(object sender, EventArgs e)
        {
            _genelBilgi.KonaklamaSekli = string.Empty;
            _toplamFiyat = (_toplamFiyat - _toplamKonaklamaFiyati);
            SoruForms sf = new SoruForms(_genelBilgi, _detayliBilgi, _toplamFiyat);
            sf.Show();
            this.Hide();
        }

        private void btnKonaklama_Click(object sender, EventArgs e)
        {
            _genelBilgi.UlasimSekli = string.Empty;
            _toplamFiyat = (_toplamFiyat - _ulasimFiyat);
            SoruForms sf = new SoruForms(_genelBilgi, _detayliBilgi, _toplamFiyat);
            sf.Show();
            this.Hide();
        }
    }
}
