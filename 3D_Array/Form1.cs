namespace _3D_Array
{
    public partial class Form1 : Form
    {
        const int saele = 2;
        const int platz = 3;
        const int reihe = 4;
        string[,,] KINO = new string[saele, reihe, platz] { { { "-","x","-" }, { "-","-","x" }, { "x","-","-" }, { "-","x","-" } },
                                                            { { "x","-","-" }, { "-","x","-" }, { "-","-","x" }, { "-","x","-" } } };
        string belegung = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_3d_ausgeben_Click(object sender, EventArgs e)
        {
            belegung = "";
            richTextBox1.Clear();
            for (int i = 0; i < saele; i++)
            {
                belegung += "Saal " + Convert.ToString(i + 1) + ":" + Environment.NewLine;
                for (int j = 0; j < reihe; j++)
                {
                    for (int k = 0; k < platz; k++)
                    {
                        belegung += KINO[i, j, k] + " ";
                    }
                    belegung += "\n";
                }
                belegung += "\n";
            }
            richTextBox1.Text = belegung;
        }

        private void button_reservieren_Click(object sender, EventArgs e)
        {
            int gewuenschter_saal = Convert.ToInt16(textBox_saal.Text) - 1;
            int gewuenschte_reihe = Convert.ToInt16(textBox_reihe.Text) - 1;
            int gewuenschter_platz = Convert.ToInt16(textBox_platz.Text) - 1;

            if (KINO[gewuenschter_saal, gewuenschte_reihe, gewuenschter_platz].Equals("-"))
            {
                KINO[gewuenschter_saal, gewuenschte_reihe, gewuenschter_platz] = "x";
            }
            else
            {
                richTextBox1.Text = "Platz besetzt. Reservierung nicht moeglich";
            }
        }

        private void button_3d_loeschen_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button_stornieren_Click(object sender, EventArgs e)
        {
            int gewuenschter_saal = Convert.ToInt16(textBox_saal.Text) - 1;
            int gewuenschte_reihe = Convert.ToInt16(textBox_reihe.Text) - 1;
            int gewuenschter_platz = Convert.ToInt16(textBox_platz.Text) - 1;

            if (KINO[gewuenschter_saal, gewuenschte_reihe, gewuenschter_platz].Equals("x"))
            {
                KINO[gewuenschter_saal, gewuenschte_reihe, gewuenschter_platz] = "-";
            }
            else
            {
                richTextBox1.Text = "Stornieren nicht möglich. Platz bereits storniert";
            }
        }
    }
}
