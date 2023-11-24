using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5._7
{
    public partial class FormHijo : Form
    {
        private ConexionBdd conexion;
        private DataTable dt;
        private int indiceActual = 0;
        public FormHijo(ConexionBdd conexion)
        {
            InitializeComponent();
            if (dt != null && dt.Rows.Count == 0)
            {
                buttonAtras.Enabled = false;
                buttonPrincipio.Enabled = false;
                buttonAvanzar.Enabled = false;
                buttonFinal.Enabled = false;
            }
            textBoxDNI.Text = conexion.GetPrimeraFila()["DNI"].ToString();
            textBoxNombre.Text = conexion.GetPrimeraFila()["nombre"].ToString();
            textBoxApellidos.Text = conexion.GetPrimeraFila()["apellidos"].ToString();
            textBoxTelefono.Text = conexion.GetPrimeraFila()["telefono"].ToString();
            textBoxEmail.Text = conexion.GetPrimeraFila()["email"].ToString();
            this.conexion = conexion;
        }

        private void FormHijo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonPrincipio_Click(object sender, EventArgs e)
        {
            if (indiceActual == 0)
            {
                buttonAtras.Enabled = false;
                buttonPrincipio.Enabled = false;
                buttonAvanzar.Enabled = true;
                buttonFinal.Enabled = true;
            }
            textBoxDNI.Text = conexion.GetPrimeraFila()["DNI"].ToString();
            textBoxNombre.Text = conexion.GetPrimeraFila()["nombre"].ToString();
            textBoxApellidos.Text = conexion.GetPrimeraFila()["apellidos"].ToString();
            textBoxTelefono.Text = conexion.GetPrimeraFila()["telefono"].ToString();
            textBoxEmail.Text = conexion.GetPrimeraFila()["email"].ToString();
            indiceActual = 0;
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            indiceActual--;
            if (indiceActual == 0)
            {
                buttonAtras.Enabled = false;
                buttonPrincipio.Enabled = false;
                buttonAvanzar.Enabled = true;
                buttonFinal.Enabled = true;
            }
            
            textBoxDNI.Text = conexion.GetSiguiente(indiceActual)["DNI"].ToString();
            textBoxNombre.Text = conexion.GetSiguiente(indiceActual)["nombre"].ToString();
            textBoxApellidos.Text = conexion.GetSiguiente(indiceActual)["apellidos"].ToString();
            textBoxTelefono.Text = conexion.GetSiguiente(indiceActual)["telefono"].ToString();
            textBoxEmail.Text = conexion.GetSiguiente(indiceActual)["email"].ToString();
        }

        private void buttonAvanzar_Click(object sender, EventArgs e)
        {
            indiceActual++;
            if (indiceActual <= conexion.GetLongitudTabla())
            {
                buttonAtras.Enabled = true;
                buttonPrincipio.Enabled = true;
                buttonAvanzar.Enabled = false;
                buttonFinal.Enabled = false;
            }
            textBoxDNI.Text = conexion.GetSiguiente(indiceActual)["DNI"].ToString();
            textBoxNombre.Text = conexion.GetSiguiente(indiceActual)["nombre"].ToString();
            textBoxApellidos.Text = conexion.GetSiguiente(indiceActual)["apellidos"].ToString();
            textBoxTelefono.Text = conexion.GetSiguiente(indiceActual)["telefono"].ToString();
            textBoxEmail.Text = conexion.GetSiguiente(indiceActual)["email"].ToString();
        }

        private void buttonFinal_Click(object sender, EventArgs e)
        {
            if (indiceActual <= conexion.GetLongitudTabla())
            {
                buttonAtras.Enabled = true;
                buttonPrincipio.Enabled = true;
                buttonAvanzar.Enabled = false;
                buttonFinal.Enabled = false;
            }
            textBoxDNI.Text = conexion.GetUltimaFila()["DNI"].ToString();
            textBoxNombre.Text = conexion.GetUltimaFila()["nombre"].ToString();
            textBoxApellidos.Text = conexion.GetUltimaFila()["apellidos"].ToString();
            textBoxTelefono.Text = conexion.GetUltimaFila()["telefono"].ToString();
            textBoxEmail.Text = conexion.GetUltimaFila()["email"].ToString();
            indiceActual = conexion.GetLongitudTabla();
        }
    }
}
