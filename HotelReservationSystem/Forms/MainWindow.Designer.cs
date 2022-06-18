
namespace HotelReservationSystem.Forms
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.g_elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.g_DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ComboBox3 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_ulasım = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_konaklama = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_ulasim = new System.Windows.Forms.Label();
            this.lbl_konaklama = new System.Windows.Forms.Label();
            this.grpbox_Rezervasyon = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtp_donusTarihi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_gidisTarihi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl_donusTarihi = new System.Windows.Forms.Label();
            this.lbl_gidisTarihi = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btn_RezervasyonListele = new Guna.UI2.WinForms.Guna2GradientButton();
            this.grpbox_Rezervasyon.SuspendLayout();
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
            // guna2ComboBox3
            // 
            this.guna2ComboBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox3.BorderRadius = 16;
            this.guna2ComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox3.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2ComboBox3.ItemHeight = 30;
            this.guna2ComboBox3.Location = new System.Drawing.Point(2245, 226);
            this.guna2ComboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ComboBox3.Name = "guna2ComboBox3";
            this.guna2ComboBox3.Size = new System.Drawing.Size(200, 36);
            this.guna2ComboBox3.TabIndex = 4;
            // 
            // cmb_ulasım
            // 
            this.cmb_ulasım.BackColor = System.Drawing.Color.Transparent;
            this.cmb_ulasım.BorderRadius = 16;
            this.cmb_ulasım.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_ulasım.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ulasım.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_ulasım.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_ulasım.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.cmb_ulasım.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cmb_ulasım.ItemHeight = 30;
            this.cmb_ulasım.Location = new System.Drawing.Point(248, 121);
            this.cmb_ulasım.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_ulasım.Name = "cmb_ulasım";
            this.cmb_ulasım.Size = new System.Drawing.Size(231, 36);
            this.cmb_ulasım.TabIndex = 1;
            // 
            // cmb_konaklama
            // 
            this.cmb_konaklama.AutoRoundedCorners = true;
            this.cmb_konaklama.BackColor = System.Drawing.Color.Transparent;
            this.cmb_konaklama.BorderRadius = 17;
            this.cmb_konaklama.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_konaklama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_konaklama.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_konaklama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_konaklama.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.cmb_konaklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cmb_konaklama.ItemHeight = 30;
            this.cmb_konaklama.Location = new System.Drawing.Point(248, 60);
            this.cmb_konaklama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_konaklama.Name = "cmb_konaklama";
            this.cmb_konaklama.Size = new System.Drawing.Size(231, 36);
            this.cmb_konaklama.TabIndex = 0;
            // 
            // lbl_ulasim
            // 
            this.lbl_ulasim.AutoSize = true;
            this.lbl_ulasim.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ulasim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbl_ulasim.Location = new System.Drawing.Point(19, 137);
            this.lbl_ulasim.Name = "lbl_ulasim";
            this.lbl_ulasim.Size = new System.Drawing.Size(169, 19);
            this.lbl_ulasim.TabIndex = 5;
            this.lbl_ulasim.Text = "Ulaşım şeklini seçiniz:";
            // 
            // lbl_konaklama
            // 
            this.lbl_konaklama.AutoSize = true;
            this.lbl_konaklama.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_konaklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbl_konaklama.Location = new System.Drawing.Point(19, 73);
            this.lbl_konaklama.Name = "lbl_konaklama";
            this.lbl_konaklama.Size = new System.Drawing.Size(200, 19);
            this.lbl_konaklama.TabIndex = 4;
            this.lbl_konaklama.Text = "Konaklama şeklini seçiniz:";
            // 
            // grpbox_Rezervasyon
            // 
            this.grpbox_Rezervasyon.BackColor = System.Drawing.Color.Transparent;
            this.grpbox_Rezervasyon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.grpbox_Rezervasyon.BorderRadius = 16;
            this.grpbox_Rezervasyon.Controls.Add(this.dtp_donusTarihi);
            this.grpbox_Rezervasyon.Controls.Add(this.dtp_gidisTarihi);
            this.grpbox_Rezervasyon.Controls.Add(this.lbl_donusTarihi);
            this.grpbox_Rezervasyon.Controls.Add(this.lbl_gidisTarihi);
            this.grpbox_Rezervasyon.Controls.Add(this.guna2ComboBox3);
            this.grpbox_Rezervasyon.Controls.Add(this.cmb_ulasım);
            this.grpbox_Rezervasyon.Controls.Add(this.cmb_konaklama);
            this.grpbox_Rezervasyon.Controls.Add(this.lbl_ulasim);
            this.grpbox_Rezervasyon.Controls.Add(this.lbl_konaklama);
            this.grpbox_Rezervasyon.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.grpbox_Rezervasyon.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbox_Rezervasyon.ForeColor = System.Drawing.Color.White;
            this.grpbox_Rezervasyon.Location = new System.Drawing.Point(24, 74);
            this.grpbox_Rezervasyon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbox_Rezervasyon.Name = "grpbox_Rezervasyon";
            this.grpbox_Rezervasyon.Size = new System.Drawing.Size(493, 306);
            this.grpbox_Rezervasyon.TabIndex = 7;
            this.grpbox_Rezervasyon.Text = "Rezervasyon Bilgileri";
            // 
            // dtp_donusTarihi
            // 
            this.dtp_donusTarihi.Animated = true;
            this.dtp_donusTarihi.BackColor = System.Drawing.Color.White;
            this.dtp_donusTarihi.BorderRadius = 16;
            this.dtp_donusTarihi.Checked = true;
            this.dtp_donusTarihi.FillColor = System.Drawing.Color.White;
            this.dtp_donusTarihi.Font = new System.Drawing.Font("Arial", 10.2F);
            this.dtp_donusTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dtp_donusTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_donusTarihi.Location = new System.Drawing.Point(248, 241);
            this.dtp_donusTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_donusTarihi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_donusTarihi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_donusTarihi.Name = "dtp_donusTarihi";
            this.dtp_donusTarihi.Size = new System.Drawing.Size(149, 39);
            this.dtp_donusTarihi.TabIndex = 3;
            this.dtp_donusTarihi.Value = new System.DateTime(2022, 5, 25, 0, 0, 0, 0);
            // 
            // dtp_gidisTarihi
            // 
            this.dtp_gidisTarihi.Animated = true;
            this.dtp_gidisTarihi.BackColor = System.Drawing.Color.White;
            this.dtp_gidisTarihi.BorderRadius = 16;
            this.dtp_gidisTarihi.Checked = true;
            this.dtp_gidisTarihi.FillColor = System.Drawing.Color.White;
            this.dtp_gidisTarihi.Font = new System.Drawing.Font("Arial", 10.2F);
            this.dtp_gidisTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dtp_gidisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_gidisTarihi.Location = new System.Drawing.Point(248, 181);
            this.dtp_gidisTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_gidisTarihi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_gidisTarihi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_gidisTarihi.Name = "dtp_gidisTarihi";
            this.dtp_gidisTarihi.Size = new System.Drawing.Size(149, 39);
            this.dtp_gidisTarihi.TabIndex = 2;
            this.dtp_gidisTarihi.Value = new System.DateTime(2022, 5, 25, 0, 0, 0, 0);
            // 
            // lbl_donusTarihi
            // 
            this.lbl_donusTarihi.AutoSize = true;
            this.lbl_donusTarihi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_donusTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbl_donusTarihi.Location = new System.Drawing.Point(19, 261);
            this.lbl_donusTarihi.Name = "lbl_donusTarihi";
            this.lbl_donusTarihi.Size = new System.Drawing.Size(105, 19);
            this.lbl_donusTarihi.TabIndex = 7;
            this.lbl_donusTarihi.Text = "Dönüş Tarihi:";
            // 
            // lbl_gidisTarihi
            // 
            this.lbl_gidisTarihi.AutoSize = true;
            this.lbl_gidisTarihi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gidisTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbl_gidisTarihi.Location = new System.Drawing.Point(19, 201);
            this.lbl_gidisTarihi.Name = "lbl_gidisTarihi";
            this.lbl_gidisTarihi.Size = new System.Drawing.Size(95, 19);
            this.lbl_gidisTarihi.TabIndex = 6;
            this.lbl_gidisTarihi.Text = "Gidiş Tarihi:";
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Empty;
            this.btnExit.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnExit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnExit.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(703, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 34);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnMinimize.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btnMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btnMinimize.Location = new System.Drawing.Point(647, 4);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(51, 34);
            this.btnMinimize.TabIndex = 6;
            // 
            // btn_RezervasyonListele
            // 
            this.btn_RezervasyonListele.Animated = true;
            this.btn_RezervasyonListele.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btn_RezervasyonListele.BorderRadius = 21;
            this.btn_RezervasyonListele.BorderThickness = 1;
            this.btn_RezervasyonListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RezervasyonListele.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_RezervasyonListele.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_RezervasyonListele.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_RezervasyonListele.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_RezervasyonListele.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_RezervasyonListele.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btn_RezervasyonListele.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(207)))));
            this.btn_RezervasyonListele.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_RezervasyonListele.ForeColor = System.Drawing.Color.White;
            this.btn_RezervasyonListele.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btn_RezervasyonListele.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btn_RezervasyonListele.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_RezervasyonListele.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btn_RezervasyonListele.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btn_RezervasyonListele.Location = new System.Drawing.Point(536, 74);
            this.btn_RezervasyonListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RezervasyonListele.Name = "btn_RezervasyonListele";
            this.btn_RezervasyonListele.Size = new System.Drawing.Size(179, 54);
            this.btn_RezervasyonListele.TabIndex = 5;
            this.btn_RezervasyonListele.Text = "Rezervasyon  Listele";
            this.btn_RezervasyonListele.Click += new System.EventHandler(this.btn_RezervasyonListele_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(757, 458);
            this.Controls.Add(this.grpbox_Rezervasyon);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btn_RezervasyonListele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.grpbox_Rezervasyon.ResumeLayout(false);
            this.grpbox_Rezervasyon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse g_elipse;
        private Guna.UI2.WinForms.Guna2GroupBox grpbox_Rezervasyon;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_donusTarihi;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_gidisTarihi;
        private System.Windows.Forms.Label lbl_donusTarihi;
        private System.Windows.Forms.Label lbl_gidisTarihi;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox3;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_ulasım;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_konaklama;
        private System.Windows.Forms.Label lbl_ulasim;
        private System.Windows.Forms.Label lbl_konaklama;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Guna.UI2.WinForms.Guna2GradientButton btn_RezervasyonListele;
        private Guna.UI2.WinForms.Guna2DragControl g_DragControl;
    }
}