using System;
using System.IO;
using System.Windows.Forms;
using ControlCesharp.modelo;

namespace ControlCesharp.vistas
{
    partial class FormularioProfesores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.comboTurno = new System.Windows.Forms.ComboBox();
            this.campoSalario = new System.Windows.Forms.TextBox();
            this.comboCiclo = new System.Windows.Forms.ComboBox();
            this.campoApellidos = new System.Windows.Forms.TextBox();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.campoDNI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botonRegistrar);
            this.groupBox1.Controls.Add(this.comboTurno);
            this.groupBox1.Controls.Add(this.campoSalario);
            this.groupBox1.Controls.Add(this.comboCiclo);
            this.groupBox1.Controls.Add(this.campoApellidos);
            this.groupBox1.Controls.Add(this.campoNombre);
            this.groupBox1.Controls.Add(this.campoDNI);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(123, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 436);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NUEVO PREFESOR ";
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistrar.Location = new System.Drawing.Point(183, 349);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(141, 51);
            this.botonRegistrar.TabIndex = 14;
            this.botonRegistrar.Text = "Registrar";
            this.botonRegistrar.UseVisualStyleBackColor = true;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // comboTurno
            // 
            this.comboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTurno.FormattingEnabled = true;
            this.comboTurno.Items.AddRange(new object[] {
            "Seleccione",
            "Mañanas",
            "Tardes",
            "Nocturno"});
            this.comboTurno.Location = new System.Drawing.Point(183, 260);
            this.comboTurno.Name = "comboTurno";
            this.comboTurno.Size = new System.Drawing.Size(121, 24);
            this.comboTurno.TabIndex = 13;
            this.comboTurno.Tag = "Turno";
            // 
            // campoSalario
            // 
            this.campoSalario.Location = new System.Drawing.Point(183, 216);
            this.campoSalario.Name = "campoSalario";
            this.campoSalario.Size = new System.Drawing.Size(163, 22);
            this.campoSalario.TabIndex = 12;
            this.campoSalario.Tag = "Salario";
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
            this.comboCiclo.Location = new System.Drawing.Point(183, 172);
            this.comboCiclo.Name = "comboCiclo";
            this.comboCiclo.Size = new System.Drawing.Size(121, 24);
            this.comboCiclo.TabIndex = 11;
            this.comboCiclo.Tag = "Ciclo";
            // 
            // campoApellidos
            // 
            this.campoApellidos.Location = new System.Drawing.Point(183, 136);
            this.campoApellidos.Name = "campoApellidos";
            this.campoApellidos.Size = new System.Drawing.Size(163, 22);
            this.campoApellidos.TabIndex = 10;
            this.campoApellidos.Tag = "Apellidos";
            // 
            // campoNombre
            // 
            this.campoNombre.Location = new System.Drawing.Point(183, 96);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(163, 22);
            this.campoNombre.TabIndex = 8;
            this.campoNombre.Tag = "Nombre";
            // 
            // campoDNI
            // 
            this.campoDNI.Location = new System.Drawing.Point(183, 58);
            this.campoDNI.Name = "campoDNI";
            this.campoDNI.Size = new System.Drawing.Size(163, 22);
            this.campoDNI.TabIndex = 6;
            this.campoDNI.Tag = "DNI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Turno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ciclo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // FormularioProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormularioProfesores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioProfesores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonRegistrar;
        private System.Windows.Forms.ComboBox comboTurno;
        private System.Windows.Forms.TextBox campoSalario;
        private System.Windows.Forms.ComboBox comboCiclo;
        private System.Windows.Forms.TextBox campoApellidos;
        private System.Windows.Forms.TextBox campoNombre;
        private System.Windows.Forms.TextBox campoDNI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        public void profreg()
        {

            if (utilidades.Utilidades.EsVacio(campoDNI))
            {
                utilidades.Utilidades.AlertaVacio(campoDNI);
            }
            else if (utilidades.Utilidades.DniNoValido(campoDNI))
            {
                MessageBox.Show("DNI no valido");
            }
            else if (utilidades.Utilidades.EsVacio(campoNombre))
            {
                utilidades.Utilidades.AlertaVacio(campoNombre);
            }
            else if (utilidades.Utilidades.EsVacio(campoApellidos))
            {
                utilidades.Utilidades.AlertaVacio(campoApellidos);
            }
            else if (comboCiclo.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un ciclo");
            }
            else if (utilidades.Utilidades.EsVacio(campoSalario))
            {
                utilidades.Utilidades.AlertaVacio(campoSalario);
            }
            else if (utilidades.Utilidades.NumeroNoCorrecto(campoSalario))
            {
                utilidades.Utilidades.AlertaNumeroNoCorrecto(campoSalario);
            }
            else if (comboTurno.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione un turno");
            }
            else
            {
                string nom = campoNombre.Text;
                string ape = campoApellidos.Text;
                string dni = campoDNI.Text;
                string ciclo = comboCiclo.Text;
                int salario = Convert.ToInt32(campoSalario.Text);
                string turno = comboTurno.Text;

                Profesor p = new Profesor(nom, ape, dni, ciclo, salario, turno);


                if (bbdd.Conexion.RegistrarP(nom, p))
                {
                    File.AppendAllText("Profesores.txt", p.ToString());   

                    MessageBox.Show("Profesor registrado correctamente");
                    campoApellidos.Text = "";
                    campoDNI.Text = "";
                    campoNombre.Text = "";
                    campoSalario.Text = "";
                    comboCiclo.SelectedIndex = 0;
                    comboTurno.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Error al registrar usuario");
                }
            }
        }
    }
}