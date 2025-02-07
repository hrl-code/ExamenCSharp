using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCesharp.bbdd;

namespace ControlCesharp.vistas
{
    public partial class TablaProfesores : Form
    {
        public TablaProfesores()
        {
            InitializeComponent();
            DataTable tabla = Conexion.getProfesores();
            tablaProfe.DataSource = tabla;
        }
    }
}
