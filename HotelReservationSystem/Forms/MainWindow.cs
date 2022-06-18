using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HotelReservationSystem.Bilgi;
using HotelReservationSystem.Factory.Somut;
using HotelReservationSystem.Factory.Soyut;

namespace HotelReservationSystem.Forms
{
    public partial class MainWindow : Form
    {
        private GenelBilgi _genelBilgi = new GenelBilgi();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_RezervasyonListele_Click(object sender, EventArgs e)
        {
            RezervasyonFactory _factory;

            _genelBilgi.KonaklamaSekli = cmb_konaklama.SelectedItem.ToString();
            _genelBilgi.UlasimSekli = cmb_ulasım.SelectedItem.ToString();

            _genelBilgi.GidisTarihi = dtp_gidisTarihi.Value;
            _genelBilgi.DonusTarihi = dtp_donusTarihi.Value;


            if ((int)cmb_konaklama.SelectedValue == 0 && (int)cmb_ulasım.SelectedValue == 0)
            {
                _factory = new OtelUcakFactory();
            }
            else if ((int)cmb_konaklama.SelectedValue == 0 && (int)cmb_ulasım.SelectedValue == 1)
            {
                _factory = new OtelOtobusFactory();
            }
            else if ((int)cmb_konaklama.SelectedValue == 1 && (int)cmb_ulasım.SelectedValue == 0)
            {
                _factory = new CadırUcakFactory();
            }
            else if ((int)cmb_konaklama.SelectedValue == 1 && (int)cmb_ulasım.SelectedValue == 1)
            {
                _factory = new CadırOtobuslFactory();
            }
            else
            {
                throw new Exception("Bilinmeyen Factory uretilmeye calisti");
            }

            StartForms(_factory, _genelBilgi);
        }

        private void StartForms(RezervasyonFactory _factory, GenelBilgi genelBilgi)
        {
            RezervasyonForms rezervasyonForms = new RezervasyonForms(_factory, genelBilgi);
            rezervasyonForms.Show();
            this.Hide();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            List<Cmb> konaklama = new List<Cmb>()
            {
                new Cmb()
                {
                    Id = 0,
                    Name = "Otel"
                },
                new Cmb()
                {
                    Id = 1,
                    Name = "Çadır"
                }
            };
            cmb_konaklama.DataSource = konaklama;
            cmb_konaklama.ValueMember = "Id";
            cmb_konaklama.DisplayMember = "Name";
            List<Cmb> ulasim = new List<Cmb>()
            {
                new Cmb()
                {
                    Id = 0,
                    Name = "Uçak"
                },
                new Cmb()
                {
                    Id = 1,
                    Name = "Otobüs"
                }
            };

            cmb_ulasım.DataSource = ulasim;
            cmb_ulasım.ValueMember = "Id";
            cmb_ulasım.DisplayMember = "Name";


            dtp_gidisTarihi.Value = DateTime.Today;
            dtp_donusTarihi.Value = DateTime.Today;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
