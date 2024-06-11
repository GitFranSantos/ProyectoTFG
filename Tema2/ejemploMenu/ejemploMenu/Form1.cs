namespace ejemploMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MenuItemSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MenuItemAcerca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ejemplo de menu");
        }
        private void MenuItemSumar_Click(object sender, EventArgs e)
        {
            try
            {
                double resultado;
                double num1 = double.Parse(txtA.Text);
                double num2 = double.Parse(txtB.Text);
                resultado = num1 + num2;
                labelA.Text = "Resultado: " + resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Solo se admiten numeros");
            }
        }

        private void MenuItemRestar_Click(object sender, EventArgs e)
        {
            try
            {
                double resultado;
                double num1 = double.Parse(txtA.Text);
                double num2 = double.Parse(txtB.Text);
                resultado = num1 - num2;
                labelA.Text = "Resultado: " + resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Solo se admiten numeros");
            }
        }

        private void MenuItemMultiplicacion_Click(object sender, EventArgs e)
        {
            try
            {
                double resultado;
                double num1 = double.Parse(txtA.Text);
                double num2 = double.Parse(txtB.Text);
                resultado = num1 * num2;
                labelA.Text = "Resultado: " + resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Solo se admiten numeros");
            }
        }

        private void MenuItemDivision_Click(object sender, EventArgs e)
        {
            try
            {
                double resultado;
                double num1 = double.Parse(txtA.Text);
                double num2 = double.Parse(txtB.Text);
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    labelA.Text = "Resultado: " + resultado.ToString();
                }
                else
                {
                    MessageBox.Show("No se puede dividir por cero");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Solo se admiten numeros");
            }
        }

        private void MenuContextualTxtA_Resetear_Click(object sender, EventArgs e)
        {
            txtA.Text = null;
        }

        private void MenuContextualTxtA_CalcularAleatorio_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            txtA.Text = num.Next(0, 101).ToString();
        }

        private void MenuItemColor_Fondo_Click(object sender, EventArgs e)
        {
            ColorDialog cajaColores = new ColorDialog();

            if (cajaColores.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = cajaColores.Color;
            }
        }

        private void MenuItemConfi_Fuente_Click(object sender, EventArgs e)
        {
            FontDialog tipoFuente = new FontDialog();

            if (tipoFuente.ShowDialog() == DialogResult.OK)
            {
                txtA.Font = tipoFuente.Font;
                txtB.Font = tipoFuente.Font;
                labelA.Font = tipoFuente.Font;
            }
        }

        private void MenuItemColor_Fuente_Click(object sender, EventArgs e)
        {
            ColorDialog cajaColores = new ColorDialog();

            if (cajaColores.ShowDialog() == DialogResult.OK)
            {
                txtA.ForeColor = cajaColores.Color;
                txtB.ForeColor = cajaColores.Color;
                labelA.ForeColor = cajaColores.Color;
            }
        }

        private void MenuContextualTxtB_Resetear_Click(object sender, EventArgs e)
        {
            txtA.Text = null;
        }

    }
}