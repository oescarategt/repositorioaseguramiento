using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Impresoras3DR
{
    public partial class MenuR : Form
    {
        public MenuR()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tipoperso Mostrar = new Tipoperso();
            this.Hide();
            Mostrar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Área Mostrar = new Área();
            this.Hide();
            Mostrar.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Persona Mostrar = new Persona();
            this.Hide();
            Mostrar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Empleado Mostrar = new Empleado();
            this.Hide();
            Mostrar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Horario Mostrar = new Horario();
            this.Hide();
            Mostrar.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Genero Mostrar = new Genero();
            this.Hide();
            Mostrar.Show();
        }

        private void MenuR_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea regresar", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
               Menu Mostrar = new Menu();
                this.Hide();
                Mostrar.Show();
            }
        }
        public virtual void Insertar()
        {
        }

        public virtual void Eliminar()
        {
        }

        public virtual void Actualizar()
        {
        }

        public virtual Boolean Guardar()
        {
            return false;
        }
    }
}
