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

        }
        private void metroLabel1_Click_1(object sender, EventArgs e)
        {
            
        }
        private void metroLabel1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tb_fielddata_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            tb_fielddata.Clear();

            pb_qrcode.Image = null;
            pb_qrcode.Update();

            btn_save.Visible = false;
        }

        private void btn_generate_Click_1(object sender, EventArgs e)
        {
            if (tb_fielddata.Text != "")
            {
                Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                pb_qrcode.Image = qrcode.Draw(tb_fielddata.Text,0);

                btn_save.Visible = true;

            }
            else
            {
                MessageBox.Show("Value is Null.");
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            /*Bitmap bmp = new Bitmap(pb_qrcode.Width, pb_qrcode.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White, 0, 0, Width, Height);
            PictureBox pb = new PictureBox();
            pb.Image = bmp;
            Clipboard.SetDataObject(bmp);*/



            /*Image img = new Bitmap(pb_qrcode.Width, pb_qrcode.Height);
            Graphics g = Graphics.FromImage(img);
            g.CopyFromScreen(PointToScreen(pb_qrcode.Location), new Point(0, 0), new Size(pb_qrcode.Width, pb_qrcode.Height));
            Clipboard.SetImage(img);
            g.Dispose();*/


            /*Image img = new Bitmap(pb_qrcode.Width, pb_qrcode.Height);
            Graphics g = Graphics.FromImage(img);
            g.CopyFromScreen(PointToScreen(pb_qrcode.Location), new Point(0, 0), new Size(pb_qrcode.Width, pb_qrcode.Height));
            img.Save(string.Format(@"D:\CMS\image.jpg"));
            g.Dispose();*/
        }
        private void RenderGraphics(Graphics g, RectangleF client)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            // draw code goes here
        }
    }
}
