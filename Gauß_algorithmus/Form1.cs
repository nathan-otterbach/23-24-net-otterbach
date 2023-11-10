using System.Diagnostics;

namespace Gauß_algorithmus
{
    public partial class Form1 : Form
    {
        private Stopwatch sw;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            textBox1.Text = "1";
            textBox2.Text = "100";
            CalculateAndDisplayResult();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            textBox1.Text = "50";
            textBox2.Text = "500000";
            CalculateAndDisplayResult();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            textBox1.Text = "1";
            textBox2.Text = "1000000";
            CalculateAndDisplayResult();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calculate and display the result when the custom calculation button is clicked.
            CalculateAndDisplayResult();
        }

        private void ClearTextBoxes()
        {
            // Clear all textboxes.
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        /*
         * Calculates the sum of consecutive integers using the Gauss algorithm.
         *
         * @param start The starting integer of the sequence.
         * @param end The ending integer of the sequence.
         * @return The sum of integers from 'start' to 'end' (inclusive).
         */
        private ulong GaussAlgo(uint start, uint end)
        {
            // Calculate the number of integers in the sequence from 'start' to 'end'.
            ulong m = (end - start) + 1;
            ulong n = start + end;

            // Use the Gauss formula to find the sum of integers from 'start' to 'end'.
            // The formula (n * (n + 1)) / 2 sums the integers from 1 to 'n'.
            ulong sum = (n * m) / 2;

            return sum;
        }

        private ulong GaussAlgo_iter(uint start, uint end)
        {
            ulong sum = 0;
            for (uint i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }


        private void CalculateAndDisplayResult()
        {
            if (uint.TryParse(textBox1.Text, out uint start)
                && uint.TryParse(textBox2.Text, out uint end)
                && start < end)
            {
                ulong result;
                decimal ticks;
                // Calculate and display the result if input is valid.
                if (checkBox1.Checked)
                {
                    sw = Stopwatch.StartNew();
                    result = GaussAlgo_iter(start, end);
                    ticks = sw.ElapsedTicks;
                }
                else
                {
                    sw = Stopwatch.StartNew();
                    result = GaussAlgo(start, end);
                    ticks = sw.ElapsedTicks;
                }
                textBox3.Text = result.ToString();

                decimal microseconds = Math.Round((ticks / Stopwatch.Frequency) * 1000000, 3);
                textBox4.Text = microseconds.ToString();
            }
            else
            {
                // Display an error message for invalid input.
                textBox3.Text = "Invalid input!";
            }
        }
    }
}