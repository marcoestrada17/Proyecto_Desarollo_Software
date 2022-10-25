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
    public partial class Creacion_usuario_Docente : Form
    {
        static string conexionstring = "Server = DESKTOP-6B0HUAG\\SQLEXPRESS ; database = InnovaTECH ; INTEGRATED SECURITY = true";
        SqlConnection conexion = new SqlConnection(conexionstring);

        public Creacion_usuario_Docente()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        private void Creacion_usuario_Docente_Load(object sender, EventArgs e)
        {
            

        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string fila = "INSERT INTO Docente ([Codigo_Docente] ,[Nombre_Completo] ,[Telefono] ,[Sexo] ,[Usuario], [Contraseña], [Correo], [Campus])" +
                " values ('" + txtCodigo.Text + "','" + txtNombre.Text + "','" + txtTelefono.Text + "','" + cmbSexo + "','" + txtUsuario.Text + "','" + txtContraseña.Text + "', '" + txtCorreo.Text + "', '" + txtCampus.Text + "')";

            SqlCommand comd = new SqlCommand(fila, conexion);
            comd.ExecuteNonQuery();

            MessageBox.Show("La persona: " + txtNombre.Text + " se ha agregado correctamente.");
            conexion.Close();

            if (txtContraseña.Text == txtContraseñaVerificada.Text)
            {
                MessageBox.Show("Cuentra creada con exito :D");
            }
            else
            {
                MessageBox.Show("Fallo al crear la cuenta D:");
            }

            dgvDocentes.Rows.Add();
            int contfila = dgvDocentes.Rows.Count - 1;
            dgvDocentes[0, contfila].Value = txtNombre.Text;
            dgvDocentes[1, contfila].Value = txtCodigo.Text;
            dgvDocentes[2, contfila].Value = txtTelefono.Text;
            dgvDocentes[3, contfila].Value = cmbSexo.Text;
            dgvDocentes[4, contfila].Value = txtUsuario.Text;
            dgvDocentes[5, contfila].Value = txtContraseña.Text;
            dgvDocentes[6, contfila].Value = txtCorreo.Text;
            dgvDocentes[7, contfila].Value = txtCampus.Text;
           
            txtNombre.Clear();
            txtCodigo.Clear();
            txtTelefono.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtContraseñaVerificada.Clear();
            txtCampus.Clear();
            txtCorreo.Clear();

            btnIngresar.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)//DELETE
        {
            conexion.Open();
            int indice = dgvDocentes.CurrentRow.Index;
            string fila = "DELETE FROM DOCENTE WHERE Codigo_Docente = '" + txtCodigo.Text+ "' ";
            SqlCommand comd = new SqlCommand(fila, conexion);
            indice = comd.ExecuteNonQuery(); 

            
            if (indice != -1)
            {
                dgvDocentes.Rows.RemoveAt(indice);
                MessageBox.Show("Se elimino correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }

            conexion.Close();
        }

       private void btnConsulta_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Docente";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dgvDocentes.DataSource = tabla;
        }
    }
}