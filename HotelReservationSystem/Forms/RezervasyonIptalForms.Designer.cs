
namespace HotelReservationSystem.Forms
{
    partial class RezervasyonIptalForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervasyonIptalForms));
            this.g_elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.g_DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.lblUlasimSekli = new System.Windows.Forms.Label();
            this.txtUlasimSekli = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRaporAl = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtGidisYeri = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSoyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDonusTarihi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTCNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGidisTarihi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFiyat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtKonaklamaSekli = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIsim = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCepNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDonusTarihi = new System.Windows.Forms.Label();
            this.txtCepNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGidisTarihi = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.lblGidisYeri = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // g_elipse
            // 
            this.g_elipse.BorderRadius = 20;
            this.g_elipse.TargetControl = this;
            // 
            // g_DragControl
            // 
            this.g_DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.g_DragControl.TargetControl = this;
            this.g_DragControl.UseTransparentDrag = true;
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btnExit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnExit.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(744, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 45);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblUlasimSekli
            // 
            this.lblUlasimSekli.AutoSize = true;
            this.lblUlasimSekli.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUlasimSekli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblUlasimSekli.Location = new System.Drawing.Point(386, 143);
            this.lblUlasimSekli.Name = "lblUlasimSekli";
            this.lblUlasimSekli.Size = new System.Drawing.Size(103, 19);
            this.lblUlasimSekli.TabIndex = 33;
            this.lblUlasimSekli.Text = "Ulaşım Şekli:";
            // 
            // txtUlasimSekli
            // 
            this.txtUlasimSekli.Animated = true;
            this.txtUlasimSekli.BorderRadius = 16;
            this.txtUlasimSekli.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUlasimSekli.DefaultText = "";
            this.txtUlasimSekli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUlasimSekli.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUlasimSekli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUlasimSekli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUlasimSekli.Enabled = false;
            this.txtUlasimSekli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUlasimSekli.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.txtUlasimSekli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtUlasimSekli.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUlasimSekli.Location = new System.Drawing.Point(546, 130);
            this.txtUlasimSekli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUlasimSekli.MaxLength = 11;
            this.txtUlasimSekli.Name = "txtUlasimSekli";
            this.txtUlasimSekli.PasswordChar = '\0';
            this.txtUlasimSekli.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtUlasimSekli.PlaceholderText = "";
            this.txtUlasimSekli.SelectedText = "";
            this.txtUlasimSekli.Size = new System.Drawing.Size(200, 39);
            this.txtUlasimSekli.TabIndex = 32;
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.Animated = true;
            this.btnRaporAl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btnRaporAl.BorderRadius = 16;
            this.btnRaporAl.BorderThickness = 1;
            this.btnRaporAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRaporAl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRaporAl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRaporAl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRaporAl.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRaporAl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRaporAl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btnRaporAl.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(207)))));
            this.btnRaporAl.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRaporAl.ForeColor = System.Drawing.Color.White;
            this.btnRaporAl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btnRaporAl.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btnRaporAl.HoverState.FillColor = System.Drawing.Color.White;
            this.btnRaporAl.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btnRaporAl.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btnRaporAl.Location = new System.Drawing.Point(550, 392);
            this.btnRaporAl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(180, 46);
            this.btnRaporAl.TabIndex = 31;
            this.btnRaporAl.Text = "Rapor Al";
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click);
            // 
            // txtGidisYeri
            // 
            this.txtGidisYeri.Animated = true;
            this.txtGidisYeri.BorderRadius = 16;
            this.txtGidisYeri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGidisYeri.DefaultText = "";
            this.txtGidisYeri.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGidisYeri.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGidisYeri.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGidisYeri.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGidisYeri.Enabled = false;
            this.txtGidisYeri.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGidisYeri.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.txtGidisYeri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtGidisYeri.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGidisYeri.Location = new System.Drawing.Point(546, 190);
            this.txtGidisYeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGidisYeri.Name = "txtGidisYeri";
            this.txtGidisYeri.PasswordChar = '\0';
            this.txtGidisYeri.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtGidisYeri.PlaceholderText = "";
            this.txtGidisYeri.SelectedText = "";
            this.txtGidisYeri.Size = new System.Drawing.Size(200, 39);
            this.txtGidisYeri.TabIndex = 16;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Animated = true;
            this.txtSoyad.BorderRadius = 16;
            this.txtSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoyad.DefaultText = "";
            this.txtSoyad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoyad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoyad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoyad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoyad.Enabled = false;
            this.txtSoyad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoyad.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.txtSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtSoyad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoyad.Location = new System.Drawing.Point(167, 250);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.PasswordChar = '\0';
            this.txtSoyad.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtSoyad.PlaceholderText = "";
            this.txtSoyad.SelectedText = "";
            this.txtSoyad.Size = new System.Drawing.Size(200, 39);
            this.txtSoyad.TabIndex = 17;
            // 
            // txtDonusTarihi
            // 
            this.txtDonusTarihi.Animated = true;
            this.txtDonusTarihi.BorderRadius = 16;
            this.txtDonusTarihi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonusTarihi.DefaultText = "";
            this.txtDonusTarihi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDonusTarihi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDonusTarihi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonusTarihi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonusTarihi.Enabled = false;
            this.txtDonusTarihi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonusTarihi.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.txtDonusTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtDonusTarihi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonusTarihi.Location = new System.Drawing.Point(546, 310);
            this.txtDonusTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonusTarihi.MaxLength = 11;
            this.txtDonusTarihi.Name = "txtDonusTarihi";
            this.txtDonusTarihi.PasswordChar = '\0';
            this.txtDonusTarihi.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtDonusTarihi.PlaceholderText = "";
            this.txtDonusTarihi.SelectedText = "";
            this.txtDonusTarihi.Size = new System.Drawing.Size(200, 39);
            this.txtDonusTarihi.TabIndex = 18;
            // 
            // txtTCNo
            // 
            this.txtTCNo.Animated = true;
            this.txtTCNo.BorderRadius = 16;
            this.txtTCNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTCNo.DefaultText = "";
            this.txtTCNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTCNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTCNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTCNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTCNo.Enabled = false;
            this.txtTCNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTCNo.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.txtTCNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtTCNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTCNo.Location = new System.Drawing.Point(167, 70);
            this.txtTCNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTCNo.MaxLength = 11;
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.PasswordChar = '\0';
            this.txtTCNo.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtTCNo.PlaceholderText = "";
            this.txtTCNo.SelectedText = "";
            this.txtTCNo.Size = new System.Drawing.Size(200, 39);
            this.txtTCNo.TabIndex = 19;
            // 
            // txtGidisTarihi
            // 
            this.txtGidisTarihi.Animated = true;
            this.txtGidisTarihi.BorderRadius = 16;
            this.txtGidisTarihi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGidisTarihi.DefaultText = "";
            this.txtGidisTarihi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGidisTarihi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGidisTarihi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGidisTarihi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGidisTarihi.Enabled = false;
            this.txtGidisTarihi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGidisTarihi.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.txtGidisTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtGidisTarihi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGidisTarihi.Location = new System.Drawing.Point(546, 250);
            this.txtGidisTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGidisTarihi.MaxLength = 11;
            this.txtGidisTarihi.Name = "txtGidisTarihi";
            this.txtGidisTarihi.PasswordChar = '\0';
            this.txtGidisTarihi.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtGidisTarihi.PlaceholderText = "";
            this.txtGidisTarihi.SelectedText = "";
            this.txtGidisTarihi.Size = new System.Drawing.Size(200, 39);
            this.txtGidisTarihi.TabIndex = 20;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Animated = true;
            this.txtFiyat.BorderRadius = 16;
            this.txtFiyat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiyat.DefaultText = "";
            this.txtFiyat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFiyat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFiyat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiyat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFiyat.Enabled = false;
            this.txtFiyat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiyat.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.txtFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtFiyat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFiyat.Location = new System.Drawing.Point(167, 310);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiyat.MaxLength = 11;
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.PasswordChar = '\0';
            this.txtFiyat.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtFiyat.PlaceholderText = "";
            this.txtFiyat.SelectedText = "";
            this.txtFiyat.Size = new System.Drawing.Size(200, 39);
            this.txtFiyat.TabIndex = 21;
            // 
            // txtKonaklamaSekli
            // 
            this.txtKonaklamaSekli.Animated = true;
            this.txtKonaklamaSekli.BorderRadius = 16;
            this.txtKonaklamaSekli.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKonaklamaSekli.DefaultText = "";
            this.txtKonaklamaSekli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKonaklamaSekli.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKonaklamaSekli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKonaklamaSekli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKonaklamaSekli.Enabled = false;
            this.txtKonaklamaSekli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKonaklamaSekli.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.txtKonaklamaSekli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtKonaklamaSekli.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKonaklamaSekli.Location = new System.Drawing.Point(546, 70);
            this.txtKonaklamaSekli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKonaklamaSekli.Name = "txtKonaklamaSekli";
            this.txtKonaklamaSekli.PasswordChar = '\0';
            this.txtKonaklamaSekli.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtKonaklamaSekli.PlaceholderText = "";
            this.txtKonaklamaSekli.SelectedText = "";
            this.txtKonaklamaSekli.Size = new System.Drawing.Size(200, 39);
            this.txtKonaklamaSekli.TabIndex = 14;
            // 
            // txtIsim
            // 
            this.txtIsim.Animated = true;
            this.txtIsim.BorderRadius = 16;
            this.txtIsim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIsim.DefaultText = "";
            this.txtIsim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIsim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIsim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIsim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIsim.Enabled = false;
            this.txtIsim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIsim.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.txtIsim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtIsim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIsim.Location = new System.Drawing.Point(167, 190);
            this.txtIsim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.PasswordChar = '\0';
            this.txtIsim.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtIsim.PlaceholderText = "";
            this.txtIsim.SelectedText = "";
            this.txtIsim.Size = new System.Drawing.Size(200, 39);
            this.txtIsim.TabIndex = 15;
            // 
            // lblCepNo
            // 
            this.lblCepNo.AutoSize = true;
            this.lblCepNo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCepNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblCepNo.Location = new System.Drawing.Point(25, 150);
            this.lblCepNo.Name = "lblCepNo";
            this.lblCepNo.Size = new System.Drawing.Size(114, 19);
            this.lblCepNo.TabIndex = 22;
            this.lblCepNo.Text = "Cep Telefonu: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(386, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Konaklama Şekli:";
            // 
            // lblDonusTarihi
            // 
            this.lblDonusTarihi.AutoSize = true;
            this.lblDonusTarihi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDonusTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblDonusTarihi.Location = new System.Drawing.Point(384, 325);
            this.lblDonusTarihi.Name = "lblDonusTarihi";
            this.lblDonusTarihi.Size = new System.Drawing.Size(105, 19);
            this.lblDonusTarihi.TabIndex = 27;
            this.lblDonusTarihi.Text = "Dönüş Tarihi:";
            // 
            // txtCepNo
            // 
            this.txtCepNo.Animated = true;
            this.txtCepNo.BorderRadius = 16;
            this.txtCepNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCepNo.DefaultText = "";
            this.txtCepNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCepNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCepNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCepNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCepNo.Enabled = false;
            this.txtCepNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCepNo.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.txtCepNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtCepNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCepNo.Location = new System.Drawing.Point(167, 130);
            this.txtCepNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCepNo.MaxLength = 11;
            this.txtCepNo.Name = "txtCepNo";
            this.txtCepNo.PasswordChar = '\0';
            this.txtCepNo.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txtCepNo.PlaceholderText = "";
            this.txtCepNo.SelectedText = "";
            this.txtCepNo.Size = new System.Drawing.Size(200, 39);
            this.txtCepNo.TabIndex = 13;
            // 
            // lblGidisTarihi
            // 
            this.lblGidisTarihi.AutoSize = true;
            this.lblGidisTarihi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGidisTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblGidisTarihi.Location = new System.Drawing.Point(384, 266);
            this.lblGidisTarihi.Name = "lblGidisTarihi";
            this.lblGidisTarihi.Size = new System.Drawing.Size(95, 19);
            this.lblGidisTarihi.TabIndex = 28;
            this.lblGidisTarihi.Text = "Gidiş Tarihi:";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblIsim.Location = new System.Drawing.Point(27, 206);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(44, 19);
            this.lblIsim.TabIndex = 23;
            this.lblIsim.Text = "İsim:";
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblTCNo.Location = new System.Drawing.Point(25, 86);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(108, 19);
            this.lblTCNo.TabIndex = 29;
            this.lblTCNo.Text = "TC Kimlik No:";
            // 
            // lblGidisYeri
            // 
            this.lblGidisYeri.AutoSize = true;
            this.lblGidisYeri.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGidisYeri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblGidisYeri.Location = new System.Drawing.Point(386, 206);
            this.lblGidisYeri.Name = "lblGidisYeri";
            this.lblGidisYeri.Size = new System.Drawing.Size(84, 19);
            this.lblGidisYeri.TabIndex = 25;
            this.lblGidisYeri.Text = "Gidiş Yeri:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblFiyat.Location = new System.Drawing.Point(25, 330);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(50, 19);
            this.lblFiyat.TabIndex = 30;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblSoyad.Location = new System.Drawing.Point(25, 265);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(61, 19);
            this.lblSoyad.TabIndex = 26;
            this.lblSoyad.Text = "Soyad:";
            // 
            // RezervasyonIptalForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(794, 458);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblUlasimSekli);
            this.Controls.Add(this.txtUlasimSekli);
            this.Controls.Add(this.btnRaporAl);
            this.Controls.Add(this.txtGidisYeri);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtDonusTarihi);
            this.Controls.Add(this.txtTCNo);
            this.Controls.Add(this.txtGidisTarihi);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtKonaklamaSekli);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.lblCepNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDonusTarihi);
            this.Controls.Add(this.txtCepNo);
            this.Controls.Add(this.lblGidisTarihi);
            this.Controls.Add(this.lblIsim);
            this.Controls.Add(this.lblTCNo);
            this.Controls.Add(this.lblGidisYeri);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblSoyad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RezervasyonIptalForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RezervasyonIptalForms";
            this.Load += new System.EventHandler(this.RezervasyonIptalForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse g_elipse;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Label lblUlasimSekli;
        private Guna.UI2.WinForms.Guna2TextBox txtUlasimSekli;
        private Guna.UI2.WinForms.Guna2GradientButton btnRaporAl;
        private Guna.UI2.WinForms.Guna2TextBox txtGidisYeri;
        private Guna.UI2.WinForms.Guna2TextBox txtSoyad;
        private Guna.UI2.WinForms.Guna2TextBox txtDonusTarihi;
        private Guna.UI2.WinForms.Guna2TextBox txtTCNo;
        private Guna.UI2.WinForms.Guna2TextBox txtGidisTarihi;
        private Guna.UI2.WinForms.Guna2TextBox txtFiyat;
        private Guna.UI2.WinForms.Guna2TextBox txtKonaklamaSekli;
        private Guna.UI2.WinForms.Guna2TextBox txtIsim;
        private System.Windows.Forms.Label lblCepNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDonusTarihi;
        private Guna.UI2.WinForms.Guna2TextBox txtCepNo;
        private System.Windows.Forms.Label lblGidisTarihi;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.Label lblGidisYeri;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblSoyad;
        private Guna.UI2.WinForms.Guna2DragControl g_DragControl;
    }
}