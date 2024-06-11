using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class TercerForm : Form
    {
        public TercerForm()
        {
            InitializeComponent();
        }

        private void rdBtn1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(600, 480);
        }

        private void rdBtn2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(800, 600);
        }

        private void rdBtn3_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1024, 768);
        }

        private void rdBtnNormal_Click(object sender, EventArgs e)
        {

        }

        private void rdBtnMaximizar_Click(object sender, EventArgs e)
        {

        }
    }
}
