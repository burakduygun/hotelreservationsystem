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
    public partial class RezervasyonIptalForms : Form
    {
        GenelBilgi _genelBilgi;
        DetayliBilgi _detayliBilgi;
        int _toplamFiyat = 0;

        public RezervasyonIptalForms(GenelBilgi genelBilgi, DetayliBilgi detayliBilgi, int toplamFiyat)
        {
            InitializeComponent();
            _genelBilgi = genelBilgi;
            _detayliBilgi = detayliBilgi;
            _toplamFiyat = toplamFiyat;
        }
        private void RezervasyonIptalForms_Load(object sender, EventArgs e)
        {
            txtTCNo.Text = _detayliBilgi.TCNo;
            txtCepNo.Text = _detayliBilgi.CepNo;
            txtFiyat.Text = _detayliBilgi.CepNo;
            txtIsim.Text = _detayliBilgi.Ad;
            txtSoyad.Text = _detayliBilgi.Soyad;
            txtFiyat.Text = _toplamFiyat.ToString();
            txtKonaklamaSekli.Text = _genelBilgi.KonaklamaSekli;
            txtUlasimSekli.Text = _genelBilgi.UlasimSekli;
            txtGidisYeri.Text = _detayliBilgi.GidisYeri;
            txtGidisTarihi.Text = _genelBilgi.GidisTarihi.ToString();
            txtDonusTarihi.Text = _genelBilgi.DonusTarihi.ToString();
        }

        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            RaporBilgi bilgi = new RaporBilgi();
            bilgi.genelBilgi = _genelBilgi;
            bilgi.detayliBilgi = _detayliBilgi;
            bilgi.fiyat = _toplamFiyat;

            RaporForms rf = new RaporForms(bilgi);
            rf.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
