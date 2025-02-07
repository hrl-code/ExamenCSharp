using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCesharp.modelo
{
    internal class Profesor
    {
        string dni, nombre, apellidos, ciclo;
        int salario;
        string turno;

        public Profesor(string dni, string nombre, string apellidos, string ciclo, int salario, string turno)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Ciclo = ciclo;
            this.Salario = salario;
            this.Turno = turno;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Ciclo { get => ciclo; set => ciclo = value; }
        public int Salario { get => salario; set => salario = value; }
        public string Turno { get => turno; set => turno = value; }

        public override string ToString()
        {
            DateTime fecha = DateTime.Now;
            string fechaTexto = fecha.ToString("dd/MM/yyyy HH:mm:ss");

            return "NUEVO PROFESOR" + Environment.NewLine + "----------------------" + Environment.NewLine +
                    $"Fecha: {fechaTexto}" + Environment.NewLine +
                    "----------------------" + Environment.NewLine + Environment.NewLine +
                    $"Nombre: {Nombre}" + Environment.NewLine +
                    $"Apellidos: {Apellidos}" + Environment.NewLine +
                    $"DNI: {Dni}" + Environment.NewLine +
                    $"Ciclo: {Ciclo}" + Environment.NewLine +
                    $"Turno: {Turno}" + Environment.NewLine + Environment.NewLine +
                    "----------------------" + Environment.NewLine + Environment.NewLine;
        }
    }
}
