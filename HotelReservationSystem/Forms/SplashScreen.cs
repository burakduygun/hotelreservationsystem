using System;
using System.Windows.Forms;

namespace HotelReservationSystem.Forms
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (circleProgressbar.Value == 100)
            {
                timer1.Stop();
                MainWindow MV = new MainWindow();
                MV.Show();
                this.Hide();
            }
            else
            {
                circleProgressbar.Value += 1;
                lblLoading.Text = "Wait A Moments...." + circleProgressbar.Value.ToString() + "%";
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
