using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda.Forms;
using Tienda.Forms.Venta;

namespace Tienda
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MVenta  ve = new MVenta();
            ve.Visible =true;
            this.Visible = false ;

            }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HASTA LUEGO LINDO DIA ;D","Creado por: Daltrox y Arthur" );
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            usuario2 u = new usuario2();
            u.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            usuario1 v = new usuario1();
            v.Visible = true;
            this.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
