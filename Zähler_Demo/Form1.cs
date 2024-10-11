namespace Zähler_Demo
{
    public partial class Form1 : Form
    {
        private Cl_Counter _lastCreatedCounter = null;
        private List<Cl_Counter> _counterList = new List<Cl_Counter>();

        public Form1()
        {
            InitializeComponent();
        }

        // zählwert
        private void button3_Click(object sender, EventArgs e)
        {
            if (_lastCreatedCounter == null)
            {
                MessageBox.Show("Bitte erstellen Sie zuerst ein Zählerobjekt.");
                return;
            }

            int newCounterValue;
            if (int.TryParse(textBox1.Text.Trim(), out newCounterValue))
            {
                _lastCreatedCounter.Counter = newCounterValue;
                label1.Text = _lastCreatedCounter.Counter.ToString();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie eine gültige Zahl ein.");
            }
        }

        // löschen
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (var counter in _counterList)
            {
                counter.Dispose();
            }

            _counterList.Clear();
            _lastCreatedCounter = null;

            Form1.ActiveForm.Text = $"Zähler Demo - Zählerobjekte {_counterList.Count}";
        }

        // erstellen
        private void button1_Click(object sender, EventArgs e)
        {
            _lastCreatedCounter = new Cl_Counter();
            _counterList.Add(_lastCreatedCounter);

            timer1.Start();

            Form1.ActiveForm.Text = $"Zähler Demo - Zählerobjekte {_counterList.Count}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_lastCreatedCounter == null)
            {
                MessageBox.Show("Bitte erstellen Sie zuerst ein Zählerobjekt.");
                return;
            }

            _lastCreatedCounter.Counter++;
            label1.Text = _lastCreatedCounter.Counter.ToString();
        }
    }
}
