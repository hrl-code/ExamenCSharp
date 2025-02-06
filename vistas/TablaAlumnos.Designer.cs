namespace ControlCesharp.vistas
{
    partial class TablaAlumnos
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
            this.tablaAlumno = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaAlumno
            // 
            this.tablaAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaAlumno.Location = new System.Drawing.Point(13, 13);
            this.tablaAlumno.Name = "tablaAlumno";
            this.tablaAlumno.RowHeadersWidth = 51;
            this.tablaAlumno.RowTemplate.Height = 24;
            this.tablaAlumno.Size = new System.Drawing.Size(775, 425);
            this.tablaAlumno.TabIndex = 0;
            // 
            // TablaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablaAlumno);
            this.MaximizeBox = false;
            this.Name = "TablaAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TablaAlumnos";
            ((System.ComponentModel.ISupportInitialize)(this.tablaAlumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaAlumno;


    }
}