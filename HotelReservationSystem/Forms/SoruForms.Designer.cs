
namespace HotelReservationSystem.Forms
{
    partial class SoruForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoruForms));
            this.btnEvet = new Guna.UI2.WinForms.Guna2Button();
            this.questionPanelMain = new System.Windows.Forms.Panel();
            this.pct_Question = new System.Windows.Forms.PictureBox();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnHayır = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.questionPanelTop = new System.Windows.Forms.Panel();
            this.questionPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Question)).BeginInit();
            this.panelButton.SuspendLayout();
            this.questionPanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEvet
            // 
            this.btnEvet.Animated = true;
            this.btnEvet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEvet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEvet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEvet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEvet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(136)))), ((int)(((byte)(86)))));
            this.btnEvet.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEvet.ForeColor = System.Drawing.Color.White;
            this.btnEvet.Location = new System.Drawing.Point(197, 25);
            this.btnEvet.Name = "btnEvet";
            this.btnEvet.Size = new System.Drawing.Size(150, 45);
            this.btnEvet.TabIndex = 0;
            this.btnEvet.Text = "Evet";
            this.btnEvet.Click += new System.EventHandler(this.btnEvet_Click);
            // 
            // questionPanelMain
            // 
            this.questionPanelMain.BackColor = System.Drawing.Color.White;
            this.questionPanelMain.Controls.Add(this.pct_Question);
            this.questionPanelMain.Controls.Add(this.lbl_Question);
            this.questionPanelMain.Controls.Add(this.panelButton);
            this.questionPanelMain.Location = new System.Drawing.Point(2, 67);
            this.questionPanelMain.Name = "questionPanelMain";
            this.questionPanelMain.Size = new System.Drawing.Size(686, 176);
            this.questionPanelMain.TabIndex = 3;
            // 
            // pct_Question
            // 
            this.pct_Question.Image = ((System.Drawing.Image)(resources.GetObject("pct_Question.Image")));
            this.pct_Question.Location = new System.Drawing.Point(32, 13);
            this.pct_Question.Name = "pct_Question";
            this.pct_Question.Size = new System.Drawing.Size(64, 64);
            this.pct_Question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_Question.TabIndex = 2;
            this.pct_Question.TabStop = false;
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbl_Question.Location = new System.Drawing.Point(125, 35);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(479, 19);
            this.lbl_Question.TabIndex = 1;
            this.lbl_Question.Text = "Sistemde kayıtlı diğer rezervasyonu iptal etmek istiyor musunuz?";
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelButton.Controls.Add(this.btnHayır);
            this.panelButton.Controls.Add(this.btnEvet);
            this.panelButton.Location = new System.Drawing.Point(0, 86);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(686, 89);
            this.panelButton.TabIndex = 0;
            // 
            // btnHayır
            // 
            this.btnHayır.Animated = true;
            this.btnHayır.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHayır.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHayır.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHayır.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHayır.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHayır.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btnHayır.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHayır.ForeColor = System.Drawing.Color.White;
            this.btnHayır.Location = new System.Drawing.Point(353, 25);
            this.btnHayır.Name = "btnHayır";
            this.btnHayır.Size = new System.Drawing.Size(150, 45);
            this.btnHayır.TabIndex = 0;
            this.btnHayır.Text = "Hayır";
            this.btnHayır.Click += new System.EventHandler(this.btnHayır_Click);
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
            this.lbl_title.Size = new System.Drawing.Size(185, 22);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Rezervasyon Sorusu";
            // 
            // questionPanelTop
            // 
            this.questionPanelTop.Controls.Add(this.btnExit);
            this.questionPanelTop.Controls.Add(this.lbl_title);
            this.questionPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.questionPanelTop.Location = new System.Drawing.Point(0, 0);
            this.questionPanelTop.Name = "questionPanelTop";
            this.questionPanelTop.Size = new System.Drawing.Size(690, 67);
            this.questionPanelTop.TabIndex = 2;
            // 
            // SoruForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(690, 245);
            this.Controls.Add(this.questionPanelMain);
            this.Controls.Add(this.questionPanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SoruForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoruForms";
            this.questionPanelMain.ResumeLayout(false);
            this.questionPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Question)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.questionPanelTop.ResumeLayout(false);
            this.questionPanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnEvet;
        private System.Windows.Forms.Panel questionPanelMain;
        private System.Windows.Forms.PictureBox pct_Question;
        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.Panel panelButton;
        private Guna.UI2.WinForms.Guna2Button btnHayır;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel questionPanelTop;
    }
}