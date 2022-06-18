
namespace HotelReservationSystem.Forms
{
    partial class RaporForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporForms));
            this.questionPanelTop = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_HTML = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Json = new Guna.UI2.WinForms.Guna2Button();
            this.btn_XML = new Guna.UI2.WinForms.Guna2Button();
            this.pct_Question = new System.Windows.Forms.PictureBox();
            this.questionPanelTop.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_Question)).BeginInit();
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
            this.btnExit.TabIndex = 3;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Arial", 11F);
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(13, 26);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(127, 22);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Rapor Sorusu";
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.White;
            this.pnl_Main.Controls.Add(this.lbl_Question);
            this.pnl_Main.Controls.Add(this.panel2);
            this.pnl_Main.Controls.Add(this.pct_Question);
            this.pnl_Main.Location = new System.Drawing.Point(2, 67);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(686, 176);
            this.pnl_Main.TabIndex = 4;
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbl_Question.Location = new System.Drawing.Point(121, 35);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(285, 19);
            this.lbl_Question.TabIndex = 2;
            this.lbl_Question.Text = "Hangi formatta kayıt almak isterseniz?";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btn_HTML);
            this.panel2.Controls.Add(this.btn_Json);
            this.panel2.Controls.Add(this.btn_XML);
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 89);
            this.panel2.TabIndex = 1;
            // 
            // btn_HTML
            // 
            this.btn_HTML.Animated = true;
            this.btn_HTML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HTML.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_HTML.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_HTML.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_HTML.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_HTML.FillColor = System.Drawing.Color.DimGray;
            this.btn_HTML.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_HTML.ForeColor = System.Drawing.Color.White;
            this.btn_HTML.Location = new System.Drawing.Point(427, 21);
            this.btn_HTML.Name = "btn_HTML";
            this.btn_HTML.Size = new System.Drawing.Size(150, 45);
            this.btn_HTML.TabIndex = 3;
            this.btn_HTML.Text = "HTML";
            this.btn_HTML.Click += new System.EventHandler(this.btn_HTML_Click);
            // 
            // btn_Json
            // 
            this.btn_Json.Animated = true;
            this.btn_Json.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Json.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Json.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Json.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Json.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Json.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(190)))), ((int)(((byte)(165)))));
            this.btn_Json.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Json.ForeColor = System.Drawing.Color.White;
            this.btn_Json.Location = new System.Drawing.Point(115, 21);
            this.btn_Json.Name = "btn_Json";
            this.btn_Json.Size = new System.Drawing.Size(150, 45);
            this.btn_Json.TabIndex = 3;
            this.btn_Json.Text = "Json";
            this.btn_Json.Click += new System.EventHandler(this.btn_Json_Click);
            // 
            // btn_XML
            // 
            this.btn_XML.Animated = true;
            this.btn_XML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XML.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_XML.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_XML.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_XML.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_XML.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.btn_XML.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_XML.ForeColor = System.Drawing.Color.White;
            this.btn_XML.Location = new System.Drawing.Point(271, 21);
            this.btn_XML.Name = "btn_XML";
            this.btn_XML.Size = new System.Drawing.Size(150, 45);
            this.btn_XML.TabIndex = 3;
            this.btn_XML.Text = "XML";
            this.btn_XML.Click += new System.EventHandler(this.btn_XML_Click);
            // 
            // pct_Question
            // 
            this.pct_Question.Image = ((System.Drawing.Image)(resources.GetObject("pct_Question.Image")));
            this.pct_Question.Location = new System.Drawing.Point(32, 13);
            this.pct_Question.Name = "pct_Question";
            this.pct_Question.Size = new System.Drawing.Size(64, 64);
            this.pct_Question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_Question.TabIndex = 0;
            this.pct_Question.TabStop = false;
            // 
            // RaporForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(152)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(690, 245);
            this.Controls.Add(this.questionPanelTop);
            this.Controls.Add(this.pnl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RaporForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaporForms";
            this.questionPanelTop.ResumeLayout(false);
            this.questionPanelTop.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pct_Question)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel questionPanelTop;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_HTML;
        private Guna.UI2.WinForms.Guna2Button btn_Json;
        private Guna.UI2.WinForms.Guna2Button btn_XML;
        private System.Windows.Forms.PictureBox pct_Question;
    }
}