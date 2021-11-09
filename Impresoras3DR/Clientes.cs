using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria;
using System.Data.SqlClient;
namespace Impresoras3DR
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
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
        private void Area_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SKCBF3Q;Initial Catalog=Control_medicamentos;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("paciente_insertar", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_paciente", SqlDbType.VarChar).Value = txtcliente.Text;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txtnombre.Text;
                cmd.Parameters.Add("@Dirección", SqlDbType.VarChar).Value = txtdireccion.Text;
                cmd.Parameters.Add("@DPI", SqlDbType.VarChar).Value = txtnit.Text;

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Dato ingresado con exito");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Dato no ingresado" + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SKCBF3Q;Initial Catalog=Control_medicamentos;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("paciente_actualizar", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_paciente", SqlDbType.VarChar).Value = txtcliente.Text;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txtnombre.Text;
                cmd.Parameters.Add("@Dirección", SqlDbType.VarChar).Value = txtdireccion.Text;
                cmd.Parameters.Add("@DPI", SqlDbType.VarChar).Value = txtnit.Text;

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Dato actualizado con exito");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Dato no actualizado" + ex.Message);
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SKCBF3Q;Initial Catalog=Control_medicamentos;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("paciente_delete", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_paciente", SqlDbType.VarChar).Value = txtcliente.Text;

                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Dato eliminado con exito");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Dato no eliminado" + ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SKCBF3Q ; Initial Catalog =Control_medicamentos; integrated Security = true");
            SqlCommand comando = new SqlCommand("SELECT * FROM paciente", con);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            datacliente.DataSource = tabla;
        }



        private void Clientes_Load(object sender, EventArgs e)
        {

        }
    }
    }

