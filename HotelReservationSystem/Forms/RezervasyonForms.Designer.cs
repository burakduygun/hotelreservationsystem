
namespace HotelReservationSystem.Forms
{
    partial class RezervasyonForms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervasyonForms));
            this.g_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.g_DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSayac = new System.Windows.Forms.Label();
            this.btnRaporAl = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnRezervasyonIptal = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnRezervasyonYap = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblKoltukNo = new System.Windows.Forms.Label();
            this.cmb_koltukNo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvUlasim = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvKonaklama = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.grpbox_Kisi = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txt_soyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_cepNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_isim = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_TCNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_cepNo = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.lbl_tcNo = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUlasim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonaklama)).BeginInit();
            this.grpbox_Kisi.SuspendLayout();
            this.SuspendLayout();
            // 
            // g_Elipse
            // 
            this.g_Elipse.BorderRadius = 20;
            this.g_Elipse.TargetControl = this;
            // 
            // g_DragControl
            // 
            this.g_DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.g_DragControl.UseTransparentDrag = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblSayac.Location = new System.Drawing.Point(40, 445);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(0, 19);
            this.lblSayac.TabIndex = 20;
            this.lblSayac.Visible = false;
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
            this.btnRaporAl.Location = new System.Drawing.Point(222, 567);
            this.btnRaporAl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(180, 46);
            this.btnRaporAl.TabIndex = 19;
            this.btnRaporAl.Text = "Rapor Al";
            this.btnRaporAl.Visible = false;
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click);
            // 
            // btnRezervasyonIptal
            // 
            this.btnRezervasyonIptal.Animated = true;
            this.btnRezervasyonIptal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btnRezervasyonIptal.BorderRadius = 16;
            this.btnRezervasyonIptal.BorderThickness = 1;
            this.btnRezervasyonIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezervasyonIptal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRezervasyonIptal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRezervasyonIptal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRezervasyonIptal.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRezervasyonIptal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRezervasyonIptal.Enabled = false;
            this.btnRezervasyonIptal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btnRezervasyonIptal.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(207)))));
            this.btnRezervasyonIptal.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRezervasyonIptal.ForeColor = System.Drawing.Color.White;
            this.btnRezervasyonIptal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btnRezervasyonIptal.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btnRezervasyonIptal.HoverState.FillColor = System.Drawing.Color.White;
            this.btnRezervasyonIptal.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btnRezervasyonIptal.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btnRezervasyonIptal.Location = new System.Drawing.Point(222, 497);
            this.btnRezervasyonIptal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRezervasyonIptal.Name = "btnRezervasyonIptal";
            this.btnRezervasyonIptal.Size = new System.Drawing.Size(180, 46);
            this.btnRezervasyonIptal.TabIndex = 13;
            this.btnRezervasyonIptal.Text = "Rezervasyon İptal";
            this.btnRezervasyonIptal.Click += new System.EventHandler(this.btnRezervasyonIptal_Click);
            // 
            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.Animated = true;
            this.btnRezervasyonYap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btnRezervasyonYap.BorderRadius = 16;
            this.btnRezervasyonYap.BorderThickness = 1;
            this.btnRezervasyonYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezervasyonYap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRezervasyonYap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRezervasyonYap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRezervasyonYap.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRezervasyonYap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRezervasyonYap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btnRezervasyonYap.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(118)))), ((int)(((byte)(207)))));
            this.btnRezervasyonYap.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnRezervasyonYap.ForeColor = System.Drawing.Color.White;
            this.btnRezervasyonYap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btnRezervasyonYap.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btnRezervasyonYap.HoverState.FillColor = System.Drawing.Color.White;
            this.btnRezervasyonYap.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btnRezervasyonYap.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btnRezervasyonYap.Location = new System.Drawing.Point(222, 427);
            this.btnRezervasyonYap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(180, 46);
            this.btnRezervasyonYap.TabIndex = 14;
            this.btnRezervasyonYap.Text = "Rezervasyon Yap";
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);
            // 
            // lblKoltukNo
            // 
            this.lblKoltukNo.AutoSize = true;
            this.lblKoltukNo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKoltukNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lblKoltukNo.Location = new System.Drawing.Point(39, 388);
            this.lblKoltukNo.Name = "lblKoltukNo";
            this.lblKoltukNo.Size = new System.Drawing.Size(133, 19);
            this.lblKoltukNo.TabIndex = 17;
            this.lblKoltukNo.Text = "Koltuk Numarası:";
            // 
            // cmb_koltukNo
            // 
            this.cmb_koltukNo.BackColor = System.Drawing.Color.Transparent;
            this.cmb_koltukNo.BorderRadius = 16;
            this.cmb_koltukNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_koltukNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_koltukNo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_koltukNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_koltukNo.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.cmb_koltukNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.cmb_koltukNo.ItemHeight = 30;
            this.cmb_koltukNo.Location = new System.Drawing.Point(197, 371);
            this.cmb_koltukNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_koltukNo.Name = "cmb_koltukNo";
            this.cmb_koltukNo.Size = new System.Drawing.Size(205, 36);
            this.cmb_koltukNo.TabIndex = 12;
            // 
            // dgvUlasim
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUlasim.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUlasim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUlasim.BackgroundColor = System.Drawing.Color.White;
            this.dgvUlasim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUlasim.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUlasim.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUlasim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUlasim.ColumnHeadersHeight = 27;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUlasim.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUlasim.EnableHeadersVisualStyles = false;
            this.dgvUlasim.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUlasim.Location = new System.Drawing.Point(433, 368);
            this.dgvUlasim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUlasim.Name = "dgvUlasim";
            this.dgvUlasim.ReadOnly = true;
            this.dgvUlasim.RowHeadersVisible = false;
            this.dgvUlasim.RowHeadersWidth = 51;
            this.dgvUlasim.RowTemplate.Height = 24;
            this.dgvUlasim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUlasim.Size = new System.Drawing.Size(708, 299);
            this.dgvUlasim.TabIndex = 11;
            this.dgvUlasim.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUlasim.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUlasim.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUlasim.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUlasim.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUlasim.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvUlasim.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUlasim.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.dgvUlasim.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUlasim.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvUlasim.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUlasim.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUlasim.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvUlasim.ThemeStyle.ReadOnly = true;
            this.dgvUlasim.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUlasim.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUlasim.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvUlasim.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUlasim.ThemeStyle.RowsStyle.Height = 24;
            this.dgvUlasim.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUlasim.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUlasim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUlasim_CellClick);
            // 
            // dgvKonaklama
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvKonaklama.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKonaklama.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKonaklama.BackgroundColor = System.Drawing.Color.White;
            this.dgvKonaklama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKonaklama.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKonaklama.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKonaklama.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvKonaklama.ColumnHeadersHeight = 27;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKonaklama.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvKonaklama.EnableHeadersVisualStyles = false;
            this.dgvKonaklama.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKonaklama.Location = new System.Drawing.Point(433, 57);
            this.dgvKonaklama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKonaklama.Name = "dgvKonaklama";
            this.dgvKonaklama.ReadOnly = true;
            this.dgvKonaklama.RowHeadersVisible = false;
            this.dgvKonaklama.RowHeadersWidth = 51;
            this.dgvKonaklama.RowTemplate.Height = 24;
            this.dgvKonaklama.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKonaklama.Size = new System.Drawing.Size(708, 299);
            this.dgvKonaklama.TabIndex = 10;
            this.dgvKonaklama.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKonaklama.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKonaklama.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKonaklama.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKonaklama.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKonaklama.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvKonaklama.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKonaklama.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.dgvKonaklama.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKonaklama.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvKonaklama.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKonaklama.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvKonaklama.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvKonaklama.ThemeStyle.ReadOnly = true;
            this.dgvKonaklama.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKonaklama.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKonaklama.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvKonaklama.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKonaklama.ThemeStyle.RowsStyle.Height = 24;
            this.dgvKonaklama.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKonaklama.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKonaklama.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKonaklama_CellClick);
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
            this.btnMinimize.Location = new System.Drawing.Point(1089, 4);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(51, 34);
            this.btnMinimize.TabIndex = 15;
            // 
            // grpbox_Kisi
            // 
            this.grpbox_Kisi.BackColor = System.Drawing.Color.Transparent;
            this.grpbox_Kisi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.grpbox_Kisi.BorderRadius = 16;
            this.grpbox_Kisi.Controls.Add(this.txt_soyad);
            this.grpbox_Kisi.Controls.Add(this.txt_cepNo);
            this.grpbox_Kisi.Controls.Add(this.txt_isim);
            this.grpbox_Kisi.Controls.Add(this.txt_TCNo);
            this.grpbox_Kisi.Controls.Add(this.lbl_cepNo);
            this.grpbox_Kisi.Controls.Add(this.lbl_soyad);
            this.grpbox_Kisi.Controls.Add(this.lbl_isim);
            this.grpbox_Kisi.Controls.Add(this.lbl_tcNo);
            this.grpbox_Kisi.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.grpbox_Kisi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbox_Kisi.ForeColor = System.Drawing.Color.White;
            this.grpbox_Kisi.Location = new System.Drawing.Point(22, 56);
            this.grpbox_Kisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbox_Kisi.Name = "grpbox_Kisi";
            this.grpbox_Kisi.Size = new System.Drawing.Size(389, 300);
            this.grpbox_Kisi.TabIndex = 18;
            this.grpbox_Kisi.Text = "Kişi Bilgileri";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Animated = true;
            this.txt_soyad.BorderRadius = 16;
            this.txt_soyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_soyad.DefaultText = "";
            this.txt_soyad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_soyad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_soyad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_soyad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_soyad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_soyad.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.txt_soyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txt_soyad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_soyad.Location = new System.Drawing.Point(149, 180);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.PasswordChar = '\0';
            this.txt_soyad.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txt_soyad.PlaceholderText = "";
            this.txt_soyad.SelectedText = "";
            this.txt_soyad.Size = new System.Drawing.Size(200, 39);
            this.txt_soyad.TabIndex = 2;
            // 
            // txt_cepNo
            // 
            this.txt_cepNo.Animated = true;
            this.txt_cepNo.BorderRadius = 16;
            this.txt_cepNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cepNo.DefaultText = "";
            this.txt_cepNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_cepNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_cepNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_cepNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_cepNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cepNo.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.txt_cepNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txt_cepNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cepNo.Location = new System.Drawing.Point(149, 240);
            this.txt_cepNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cepNo.MaxLength = 10;
            this.txt_cepNo.Name = "txt_cepNo";
            this.txt_cepNo.PasswordChar = '\0';
            this.txt_cepNo.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txt_cepNo.PlaceholderText = "";
            this.txt_cepNo.SelectedText = "";
            this.txt_cepNo.Size = new System.Drawing.Size(200, 39);
            this.txt_cepNo.TabIndex = 3;
            // 
            // txt_isim
            // 
            this.txt_isim.Animated = true;
            this.txt_isim.BorderRadius = 16;
            this.txt_isim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_isim.DefaultText = "";
            this.txt_isim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_isim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_isim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_isim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_isim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_isim.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.txt_isim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txt_isim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_isim.Location = new System.Drawing.Point(149, 121);
            this.txt_isim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.PasswordChar = '\0';
            this.txt_isim.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txt_isim.PlaceholderText = "";
            this.txt_isim.SelectedText = "";
            this.txt_isim.Size = new System.Drawing.Size(200, 39);
            this.txt_isim.TabIndex = 1;
            this.txt_isim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_isim_KeyPress);
            // 
            // txt_TCNo
            // 
            this.txt_TCNo.Animated = true;
            this.txt_TCNo.BorderRadius = 16;
            this.txt_TCNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TCNo.DefaultText = "";
            this.txt_TCNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TCNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TCNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TCNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TCNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TCNo.Font = new System.Drawing.Font("Arial Narrow", 10.2F);
            this.txt_TCNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txt_TCNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TCNo.Location = new System.Drawing.Point(149, 60);
            this.txt_TCNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TCNo.MaxLength = 11;
            this.txt_TCNo.Name = "txt_TCNo";
            this.txt_TCNo.PasswordChar = '\0';
            this.txt_TCNo.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.txt_TCNo.PlaceholderText = "";
            this.txt_TCNo.SelectedText = "";
            this.txt_TCNo.Size = new System.Drawing.Size(200, 39);
            this.txt_TCNo.TabIndex = 0;
            this.txt_TCNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TCNo_KeyPress);
            // 
            // lbl_cepNo
            // 
            this.lbl_cepNo.AutoSize = true;
            this.lbl_cepNo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cepNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbl_cepNo.Location = new System.Drawing.Point(17, 256);
            this.lbl_cepNo.Name = "lbl_cepNo";
            this.lbl_cepNo.Size = new System.Drawing.Size(109, 19);
            this.lbl_cepNo.TabIndex = 7;
            this.lbl_cepNo.Text = "Cep Telefonu:";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbl_soyad.Location = new System.Drawing.Point(19, 196);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(61, 19);
            this.lbl_soyad.TabIndex = 6;
            this.lbl_soyad.Text = "Soyad:";
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_isim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbl_isim.Location = new System.Drawing.Point(19, 135);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(44, 19);
            this.lbl_isim.TabIndex = 5;
            this.lbl_isim.Text = "İsim:";
            // 
            // lbl_tcNo
            // 
            this.lbl_tcNo.AutoSize = true;
            this.lbl_tcNo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tcNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbl_tcNo.Location = new System.Drawing.Point(19, 73);
            this.lbl_tcNo.Name = "lbl_tcNo";
            this.lbl_tcNo.Size = new System.Drawing.Size(108, 19);
            this.lbl_tcNo.TabIndex = 4;
            this.lbl_tcNo.Text = "TC Kimlik No:";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnExit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnExit.HoverState.IconColor = System.Drawing.Color.White;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btnExit.Location = new System.Drawing.Point(1145, 4);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 34);
            this.btnExit.TabIndex = 16;
            // 
            // RezervasyonForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1200, 682);
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.btnRaporAl);
            this.Controls.Add(this.btnRezervasyonIptal);
            this.Controls.Add(this.btnRezervasyonYap);
            this.Controls.Add(this.lblKoltukNo);
            this.Controls.Add(this.cmb_koltukNo);
            this.Controls.Add(this.dgvUlasim);
            this.Controls.Add(this.dgvKonaklama);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.grpbox_Kisi);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RezervasyonForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RezervasyonForms";
            this.Load += new System.EventHandler(this.RezervasyonForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUlasim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonaklama)).EndInit();
            this.grpbox_Kisi.ResumeLayout(false);
            this.grpbox_Kisi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse g_Elipse;
        private Guna.UI2.WinForms.Guna2DragControl g_DragControl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSayac;
        private Guna.UI2.WinForms.Guna2GradientButton btnRaporAl;
        private Guna.UI2.WinForms.Guna2GradientButton btnRezervasyonIptal;
        private Guna.UI2.WinForms.Guna2GradientButton btnRezervasyonYap;
        private System.Windows.Forms.Label lblKoltukNo;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_koltukNo;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUlasim;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKonaklama;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Guna.UI2.WinForms.Guna2GroupBox grpbox_Kisi;
        private Guna.UI2.WinForms.Guna2TextBox txt_soyad;
        private Guna.UI2.WinForms.Guna2TextBox txt_cepNo;
        private Guna.UI2.WinForms.Guna2TextBox txt_isim;
        private Guna.UI2.WinForms.Guna2TextBox txt_TCNo;
        private System.Windows.Forms.Label lbl_cepNo;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Label lbl_tcNo;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
    }
}