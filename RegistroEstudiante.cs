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

namespace Proyecto_Desarollo_Software
{
    public partial class FormRegistrodeUsuario : Form
    {
        static string conexionstring = "Server = DESKTOP-6B0HUAG\\SQLEXPRESS ; database = InnovaTECH ; INTEGRATED SECURITY = true";
        SqlConnection conexion = new SqlConnection(conexionstring);


        public FormRegistrodeUsuario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            if (txtContraseña.Text == txtContraseñaVerificada.Text)
            {
                MessageBox.Show("Cuentra creada con exito :D");
            }
            else
            {
                MessageBox.Show("Fallo al crear la cuenta D:");
            }

            string cadena = "INSERT INTO Usuarios ([Usuario] ,[Contraseña] ,[Nombre] ,[Apellido] ,[Campus], [Edad]  )" +
                " values ('" + txtNombreUsuario.Text + "','" + txtContraseña.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtCampus.Text + "','" + txtEdad.Text + "')";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();

            MessageBox.Show("La persona: "+txtNombre.Text+" se ha agregado correctamente.");
            conexion.Close();

            dataGridView1.Rows.Add();
            int contfila = dataGridView1.Rows.Count - 1;
            //lblmostrar.Text = contfila.ToString();
            dataGridView1[0, contfila].Value = txtNumIdentidad.Text;
            dataGridView1[1, contfila].Value = txtNombreUsuario.Text;
            dataGridView1[2, contfila].Value = txtNombre.Text;
            dataGridView1[3, contfila].Value = txtApellido.Text;
            dataGridView1[4, contfila].Value = txtEdad.Text;
            dataGridView1[5, contfila].Value = cmbSexo.Text;
            dataGridView1[6, contfila].Value = txtCampus.Text;

            txtNumIdentidad.Clear();
            txtNombreUsuario.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtCampus.Clear();

            btnAgregar.Enabled = true;
        }
        
        public void FormRegistrodeUsuario_Load(object sender, EventArgs e)
        {

        }

        public void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}