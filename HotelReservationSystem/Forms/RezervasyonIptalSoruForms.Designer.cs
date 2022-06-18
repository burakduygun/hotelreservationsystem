
namespace HotelReservationSystem.Forms
{
    partial class RezervasyonIptalSoruForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervasyonIptalSoruForms));
            this.questionPanelTop = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pct_Question = new System.Windows.Forms.PictureBox();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.btnKonaklama = new Guna.UI2.WinForms.Guna2Button();
            this.btnUlasim = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.questionPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Question)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionPanelTop
            // 
            this.questionPanelTop.Controls.Add(this.btnExit);
            this.questionPanelTop.Controls.Add(this.lbl_title);
            this.questionPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.questionPanelTop.Location = new System.Drawing.Point(0, 0);
            this.questionPanelTop.Name = "questionPanelTop";
            this.questionPanelTop.Size = new System.Drawing.Size(690, 67);
            this.questionPanelTop.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.btnExit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnExit.HoverState.IconColor = System.Drawing.Color.White;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(642, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 45);
            this.btnExit.TabIndex = 4;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 11F);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(13, 26);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(226, 22);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Rezervasyon İptal Sorusu";
            // 
            // pct_Question
            // 
            this.pct_Question.Image = ((System.Drawing.Image)(resources.GetObject("pct_Question.Image")));
            this.pct_Question.Location = new System.Drawing.Point(30, 14);
            this.pct_Question.Name = "pct_Question";
            this.pct_Question.Size = new System.Drawing.Size(64, 64);
            this.pct_Question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_Question.TabIndex = 4;
            this.pct_Question.TabStop = false;
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbl_Question.Location = new System.Drawing.Point(123, 36);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(372, 19);
            this.lbl_Question.TabIndex = 3;
            this.lbl_Question.Text = "Hangi rezervasyonunuzu iptal etmek istiyorsunuz?";
            // 
            // btnKonaklama
            // 
            this.btnKonaklama.Animated = true;
            this.btnKonaklama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKonaklama.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKonaklama.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKonaklama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKonaklama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKonaklama.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(190)))), ((int)(((byte)(165)))));
            this.btnKonaklama.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKonaklama.ForeColor = System.Drawing.Color.White;
            this.btnKonaklama.Location = new System.Drawing.Point(190, 22);
            this.btnKonaklama.Name = "btnKonaklama";
            this.btnKonaklama.Size = new System.Drawing.Size(150, 45);
            this.btnKonaklama.TabIndex = 4;
            this.btnKonaklama.Text = "Konaklama";
            this.btnKonaklama.Click += new System.EventHandler(this.btnKonaklama_Click);
            // 
            // btnUlasim
            // 
            this.btnUlasim.Animated = true;
            this.btnUlasim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUlasim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUlasim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUlasim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUlasim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUlasim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnUlasim.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUlasim.ForeColor = System.Drawing.Color.White;
            this.btnUlasim.Location = new System.Drawing.Point(346, 22);
            this.btnUlasim.Name = "btnUlasim";
            this.btnUlasim.Size = new System.Drawing.Size(150, 45);
            this.btnUlasim.TabIndex = 5;
            this.btnUlasim.Text = "Ulaşım";
            this.btnUlasim.Click += new System.EventHandler(this.btnUlasim_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnKonaklama);
            this.panel2.Controls.Add(this.btnUlasim);
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 89);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pct_Question);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbl_Question);
            this.panel1.Location = new System.Drawing.Point(2, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 176);
            this.panel1.TabIndex = 4;
            // 
            // RezervasyonIptalSoruForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(690, 245);
            this.Controls.Add(this.questionPanelTop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RezervasyonIptalSoruForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RezervasyonIptalSoruForms";
            this.questionPanelTop.ResumeLayout(false);
            this.questionPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Question)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel questionPanelTop;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pct_Question;
        private System.Windows.Forms.Label lbl_Question;
        private Guna.UI2.WinForms.Guna2Button btnKonaklama;
        private Guna.UI2.WinForms.Guna2Button btnUlasim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}