namespace AppMDI
{
    public partial class FormPadre : Form
    {
        private List<FormHijo1> listaFormHijo = new List<FormHijo1>();
        public FormPadre()
        {
            InitializeComponent();
        }

        private void MenuItem_Nuevo_Click(object sender, EventArgs e)
        {
            FormHijo1 nuevoFormHijo;

            if(listaFormHijo.Count == 0)
            {
                nuevoFormHijo = new FormHijo1("");
            }
            else
            {
                nuevoFormHijo = new FormHijo1(listaFormHijo[listaFormHijo.Count-1].GetCajaTxt());
            }
            
            nuevoFormHijo.MdiParent = this;
            nuevoFormHijo.Show();
            listaFormHijo.Add(nuevoFormHijo);
            //MenuItem_Nuevo.Enabled = false;

            
        }
        public void HabilitarNuevo()
        {
            //Metodo publico para poder habilitar el boton nuevo desde el formHijo
            //MenuItem_Nuevo.Enabled = true;
        }
        public void Eliminar_lista(FormHijo1 formHijo)
        {
            listaFormHijo.Remove(formHijo);
        }
    }
}