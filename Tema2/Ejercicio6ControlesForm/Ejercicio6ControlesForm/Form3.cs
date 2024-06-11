using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6ControlesForm
{
    public partial class Form3 : Form
    {
        private Form1 formulario;

        public Form3(Form1 formulario1, string nom, string ape1, string ape2, string tel)
        {
            InitializeComponent();
            this.formulario = formulario1;
            cajaTextoNombreF3.Text = nom;
            cajaTextoApe1F3.Text = ape1;
            cajaTextoApe2F3.Text = ape2;
            cajaTextoTelF3.Text = tel;
        }

        private void btnBoton2F3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
