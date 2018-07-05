using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda
{
    public partial class Menu2 : Form
    {
        public Menu2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MENU M = new MENU();
            M.Visible = true;
            this.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Inventario a = new Inventario();
            a.Visible = true;
            this.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Inventario b = new Inventario();
            b.Visible = true;
            this.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Inventario c = new Inventario();
            c.Visible = true;
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Inventario d = new Inventario();
            d.Visible = true;
            this.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            Inventario  E= new Inventario();
            E.Visible = true;
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Inventario F = new Inventario();
            F.Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Inventario G = new Inventario();
            G.Visible = true;
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Inventario h = new Inventario();
            h.Visible = true;
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Inventario i = new Inventario();
            i.Visible = true;
            this.Visible = false;
        }
    }
}
