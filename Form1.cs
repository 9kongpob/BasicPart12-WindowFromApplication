using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicPart12_WindowFormApplication
{

    public partial class Barcode_Form : MetroFramework.Forms.MetroForm
    {
        public Barcode_Form()
        {
            InitializeComponent();
        }
        private void Barcode_Form_Load(object sender, EventArgs e)
        {
            //this.ActiveControl = ;
            this.ActiveControl = tb_qrcode;
        }
        private void metroLabel1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            tb_qrcode.Clear();

            pb_qrcode.Image = null;
            pb_qrcode.Update();

            btn_save.Visible = false;
        }

        private void btn_generate_Click_1(object sender, EventArgs e)
        {

            if (tb_qrcode.Text != "")
            {
                Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                pb_qrcode.Image = qrcode.Draw(tb_qrcode.Text, 0);

                btn_save.Visible = true;

                tb_qrcode.Select();
                tb_qrcode.Focus();
            }
            else
            {
                //MessageBox.Show("Value is Null.");
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            Clipboard.SetImage(pb_qrcode.Image);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPEG Image|*.jpg|PNG Image (.png)|*.png|Bitmap Image|*.bmp|Gif Image|*.gif|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";
            saveFileDialog1.Title = "Save as";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.pb_qrcode.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.pb_qrcode.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        this.pb_qrcode.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
                
            }
        }

        private void tb_qrcode_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_generate.PerformClick();
                

            }
            else if (e.KeyCode == Keys.Escape)
            {
                btn_clear.PerformClick();
            }
            else if (btn_save.Visible == true && e.Control == true && e.KeyCode == Keys.S)
            {
                btn_save.PerformClick();
            }
            else
            {
                
            }

        }
    }
}

