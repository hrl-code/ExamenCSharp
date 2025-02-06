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
    public partial class TablaAlumnos : Form
    {
        public TablaAlumnos()
        {
            InitializeComponent();
            DataTable tabla = Conexion.getAlumnos();
            tablaAlumno.DataSource = tabla;
        }
    }
}
