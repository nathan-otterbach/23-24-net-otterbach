using System;

namespace Vererbung_AnzeigeElement
{
    public partial class Form1 : Form
    {
        private List<CAuto> _autos;
        private List<CParkplatz> _parkplaetze;
        private readonly Random _rnd = new Random(Guid.NewGuid().GetHashCode());

        private int yStart = 50;
        private int xStart = 10;
        private int autoHoehe = 100;
        private int autoBreite = 200;
        private int abstand = 40;


        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            _autos = new List<CAuto>();
            _parkplaetze = new List<CParkplatz>();
        }

        // Autos anzeigen
        private void button_Anzeigen_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_Anzahl.Text, out int anzahl) && anzahl > 0)
            {
                _autos.Clear();
                comboBox_Anzahl.Items.Clear();
                int maximaleAutos = (groupBox_Bedienfeld.Top - yStart) / (autoHoehe + abstand);
                int maxAnzahl = Math.Min(anzahl, maximaleAutos);

                if (anzahl > maximaleAutos)
                {
                    MessageBox.Show($"Es können maximal {maximaleAutos} Autos angezeigt werden!", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (int i = 0; i < anzahl; i++)
                {
                    _autos.Add(new CAuto(
                        xStart,
                        yStart + i * (autoHoehe + abstand),
                        autoHoehe,
                        autoBreite,
                        Color.FromArgb(_rnd.Next(256), _rnd.Next(256), _rnd.Next(256)),
                        Color.LightBlue,
                        Color.Black,
                        _rnd
                    ));

                    _autos[i].FahrerHinzufuegen(Color.PeachPuff, Color.Black, Color.Black);
                    comboBox_Anzahl.Items.Add($"Auto {i + 1}");
                }

                if (_autos.Count > 0)
                {
                    comboBox_Anzahl.SelectedIndex = 0;
                }

                Invalidate();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie eine gültige Anzahl ein!", "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        // Autos komplett enfernen
        private void button_Reset_Click(object sender, EventArgs e)
        {
            _autos.Clear();
            comboBox_Anzahl.Items.Clear();
            comboBox_Anzahl.Text = "";
            textBox_Anzahl.Clear();
            Invalidate();
        }

        // Simulation start
        private void button_Start_Click(object sender, EventArgs e)
        {
            if (_autos.Count == 0)
            {
                MessageBox.Show("Es gibt keine Autos zum Bewegen!", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            timer_Simulation.Start();
        }

        // Simulation stop
        private void button_Stop_Click(object sender, EventArgs e)
        {
            timer_Simulation.Stop();
        }

        // Fahrer hinzufügen
        private void button_Hinzufuegen_Click(object sender, EventArgs e)
        {
            if (comboBox_Anzahl.SelectedIndex >= 0)
            {
                if (!_autos[comboBox_Anzahl.SelectedIndex].hatFahrer)
                {
                    _autos[comboBox_Anzahl.SelectedIndex].FahrerHinzufuegen(Color.PeachPuff, Color.Black, Color.Black);
                    Invalidate();
                }
                else
                {
                    MessageBox.Show("Dieses Auto hat bereits einen Fahrer!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        // Fahrer entfernen
        private void button_Entfernen_Click(object sender, EventArgs e)
        {
            if (comboBox_Anzahl.SelectedIndex >= 0)
            {
                if (_autos[comboBox_Anzahl.SelectedIndex].hatFahrer)
                {
                    _autos[comboBox_Anzahl.SelectedIndex].FahrerEntfernen();
                    Invalidate();
                }
                else
                {
                    MessageBox.Show("Dieses Auto hat keinen Fahrer!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void timer_Simulation_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < _autos.Count; i++)
            {
                _autos[i].draw(e.Graphics);
            }
        }

        private void comboBox_Anzahl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
