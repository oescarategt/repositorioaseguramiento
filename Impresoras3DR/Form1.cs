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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SKCBF3Q ; Initial Catalog = Control_medicamentos; integrated Security = true");
        

        public void logear(string id_usuario, string contraseña)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_usuario, contraseña FROM Usuario WHERE id_usuario = @id_usuario AND contraseña = @contraseña", con);
                cmd.Parameters.AddWithValue("id_usuario", id_usuario);
                cmd.Parameters.AddWithValue("contraseña", contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable usu = new DataTable();
                sda.Fill(usu);
                
                if (usu.Rows.Count == 1)

                {
                    Menu Mostrar = new Menu();
                    Mostrar.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            logear(this.textBox1.Text, this.textBox2.Text);
       
            {
               
                this.Hide();
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}