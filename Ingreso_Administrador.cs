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
    public partial class Ingreso_Administrador : Form
    {
        public Ingreso_Administrador()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server = DESKTOP-6B0HUAG\\SQLEXPRESS ; database = InnovaTECH ; INTEGRATED SECURITY = true");

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comando = new SqlCommand("SELECT Admin_id, Nombre_admin, Contraseña_admin FROM Administrador WHERE Admin_id = @aAdmin_id AND Nombre_admin = @aUsuario AND Contraseña_admin = @aContraseña", con);
            comando.Parameters.AddWithValue("@aAdmin_id", txtid.Text);
            comando.Parameters.AddWithValue("@aUsuario", txtUsuario.Text);
            comando.Parameters.AddWithValue("@aContraseña", txtContraseña.Text);

            SqlDataReader lector = comando.ExecuteReader();



            if (lector.Read())
            {
                con.Close();
                Administrador Formulario = new Administrador();
                Formulario.Show();
            }
            else
            {
                MessageBox.Show("Ingrese su Usuario y Contraseña", "ERROR");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comando = new SqlCommand("SELECT Admin_id, Nombre_admin, Contraseña_admin FROM Administrador WHERE Admin_id = @aAdmin_id AND Nombre_admin = @aUsuario AND Contraseña_admin = @aContraseña", con);
            comando.Parameters.AddWithValue("@aAdmin_id", txtid.Text);
            comando.Parameters.AddWithValue("@aUsuario", txtUsuario.Text);
            comando.Parameters.AddWithValue("@aContraseña", txtContraseña.Text);

            SqlDataReader lector = comando.ExecuteReader();


            if (lector.Read())
            {
                con.Close();
                Administrador Formulario = new Administrador();
                Formulario.Show();
            }
            else
            {
                MessageBox.Show("Ingrese su Usuario y Contraseña", "ERROR");

            }
        }
    }
}
