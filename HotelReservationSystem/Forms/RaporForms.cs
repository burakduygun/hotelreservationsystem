using System.Windows.Forms;
using HotelReservationSystem.Bilgi;
using HotelReservationSystem.Builder.Somut;
using HotelReservationSystem.Builder.Soyut;

namespace HotelReservationSystem.Forms
{
    public partial class RaporForms : Form
    {
        RaporBilgi _raporBilgi;
        RaporBuilder _raporBuilder;

        public RaporForms()
        {
            InitializeComponent();
        }
        public RaporForms(RaporBilgi bilgi) : this()
        {
            _raporBilgi = bilgi;
        }

        private void btn_Json_Click(object sender, System.EventArgs e)
        {
            _raporBuilder = new JsonRaporBuilder(_raporBilgi);
            RaporYonetici reportManager = new RaporYonetici(_raporBuilder);

            string str = reportManager.RaporİnsaEt();

            System.IO.File.WriteAllText(@"D:\pathJson.json", str);
        }

        private void btn_XML_Click(object sender, System.EventArgs e)
        {
            _raporBuilder = new XMLRaporBuilder(_raporBilgi);
            RaporYonetici reportManager = new RaporYonetici(_raporBuilder);

            string str = reportManager.RaporİnsaEt();
            System.IO.File.WriteAllText(@"D:\pathXML.xml", str);
        }

        private void btn_HTML_Click(object sender, System.EventArgs e)
        {
            _raporBuilder = new HTMLRaporBuilder(_raporBilgi);
            RaporYonetici reportManager = new RaporYonetici(_raporBuilder);

            string str = reportManager.RaporİnsaEt();
            System.IO.File.WriteAllText(@"D:\pathHTML.html", str);
        }
    }
}
