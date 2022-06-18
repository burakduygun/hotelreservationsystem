
namespace HotelReservationSystem.Forms
{
    partial class BilgilendirmeForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BilgilendirmeForms));
            this.questionPanelTop = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.pct_Question = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.questionPanelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Question)).BeginInit();
            this.SuspendLayout();
            // 
            // questionPanelTop
            // 
            this.questionPanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(190)))), ((int)(((byte)(165)))));
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
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(190)))), ((int)(((byte)(165)))));
            this.btnExit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnExit.HoverState.IconColor = System.Drawing.Color.White;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(642, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 45);
            this.btnExit.TabIndex = 2;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 11F);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(13, 26);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(234, 22);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Rezervasyon Bilgilendirme";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_Question);
            this.panel1.Controls.Add(this.pct_Question);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Location = new System.Drawing.Point(2, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 176);
            this.panel1.TabIndex = 4;
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbl_Question.Location = new System.Drawing.Point(118, 28);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(488, 38);
            this.lbl_Question.TabIndex = 3;
            this.lbl_Question.Text = "Rezervasyonunuz yapılmıştır. Teşekkür ederiz. Olası rezervasyon \r\niptali için 3 d" +
    "akikaniz vardır.";
            // 
            // pct_Question
            // 
            this.pct_Question.Image = ((System.Drawing.Image)(resources.GetObject("pct_Question.Image")));
            this.pct_Question.Location = new System.Drawing.Point(32, 13);
            this.pct_Question.Name = "pct_Question";
            this.pct_Question.Size = new System.Drawing.Size(64, 64);
            this.pct_Question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_Question.TabIndex = 1;
            this.pct_Question.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 89);
            this.panel2.TabIndex = 0;
            // 
            // BilgilendirmeForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 245);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.questionPanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BilgilendirmeForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BilgilendirmeForms";
            this.questionPanelTop.ResumeLayout(false);
            this.questionPanelTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Question)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel questionPanelTop;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.PictureBox pct_Question;
        private System.Windows.Forms.Panel panel2;
    }
}