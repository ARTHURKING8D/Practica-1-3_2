using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Tienda.Forms.Venta
{
    public partial class MVenta : Form
    { 
        
        public MVenta()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();
 
        

        private void button4_Click(object sender, EventArgs e)
        {
            string actualizar = "update Producto set Producto_Deseado" + tbxcantidad.Text + "where Nombre_Producto=" + tbxprducto.Text;
            if (bd.executecommand(actualizar))
            {
                MessageBox.Show("Exito");
                dataGridView1.DataSource = bd.SelectDataTable("select * from Producto");

            }
            else
            {
                MessageBox.Show("Error");
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MENU m = new MENU();
            m.Visible = true;
            this.Visible = false;
        }

        private void btnAcaptar_Click(object sender, EventArgs e)
        {
            ticket t = new ticket();
            t.Visible = true;
            this.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MVenta_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bd.SelectDataTable("select * from Producto");
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            String agregar = "Insert into producto values (" + tbxprducto.Text + ",'" + tbxcantidad.Text + ")";
            if (bd.executecommand(agregar))
            {
                MessageBox.Show("Exito");
                dataGridView1.DataSource = bd.SelectDataTable("select * from Producto");

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string eliminar = "delete from Producto where Nombre_Producto= " + tbxprducto.Text;
            if (bd.executecommand(eliminar))
            {
                MessageBox.Show("Exito");
                dataGridView1.DataSource = bd.SelectDataTable("select * from Producto");

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string buscar = "select * from Producto where Nombre_Producto" + tbxprducto.Text;
            dataGridView1.DataSource = bd.SelectDataTable(buscar);

        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            Qr w = new Qr();
            w.Visible = true;
            this.Visible = false;
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:";
            saveFileDialog1.Title = "Guardar Reporte";
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "pdf Files (.pdf)|.pdf| All Files (.)|.";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            string filename = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
            }

            if (filename.Trim() != "")
            {
                FileStream file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite,
                FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();
                string envio = "Fecha:" + DateTime.Now.ToString();

                Chunk chunk = new Chunk("Proveedores", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD));
                doc.Add(new Paragraph(chunk));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph(""));
                doc.Add(new Paragraph(""));
                doc.Add(new Paragraph("Hecho por ARTHURKING"));
                doc.Add(new Paragraph(envio));
                doc.Add(new Paragraph(""));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                GenerarDocumento(doc);
                doc.AddCreationDate();
                doc.Add(new Paragraph("", FontFactory.GetFont("ARIAL", 20, iTextSharp.text.Font.BOLD)));
                doc.Close();
                Process.Start(filename);
            }

        }
        public void GenerarDocumento(Document document)
        {
            int i, j;
            PdfPTable datatable = new PdfPTable(dataGridView1.ColumnCount);
            datatable.DefaultCell.Padding = 3;
            float[] headerwidths = GetTamañoColumnas(dataGridView1);
            datatable.SetWidths(headerwidths); 
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (i = 0; i < dataGridView1.ColumnCount; i++)
            {
                datatable.AddCell(dataGridView1.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            for (i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1[j, i].Value != null)
                    {
                        datatable.AddCell(new Phrase(dataGridView1[j, i].Value.ToString()));
                    }
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }
        public float[] GetTamañoColumnas(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }
    }
}
