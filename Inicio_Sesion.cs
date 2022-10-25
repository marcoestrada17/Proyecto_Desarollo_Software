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
    public partial class FormIniciodeSecion : Form
    {
        public FormIniciodeSecion()
        {
            InitializeComponent();
        }

       SqlConnection con = new SqlConnection("Server = DESKTOP-6B0HUAG\\SQLEXPRESS ; database = InnovaTECH ; INTEGRATED SECURITY = true");

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comando = new SqlCommand("SELECT Usuario, Contraseña FROM Usuarios WHERE Usuario = @vUsuario AND Contraseña = @vContraseña",con);
            comando.Parameters.AddWithValue("@vUsuario",txtUsuario.Text);
            comando.Parameters.AddWithValue("@vContraseña",txtContraseña.Text);

            SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                con.Close();
                FormularioEstudiante Formulario = new FormularioEstudiante();
                Formulario.Show();

            }       
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormIniciodeSecion_Load(object sender, EventArgs e)
        {

        }
    }
}
