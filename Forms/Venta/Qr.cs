using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Tienda.Forms.Venta
{
    public partial class Qr : Form
    {
        public Qr()
        {
            InitializeComponent();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Qr_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                BarcodeWriter br = new BarcodeWriter();
                br.Format = BarcodeFormat.QR_CODE;
                Bitmap bm = new Bitmap(br.Write(textBox1.Text), 300, 300);
                pbGenerar.Image = bm;

            }
        }

        private void btnGuar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Imagen png|*.png",
                InitialDirectory = @"C:\Users\artur\Desktop\tarea\qr"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pbGenerar.Image.Save(sfd.FileName);
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Imagen png|*.png",
                InitialDirectory = @"C:\Users\artur\Desktop\tarea\qr"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbAbrir.Image = Image.FromFile(ofd.FileName);
                BarcodeReader br = new BarcodeReader();
                string texto = br.Decode((Bitmap)pbAbrir.Image).ToString();
                textBox2.Text = texto;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MVenta v = new MVenta();
            v.Visible = true;
            this.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
