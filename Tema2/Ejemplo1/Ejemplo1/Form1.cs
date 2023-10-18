namespace Ejemplo1
{
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal(string miTexto)
        {
            InitializeComponent();
            Text = miTexto;
        }

        private void botonModal_Click(object sender, EventArgs e)
        {
            /*Abre el formulario de manera MODAL
             * nuevoForm.ShowDialog();*/

            //Abre el formulario de manera NO MODAL
            //new SegundoForm().Show();

            new TercerForm().Show();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Aquamarine;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
        }
    }
}