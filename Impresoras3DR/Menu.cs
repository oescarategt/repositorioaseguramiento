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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuR Mostrar = new MenuR();
            this.Hide();
            Mostrar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventario Mostrar = new Inventario();
            this.Hide();
            Mostrar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuC Mostrar = new MenuC();
            this.Hide();
            Mostrar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clientes Mostrar = new Clientes();
            this.Hide();
            Mostrar.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Factura Mostrar = new Factura();
            this.Hide();
            Mostrar.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
      
        }

        private void button7_Click(object sender, EventArgs e)
        {
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clientes Mostrar = new Clientes();
            Mostrar.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar sesión", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
