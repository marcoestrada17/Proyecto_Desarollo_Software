using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_Desarollo_Software
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }
        

        private void btnCreaUsuario_Click(object sender, EventArgs e)
        {
            FormRegistrodeUsuario Formulario = new FormRegistrodeUsuario();
            Formulario.Show();
        }

        private void btnIniciodeSecion_Click(object sender, EventArgs e)
        {
            FormIniciodeSecion Formulario = new FormIniciodeSecion();
            Formulario.Show();
        }

        private void RBAdmin_CheckedChanged(object sender, EventArgs e)
        {
            
            Ingreso_Administrador admin = new Ingreso_Administrador();
            admin.ShowDialog();

            RBAdmin.Checked = false;
        }
    }
}
