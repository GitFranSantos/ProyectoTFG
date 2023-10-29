namespace Ejercicio6ControlesForm
{
    public partial class Form2 : Form
    {

        private Form1 formulario;
        public Form2(Form1 formulario1)
        {
            InitializeComponent();
            this.formulario = formulario1;
        }

        private void btnBoton1_Click(object sender, EventArgs e)
        {

            Forestal nuevoForestal = new Forestal();

            if (cajaTextoNombre.Text.Length > 0 || cajaTextoApe1.Text.Length > 0 || cajaTextoApe2.Text.Length > 0 || cajaTextoTel.Text.Length > 0)
            {
                nuevoForestal.Nombre = cajaTextoNombre.Text;
                nuevoForestal.Apellido1 = cajaTextoApe1.Text;
                nuevoForestal.Apellido2 = cajaTextoApe2.Text;
                nuevoForestal.Telefono = cajaTextoTel.Text;
                formulario.ActualizarLista(nuevoForestal);
                MessageBox.Show("Datos introducidos correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Rellena todos los campos");
            }
        }

        private void btnBoton2_Click(object sender, EventArgs e)
        {
            this.Close();
            formulario.Visible = true;
        }
    }
}
