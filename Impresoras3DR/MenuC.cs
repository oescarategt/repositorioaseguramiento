using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impresoras3DR
{
    public partial class MenuC : Form
    {
        public MenuC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compras Mostrar = new Compras();
            this.Hide();
            Mostrar.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proveedores Mostrar = new Proveedores();
            this.Hide();
            Mostrar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea regresar", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Menu Mostrar = new Menu();
                this.Hide();
                Mostrar.Show();
            }
        }
    }
}
