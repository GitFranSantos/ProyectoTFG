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

        private void rdBtn1_MouseClick(object sender, MouseEventArgs e)
        {
            new TercerForm().Show();
            this.Size = Size;
        }
        private void rdBtn2_MouseClick(object sender, MouseEventArgs e)
        {
            new TercerForm().Show();
            this.Size = new Size(640, 480);
        }

        private void rdBtn2_MouseClick_1(object sender, MouseEventArgs e)
        {
            new TercerForm().Show();
            this.Size = new Size(800, 600);
        }
        private void rdBtn3_MouseClick(object sender, MouseEventArgs e)
        {
            new TercerForm().Show();
            this.Size = new Size(1024, 768);
        }
    }
}
