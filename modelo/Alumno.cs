using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCesharp.modelo
{
    internal class Alumno
    {
        string nombre, apellidos;
        int edad;
        string ciudad, ciclo;

        public Alumno(string nombre, string apellidos, int edad, string ciudad, string ciclo)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Edad = edad;
            this.Ciudad = ciudad;
            this.Ciclo = ciclo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Ciclo { get => ciclo; set => ciclo = value; }

        public override string ToString()
        {
            DateTime fecha = DateTime.Now;
            string fechaTexto = fecha.ToString("dd/MM/yyyy HH:mm:ss");

            return "NUEVO ALUMNO" + Environment.NewLine + "----------------------" + Environment.NewLine +
                        $"Fecha: {fechaTexto}" + Environment.NewLine +
                        "----------------------" + Environment.NewLine + Environment.NewLine +
                        $"Nombre: {Nombre}" + Environment.NewLine +
                        $"Apellidos: {Apellidos}" + Environment.NewLine +
                        $"Edad: {Edad}" + Environment.NewLine +
                        $"Ciudad: {Ciudad}" + Environment.NewLine +
                        $"Ciclo: {Ciclo}" + Environment.NewLine + Environment.NewLine +
                        "----------------------" + Environment.NewLine + Environment.NewLine);
        }
    }
}
