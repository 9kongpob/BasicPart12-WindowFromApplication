using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void btn_generate_Click_1(object sender, EventArgs e)
        {
            if (tb_fielddata.Text != "")
            {
                Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                pb_qrcode.Image = qrcode.Draw(tb_fielddata.Text,0);
            }
            else
            {
                MessageBox.Show("Value is Null.", "Popup");
            }

        }
    }
}
