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
using HotelReservationSystem.Depo.Soyut;
using HotelReservationSystem.Entities.Soyut;
using HotelReservationSystem.Factory.Soyut;

namespace HotelReservationSystem.Forms
{
    public partial class RezervasyonForms : Form
    {
        private RezervasyonFactory _rezervasyonFactory;
        private GenelBilgi _genelBilgi;
        private DetayliBilgi _detayliBilgi;

        private int sayac = 180;

        private int kalinanGün = 0;
        private int ulasimFiyat = 0;
        private int konaklamaFiyat = 0;
        private int toplamFiyat = 0;
        private int toplamKonaklamaFiyati = 0;

        public RezervasyonForms(RezervasyonFactory rezervasyonFactory, GenelBilgi genelBilgi)
        {
            InitializeComponent();
            _genelBilgi = genelBilgi;
            _rezervasyonFactory = rezervasyonFactory;
        }

        private void RezervasyonForms_Load(object sender, EventArgs e)
        {
            LoadDgwKonaklama();
        }

        private void LoadDgwKonaklama()
        {
            dgvKonaklama.DataSource = _rezervasyonFactory.KonaklamaGetir(_genelBilgi.GidisTarihi, _genelBilgi.DonusTarihi);
        }

        private void dgvKonaklama_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvUlasim.DataSource = _rezervasyonFactory.UlasimGetir(_genelBilgi.GidisTarihi, _genelBilgi.DonusTarihi)
            .Where(p => p.VarisYeri == dgvKonaklama.CurrentRow.Cells[0].Value.ToString()).ToList();
        }

        private void dgvUlasim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmb_koltukNo.DataSource = new List<int>()
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30};
        }
        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            _rezervasyonFactory.UlasimRezervasyonuYap(new UlasimBilgileri()
            {
                GidisTarihi = _genelBilgi.GidisTarihi,
                DonusTarihi = _genelBilgi.DonusTarihi,
                Koltuk = (int)cmb_koltukNo.SelectedValue
            }, (IUlasimDepo)dgvUlasim.CurrentRow.DataBoundItem);
            _rezervasyonFactory.KonaklamaRezervasyonuYap(new KonaklamaBilgileri()
            {
                GirisTarihi = _genelBilgi.GidisTarihi,
                CikisTarihi = _genelBilgi.DonusTarihi,
            }, (IKonaklamaDepo)dgvKonaklama.CurrentRow.DataBoundItem);


            _detayliBilgi = new DetayliBilgi()
            {
                Ad = txt_isim.Text,
                Soyad = txt_soyad.Text,
                TCNo = txt_TCNo.Text,
                CepNo = txt_cepNo.Text,
                GidisYeri = _rezervasyonFactory.KonaklamaRezervasyon.Konum,
                KoltukNo = _rezervasyonFactory.UlasimRezervasyon.Koltuk
            };

            TimeSpan KGun = _genelBilgi.GidisTarihi.Subtract(_genelBilgi.DonusTarihi);
            kalinanGün = KGun.Days + 1;


            konaklamaFiyat = Convert.ToInt32(dgvKonaklama.CurrentRow.Cells[1].Value);
            ulasimFiyat = Convert.ToInt32(dgvUlasim.CurrentRow.Cells[2].Value);
            toplamKonaklamaFiyati = (kalinanGün * konaklamaFiyat);

            toplamFiyat = (toplamKonaklamaFiyati + ulasimFiyat);
            btnRaporAl.Visible = true;

            BilgilendirmeForms bf = new BilgilendirmeForms();
            bf.Show();

            btnRezervasyonIptal.Enabled = true;
            timer1.Start();
        }
        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            RaporBilgi bilgi = new RaporBilgi();
            bilgi.genelBilgi = _genelBilgi;
            bilgi.detayliBilgi = _detayliBilgi;
            bilgi.fiyat = toplamFiyat;

            RaporForms rf = new RaporForms(bilgi);
            rf.ShowDialog();
        }

        private void btnRezervasyonIptal_Click(object sender, EventArgs e)
        {
            RezervasyonIptalSoruForms rf = new RezervasyonIptalSoruForms(_genelBilgi, _detayliBilgi, toplamFiyat, ulasimFiyat, toplamKonaklamaFiyati);
            this.Hide();
            rf.Show();
        }

        private void txt_TCNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_isim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;

            if (sayac > 0)
            {
                if (sayac <= 10)
                {
                    sayac--;
                    lblSayac.Text = string.Format("00:0{0}:0{1}", sayac / 60, sayac % 60);
                }
                else
                {
                    sayac--;
                    lblSayac.Text = string.Format("00:0{0}:{1}", sayac / 60, sayac % 60);
                }
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}

