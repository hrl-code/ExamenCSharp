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
    public partial class FormularioProfesores : Form
    {
        public FormularioProfesores()
        {
            InitializeComponent();
            comboCiclo.SelectedIndex = 0;
            comboTurno.SelectedIndex = 0;

        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            profreg();
        }
    }
}
