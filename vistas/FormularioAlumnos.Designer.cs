using System.Diagnostics.Eventing.Reader;
using ControlCesharp.bbdd;
using System.Windows.Forms;
using System;
using ControlCesharp.modelo;
using System.IO;

namespace ControlCesharp.vistas
{
    partial class FormularioAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.campoEdad = new System.Windows.Forms.TextBox();
            this.campoApellidos = new System.Windows.Forms.TextBox();
            this.comboCiudad = new System.Windows.Forms.ComboBox();
            this.comboCiclo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ciudad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ciclo";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(193, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // campoNombre
            // 
            this.campoNombre.Location = new System.Drawing.Point(225, 25);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(166, 22);
            this.campoNombre.TabIndex = 7;
            this.campoNombre.Tag = "Nombre";
            // 
            // campoEdad
            // 
            this.campoEdad.Location = new System.Drawing.Point(225, 134);
            this.campoEdad.Name = "campoEdad";
            this.campoEdad.Size = new System.Drawing.Size(100, 22);
            this.campoEdad.TabIndex = 9;
            this.campoEdad.Tag = "Edad";
            // 
            // campoApellidos
            // 
            this.campoApellidos.Location = new System.Drawing.Point(225, 79);
            this.campoApellidos.Name = "campoApellidos";
            this.campoApellidos.Size = new System.Drawing.Size(166, 22);
            this.campoApellidos.TabIndex = 10;
            this.campoApellidos.Tag = "Apellidos";
            // 
            // comboCiudad
            // 
            this.comboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCiudad.FormattingEnabled = true;
            this.comboCiudad.Items.AddRange(new object[] {
            "Seleccione",
            "Zaragoza",
            "Huesca",
            "Madrid",
            "Segovia",
            "Teruel"});
            this.comboCiudad.Location = new System.Drawing.Point(225, 184);
            this.comboCiudad.Name = "comboCiudad";
            this.comboCiudad.Size = new System.Drawing.Size(166, 24);
            this.comboCiudad.TabIndex = 11;
            this.comboCiudad.Tag = "Ciudad";
            // 
            // comboCiclo
            // 
            this.comboCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCiclo.FormattingEnabled = true;
            this.comboCiclo.Items.AddRange(new object[] {
            "Seleccione",
            "DAM",
            "DAW",
            "FAR",
            "INS",
            "AUL"});
            this.comboCiclo.Location = new System.Drawing.Point(225, 226);
            this.comboCiclo.Name = "comboCiclo";
            this.comboCiclo.Size = new System.Drawing.Size(166, 24);
            this.comboCiclo.TabIndex = 12;
            this.comboCiclo.Tag = "Ciudad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.campoNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboCiclo);
            this.groupBox1.Controls.Add(this.campoEdad);
            this.groupBox1.Controls.Add(this.campoApellidos);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboCiudad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(107, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 411);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NUEVO ALUMNO ";
            // 
            // FormularioAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 512);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormularioAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioAlumnos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox campoNombre;
        private System.Windows.Forms.TextBox campoEdad;
        private System.Windows.Forms.TextBox campoApellidos;
        private System.Windows.Forms.ComboBox comboCiudad;
        private System.Windows.Forms.ComboBox comboCiclo;
        private System.Windows.Forms.GroupBox groupBox1;

        public void alureg()
        {
            //validacion de datos utilizando la clase utilidades 
            if (utilidades.Utilidades.EsVacio(campoNombre))
            {
                utilidades.Utilidades.AlertaVacio(campoNombre);
            }
            else if (utilidades.Utilidades.EsVacio(campoApellidos))
            {
                utilidades.Utilidades.AlertaVacio(campoApellidos);
            }
            else if (utilidades.Utilidades.EsVacio(campoEdad))
            {
                utilidades.Utilidades.AlertaVacio(campoEdad);
            } 
            else if (utilidades.Utilidades.NumeroNoCorrecto(campoEdad))
            {
                utilidades.Utilidades.AlertaNumeroNoCorrecto(campoEdad);
            }
            else if (comboCiudad.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione una ciudad");
            }
            else if (comboCiclo.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un ciclo");
            }
            else
            {


                string nom = campoNombre.Text;
                string ape = campoApellidos.Text;
                int ed = Convert.ToInt32(campoEdad.Text);
                string ciu = comboCiudad.Text;
                string cic = comboCiclo.Text;

                Alumno a = new Alumno(nom, ape, ed, ciu, cic);


                if (bbdd.Conexion.RegistrarA(nom, a))
                {

                    DateTime fecha = DateTime.Now;
                    string fechaTexto = fecha.ToString("dd/MM/yyyy HH:mm:ss");

                    File.AppendAllText("Alumnos.txt", "NUEVO ALUMNO" + Environment.NewLine + "----------------------" + Environment.NewLine +
                        $"Fecha: {fechaTexto}" + Environment.NewLine +
                        "----------------------" + Environment.NewLine + Environment.NewLine +
                        $"Nombre: {campoNombre.Text}" + Environment.NewLine +
                        $"Apellidos: {campoApellidos.Text}" + Environment.NewLine +
                        $"Edad: {campoEdad.Text}" + Environment.NewLine +
                        $"Ciudad: {comboCiudad.Text}" + Environment.NewLine +
                        $"Ciclo: {comboCiclo.Text}" + Environment.NewLine + Environment.NewLine +
                        "----------------------" + Environment.NewLine + Environment.NewLine);

                    MessageBox.Show("Usuario registrado correctamente");
                    campoNombre.Text = "";
                    campoApellidos.Text = "";
                    campoEdad.Text = "";
                    comboCiudad.SelectedIndex = 0;
                    comboCiclo.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Error al registrar usuario");
                }
            }
        }
    }
}