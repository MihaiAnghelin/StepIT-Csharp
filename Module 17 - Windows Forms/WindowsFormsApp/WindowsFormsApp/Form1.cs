using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void SumaButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Ai apasat pe butonul de suma!");
            //RezultatTextBox.Text = "Ai apasat pe suma";
            ErrorLabel.Text = "";
            int nr1, nr2;
            int rezultat = -1;
            try
            {
                nr1 = int.Parse(Numar1TextBox.Text);
                nr2 = int.Parse(Numar2TextBox.Text);
                rezultat = nr1 + nr2;
            }
            catch (FormatException)
            {
                ErrorLabel.Text = "Una dintre valori nu este numar!";
            }

            RezultatTextBox.Text = rezultat.ToString();
        }

        private void RezultatLabel_Click(object sender, EventArgs e)
        {

        }

        private void Numar2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Numar1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Numar2Label_Click(object sender, EventArgs e)
        {

        }

        private void Numar1Label_Click(object sender, EventArgs e)
        {

        }

        private void numar1_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Numar2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void DiferentaButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            int nr1, nr2;
            int rezultat = -1;
            try
            {
                nr1 = int.Parse(Numar1TextBox.Text);
                nr2 = int.Parse(Numar2TextBox.Text);
                rezultat = nr1 - nr2;
            }
            catch (FormatException)
            {
                ErrorLabel.Text = "Una dintre valori nu este numar!";
            }

            RezultatTextBox.Text = rezultat.ToString();
        }

        private void IncaUnCalculatorButton_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
    }
}
