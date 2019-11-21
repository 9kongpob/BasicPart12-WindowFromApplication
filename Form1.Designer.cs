namespace BasicPart12_WindowFormApplication
{
    partial class Barcode_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barcode_Form));
            this.version = new MetroFramework.Controls.MetroLabel();
            this.lb_close = new MetroFramework.Controls.MetroLabel();
            this.btn_clear = new MetroFramework.Controls.MetroButton();
            this.btn_generate = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_save = new MetroFramework.Controls.MetroButton();
            this.pb_qrcode = new System.Windows.Forms.PictureBox();
            this.tb_fielddata = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_qrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // version
            // 
            this.version.CustomBackground = true;
            this.version.CustomForeColor = true;
            this.version.FontSize = MetroFramework.MetroLabelSize.Small;
            this.version.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.version.Location = new System.Drawing.Point(2, 383);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(180, 23);
            this.version.Style = MetroFramework.MetroColorStyle.Black;
            this.version.TabIndex = 1;
            this.version.Text = "Version 0.0.1 by IT SIWT";
            this.version.Click += new System.EventHandler(this.metroLabel1_Click_1);
            // 
            // lb_close
            // 
            this.lb_close.AutoSize = true;
            this.lb_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_close.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_close.Location = new System.Drawing.Point(529, 7);
            this.lb_close.Name = "lb_close";
            this.lb_close.Size = new System.Drawing.Size(17, 20);
            this.lb_close.TabIndex = 5;
            this.lb_close.Text = "X";
            this.lb_close.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lb_close.Click += new System.EventHandler(this.metroLabel1_Click_2);
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.Location = new System.Drawing.Point(356, 23);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(44, 32);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click_1);
            // 
            // btn_generate
            // 
            this.btn_generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_generate.Location = new System.Drawing.Point(205, 60);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(101, 41);
            this.btn_generate.TabIndex = 4;
            this.btn_generate.Text = "Generate";
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click_1);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btn_save);
            this.metroPanel1.Controls.Add(this.pb_qrcode);
            this.metroPanel1.Controls.Add(this.tb_fielddata);
            this.metroPanel1.Controls.Add(this.btn_generate);
            this.metroPanel1.Controls.Add(this.btn_clear);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 115);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(520, 265);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Location = new System.Drawing.Point(363, 149);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(109, 52);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save As...";
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pb_qrcode
            // 
            this.pb_qrcode.BackColor = System.Drawing.Color.White;
            this.pb_qrcode.Location = new System.Drawing.Point(184, 112);
            this.pb_qrcode.Name = "pb_qrcode";
            this.pb_qrcode.Size = new System.Drawing.Size(140, 140);
            this.pb_qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_qrcode.TabIndex = 6;
            this.pb_qrcode.TabStop = false;
            // 
            // tb_fielddata
            // 
            this.tb_fielddata.Location = new System.Drawing.Point(126, 23);
            this.tb_fielddata.Name = "tb_fielddata";
            this.tb_fielddata.Size = new System.Drawing.Size(231, 32);
            this.tb_fielddata.TabIndex = 5;
            this.tb_fielddata.Click += new System.EventHandler(this.tb_fielddata_Click);
            this.tb_fielddata.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_fielddata_KeyDown);
            // 
            // Barcode_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(566, 407);
            this.ControlBox = false;
            this.Controls.Add(this.lb_close);
            this.Controls.Add(this.version);
            this.Controls.Add(this.metroPanel1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Barcode_Form";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "QR Code Generate";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Activated += new System.EventHandler(this.Barcode_Form_Activated);
            this.Load += new System.EventHandler(this.Barcode_Form_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_qrcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel version;
        private MetroFramework.Controls.MetroLabel lb_close;
        private MetroFramework.Controls.MetroButton btn_clear;
        private MetroFramework.Controls.MetroButton btn_generate;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox tb_fielddata;
        private System.Windows.Forms.PictureBox pb_qrcode;
        private MetroFramework.Controls.MetroButton btn_save;
    }
}

