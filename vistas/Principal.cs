using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCesharp.vistas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            crearFicheros();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormularioAlumnos fa = new FormularioAlumnos();
            fa.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TablaAlumnos ta = new TablaAlumnos();
            ta.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormularioProfesores fp = new FormularioProfesores();
            fp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TablaProfesores tp = new TablaProfesores();
            tp.ShowDialog();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            abrirProfesores();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            abrirAlumnos();
        }
    }
}
