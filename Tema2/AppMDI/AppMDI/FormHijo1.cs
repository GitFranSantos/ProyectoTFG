using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMDI
{
    public partial class FormHijo1 : Form
    {
        //Hacemos un atributo privado para pasarselo en el constructor
        private FormPadre fp;



        //Le pasamos por parametro un formPadre para poder usar los metodos del formPadre
        public FormHijo1(FormPadre fp)
        {
            InitializeComponent();
            //Ese atributo FormPadre es el FormPadre pasado por parametro
            this.fp = fp;
        }
        public FormHijo1(String txtAsignar)
        {
            InitializeComponent();
            CajaTxt.Text = txtAsignar;
        }

        private void FormHijo1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Llamamos al metodo publico para volver a habilitar el boton "nuevo"
            //fp.HabilitarNuevo();
        }
        public string GetCajaTxt()
        {
            return CajaTxt.Text;
        }

        private void FormHijo1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Se hace un casting para poder comunicarse con el formPadre usando el .Mdiparent y llamamos al metodo
            ((FormPadre)this.MdiParent).Eliminar_lista(this);
        }
    }
}
