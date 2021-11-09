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
    public partial class Persona : Form
    {
        public Persona()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea regresar", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                MenuR Mostrar = new MenuR();
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
        private void Persona_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SKCBF3Q;Initial Catalog=Control_medicamentos;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("persona_insertar", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_persona", SqlDbType.VarChar).Value = txtidpersona.Text;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtnombre.Text;
                cmd.Parameters.Add("@apellido", SqlDbType.VarChar).Value = txtapellido.Text;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = txttelefono.Text;
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = txtdireccion.Text;
                cmd.Parameters.Add("@tipo_persona_id_tpers", SqlDbType.VarChar).Value = txtgenero.Text;
                cmd.Parameters.Add("@genero_id_genero", SqlDbType.VarChar).Value = txttipo.Text;

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

                SqlCommand cmd = new SqlCommand("persona_actualizar", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_persona", SqlDbType.VarChar).Value = txtidpersona.Text;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = txtnombre.Text;
                cmd.Parameters.Add("@apellido", SqlDbType.VarChar).Value = txtapellido.Text;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = txttelefono.Text;
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = txtdireccion.Text;
                cmd.Parameters.Add("@tipo_persona_id_tpers", SqlDbType.VarChar).Value = txtgenero.Text;
                cmd.Parameters.Add("@genero_id_genero", SqlDbType.VarChar).Value = txttipo.Text;

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

                SqlCommand cmd = new SqlCommand("persona_delete", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@id_persona", SqlDbType.VarChar).Value = txtidpersona.Text;

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
            SqlCommand comando = new SqlCommand("SELECT * FROM persona", con);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            datapersona.DataSource = tabla;
        }
    }
}
