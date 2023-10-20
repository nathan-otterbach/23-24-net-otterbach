using System.Globalization;

namespace Zahlensysteme_Convert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_in_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_out_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_dezTodual_Click(object sender, EventArgs e)
        {

        }

        private void button_dualTodez_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_in.Text))
            {
                textBox_in.Text = "Bitte Wert eingeben";
            }
            else
            {
                textBox_out.Text = DualToDez(textBox_in.Text).ToString();
            }
        }

        private void button_dextohex_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_in.Text))
            {
                textBox_in.Text = "Bitte Wert eingeben";
            }
            else
            {
                textBox_out.Text = DezToHex(Convert.ToInt32(textBox_in.Text)).ToString();
            }
        }

        private void button_hexTodez_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_in.Text))
            {
                textBox_in.Text = "Bitte Wert eingeben";
            }
            else
            {
                textBox_out.Text = HexToDez(textBox_in.Text).ToString();
            }
        }

        private void button_hexTodual_Click(object sender, EventArgs e)
        {

        }

        private void button_dualTohex_Click(object sender, EventArgs e)
        {

        }

        private int HexToDez(string n)
        {
            return Convert.ToInt32(n, 16);
        }

        private string DezToHex(int n)
        {
            return n.ToString("X");
        }

        private int DualToDez(string n)
        {
            return Convert.ToInt32(n, 2);
        }
    }
}