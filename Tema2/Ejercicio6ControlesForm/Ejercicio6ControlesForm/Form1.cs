namespace Ejercicio6ControlesForm
{
    public partial class Form1 : Form
    {

        private List<Forestal> forestales = new List<Forestal>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            new Form2(this).Show();
            this.Hide();
        }

        public List<Forestal> DevolverLista()
        {
            return forestales;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            forestales.RemoveAt(listaForestales.SelectedIndex);
            listaForestales.DataSource = null;
            listaForestales.DataSource = forestales;
        }
        public void ActualizarLista(Forestal f)
        {
            forestales.Add(f);
            listaForestales.DataSource = null;
            listaForestales.DataSource = forestales;
            this.Visible = true;
        }

        public void SetLista(List<Forestal> nuevaLista)
        {
            forestales = nuevaLista;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hay " + forestales.Count + " forestales");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Form3 formulario3 = new Form3(this, forestales[listaForestales.SelectedIndex].Nombre, forestales[listaForestales.SelectedIndex].Apellido1, forestales[listaForestales.SelectedIndex].Apellido2, forestales[listaForestales.SelectedIndex].Telefono);
            formulario3.Show();
        }
    }
}