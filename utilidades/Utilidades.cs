using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCesharp.utilidades
{
    internal class Utilidades
    {

        public static bool EsVacio(TextBox campo)
        {
            return string.IsNullOrWhiteSpace(campo.Text);
        }

        public static void AlertaVacio(TextBox campo)
        {
            MessageBox.Show($"El campo {campo.Tag} no puede estar vacío", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool NumeroNoCorrecto(TextBox campo)
        {
            return !int.TryParse(campo.Text, out _);
        }

        public static void AlertaNumeroNoCorrecto(TextBox campo)
        {
            MessageBox.Show($"El campo {campo.Tag} no es un número correcto", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool PrecioNoCorrecto(TextBox campo)
        {
            return !double.TryParse(campo.Text, out _);
        }

        public static void AlertaPrecioNoCorrecto(TextBox campo)
        {
            MessageBox.Show($"El campo {campo.Tag} no es un precio correcto", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool CorreoNoValido(TextBox campo)
        {
            if (EsVacio(campo)) return true;

            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return !Regex.IsMatch(campo.Text, patronCorreo, RegexOptions.IgnoreCase);
        }

        public static void AlertaCorreoNoValido(TextBox campo)
        {
            MessageBox.Show($"El campo {campo.Tag} no es un correo electrónico válido", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool TelefonoNoValido(TextBox campo)
        {
            if (EsVacio(campo)) return true;

            string patronTelefono = @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$";
            return !Regex.IsMatch(campo.Text, patronTelefono);
        }

        public static void AlertaTelefonoNoValido(TextBox campo)
        {
            MessageBox.Show($"El campo {campo.Tag} no es un número de teléfono válido", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool ContrasenaNoValida(TextBox campo)
        {
            if (EsVacio(campo)) return true;

            // Criterios: 
            // - Al menos 8 caracteres
            // - Al menos una mayúscula
            // - Al menos una minúscula
            // - Al menos un número
            // - Al menos un carácter especial
            string patronContrasena = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            return !Regex.IsMatch(campo.Text, patronContrasena);
        }

        public static void AlertaContrasenaNoValida(TextBox campo)
        {
            MessageBox.Show($"El campo {campo.Tag} no cumple con los requisitos de seguridad", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool SoloLetrasNoValido(TextBox campo)
        {
            if (EsVacio(campo)) return true;

            return !Regex.IsMatch(campo.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$");
        }

        public static void AlertaSoloLetrasNoValido(TextBox campo)
        {
            MessageBox.Show($"El campo {campo.Tag} solo debe contener letras", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static int ConvertirANumero(TextBox campo)
        {
            return int.Parse(campo.Text);
        }

        public static double ConvertirAPrecio(TextBox campo)
        {
            return double.Parse(campo.Text);
        }
    }
}
