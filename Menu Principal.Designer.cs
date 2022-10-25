
namespace Proyecto_Desarollo_Software
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciodeSecion = new System.Windows.Forms.Button();
            this.btnCreaUsuario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RBAdmin = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Universidad Catolica de Honduras";
            // 
            // btnIniciodeSecion
            // 
            this.btnIniciodeSecion.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciodeSecion.Location = new System.Drawing.Point(264, 186);
            this.btnIniciodeSecion.Name = "btnIniciodeSecion";
            this.btnIniciodeSecion.Size = new System.Drawing.Size(144, 43);
            this.btnIniciodeSecion.TabIndex = 1;
            this.btnIniciodeSecion.Text = "Inicio de Sesion";
            this.btnIniciodeSecion.UseVisualStyleBackColor = true;
            this.btnIniciodeSecion.Click += new System.EventHandler(this.btnIniciodeSecion_Click);
            // 
            // btnCreaUsuario
            // 
            this.btnCreaUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreaUsuario.Location = new System.Drawing.Point(264, 259);
            this.btnCreaUsuario.Name = "btnCreaUsuario";
            this.btnCreaUsuario.Size = new System.Drawing.Size(144, 52);
            this.btnCreaUsuario.TabIndex = 2;
            this.btnCreaUsuario.Text = "Crea un Usuario nuevo";
            this.btnCreaUsuario.UseVisualStyleBackColor = true;
            this.btnCreaUsuario.Click += new System.EventHandler(this.btnCreaUsuario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(259, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bienvenido";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // RBAdmin
            // 
            this.RBAdmin.AutoSize = true;
            this.RBAdmin.Location = new System.Drawing.Point(1, 383);
            this.RBAdmin.Name = "RBAdmin";
            this.RBAdmin.Size = new System.Drawing.Size(88, 17);
            this.RBAdmin.TabIndex = 5;
            this.RBAdmin.TabStop = true;
            this.RBAdmin.Text = "Administrador\r\n";
            this.RBAdmin.UseVisualStyleBackColor = true;
            this.RBAdmin.CheckedChanged += new System.EventHandler(this.RBAdmin_CheckedChanged);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(530, 403);
            this.Controls.Add(this.RBAdmin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreaUsuario);
            this.Controls.Add(this.btnIniciodeSecion);
            this.Controls.Add(this.label1);
            this.Name = "FormMenuPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciodeSecion;
        private System.Windows.Forms.Button btnCreaUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton RBAdmin;
    }
}

