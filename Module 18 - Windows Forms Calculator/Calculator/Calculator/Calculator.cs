using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            _op = Operator.Default;
        }

        private Operator _op;
        private string _currentNumber;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (_op == Operator.Default)
            {
                result.Text += button1.Text;
            }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            result.Text += button2.Text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            result.Text += button3.Text;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            result.Text += button4.Text;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            result.Text += button5.Text;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            result.Text += button6.Text;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            result.Text += button7.Text;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            result.Text += button8.Text;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            result.Text += button9.Text;
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            result.Text += button0.Text;
        }

        private void ButtonInmultire_Click(object sender, EventArgs e)
        {
            _currentNumber = result.Text;
            result.Text = "";
            _op = Operator.Inmultit;
        }

        private void ButtonImpartire_Click(object sender, EventArgs e)
        {
            _currentNumber = result.Text;
            result.Text = "";
            _op = Operator.Impartit;
        }

        private void ButtonAdunare_Click(object sender, EventArgs e)
        {
            _currentNumber = result.Text;
            result.Text = "";
            _op = Operator.Plus;
        }

        private void ButtonScadere_Click(object sender, EventArgs e)
        {
            _currentNumber = result.Text;
            result.Text = "";
            _op = Operator.Minus;
        }

        private void ButtonEgal_Click(object sender, EventArgs e)
        {
            var operand1 = int.Parse(result.Text);
            var operand2 = int.Parse(_currentNumber);
            switch (_op)
            {
                case Operator.Plus:
                {
                    result.Text = (operand1 + operand2).ToString();
                    break;
                }

                case Operator.Minus:
                {
                    result.Text = (operand2 - operand1).ToString();
                    break;
                }
                case Operator.Inmultit:
                {
                    result.Text = (operand2 * operand1).ToString();
                    break;
                }
                case Operator.Impartit:
                {
                    result.Text = (operand2 / operand1).ToString();
                    break;
                }
            }
        }
    }
}
