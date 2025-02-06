using ControlCesharp.bbdd;
using ControlCesharp.vistas;
using Microsoft.Win32;
using System.Windows.Forms;

namespace ControlCesharp
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.campoUsuario = new System.Windows.Forms.TextBox();
            this.campoPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // campoUsuario
            // 
            this.campoUsuario.Location = new System.Drawing.Point(197, 76);
            this.campoUsuario.Name = "campoUsuario";
            this.campoUsuario.Size = new System.Drawing.Size(100, 22);
            this.campoUsuario.TabIndex = 2;
            // 
            // campoPass
            // 
            this.campoPass.Location = new System.Drawing.Point(197, 126);
            this.campoPass.Name = "campoPass";
            this.campoPass.Size = new System.Drawing.Size(100, 22);
            this.campoPass.TabIndex = 3;
            this.campoPass.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.campoPass);
            this.Controls.Add(this.campoUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox campoUsuario;
        private System.Windows.Forms.TextBox campoPass;
        private System.Windows.Forms.Button button1;

        public void entrar()
        {
            if (Conexion.Acceder(campoUsuario.Text, campoPass.Text))
            {
                MessageBox.Show("Acceso correcto");
                Principal p = new Principal();
                p.ShowDialog();
            }
            else
            {
                if (Conexion.UsuarioExiste(campoUsuario.Text))
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }
            }
        }

    }
}

