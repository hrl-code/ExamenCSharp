namespace ControlCesharp.vistas
{
    partial class TablaProfesores
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
            this.tablaProfe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProfe)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaProfe
            // 
            this.tablaProfe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProfe.Location = new System.Drawing.Point(12, 12);
            this.tablaProfe.Name = "tablaProfe";
            this.tablaProfe.RowHeadersWidth = 51;
            this.tablaProfe.RowTemplate.Height = 24;
            this.tablaProfe.Size = new System.Drawing.Size(776, 426);
            this.tablaProfe.TabIndex = 0;
            // 
            // TablaProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablaProfe);
            this.MaximizeBox = false;
            this.Name = "TablaProfesores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TablaProfesores";
            ((System.ComponentModel.ISupportInitialize)(this.tablaProfe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaProfe;
    }
}