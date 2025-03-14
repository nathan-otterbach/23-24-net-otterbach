namespace Vererbung_AnzeigeElement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox_Bedienfeld = new GroupBox();
            label2 = new Label();
            button_Reset = new Button();
            label1 = new Label();
            textBox_Anzahl = new TextBox();
            comboBox_Anzahl = new ComboBox();
            button_Entfernen = new Button();
            button_Hinzufuegen = new Button();
            button_Stop = new Button();
            button_Start = new Button();
            button_Anzeigen = new Button();
            timer_Simulation = new System.Windows.Forms.Timer(components);
            groupBox_Bedienfeld.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_Bedienfeld
            // 
            groupBox_Bedienfeld.Controls.Add(label2);
            groupBox_Bedienfeld.Controls.Add(button_Reset);
            groupBox_Bedienfeld.Controls.Add(label1);
            groupBox_Bedienfeld.Controls.Add(textBox_Anzahl);
            groupBox_Bedienfeld.Controls.Add(comboBox_Anzahl);
            groupBox_Bedienfeld.Controls.Add(button_Entfernen);
            groupBox_Bedienfeld.Controls.Add(button_Hinzufuegen);
            groupBox_Bedienfeld.Controls.Add(button_Stop);
            groupBox_Bedienfeld.Controls.Add(button_Start);
            groupBox_Bedienfeld.Controls.Add(button_Anzeigen);
            groupBox_Bedienfeld.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox_Bedienfeld.Location = new Point(12, 751);
            groupBox_Bedienfeld.Name = "groupBox_Bedienfeld";
            groupBox_Bedienfeld.Size = new Size(343, 248);
            groupBox_Bedienfeld.TabIndex = 1;
            groupBox_Bedienfeld.TabStop = false;
            groupBox_Bedienfeld.Text = "Bedienfeld";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 115);
            label2.Name = "label2";
            label2.Size = new Size(226, 21);
            label2.TabIndex = 9;
            label2.Text = "Fahrer einem Auto zuweisen";
            // 
            // button_Reset
            // 
            button_Reset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Reset.Location = new Point(231, 51);
            button_Reset.Name = "button_Reset";
            button_Reset.Size = new Size(106, 31);
            button_Reset.TabIndex = 8;
            button_Reset.Text = "Reset";
            button_Reset.UseVisualStyleBackColor = true;
            button_Reset.Click += button_Reset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(215, 21);
            label1.TabIndex = 7;
            label1.Text = "Anzahl der Autos festlegen";
            // 
            // textBox_Anzahl
            // 
            textBox_Anzahl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Anzahl.Location = new Point(6, 53);
            textBox_Anzahl.Name = "textBox_Anzahl";
            textBox_Anzahl.Size = new Size(62, 29);
            textBox_Anzahl.TabIndex = 6;
            // 
            // comboBox_Anzahl
            // 
            comboBox_Anzahl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_Anzahl.FormattingEnabled = true;
            comboBox_Anzahl.Location = new Point(6, 139);
            comboBox_Anzahl.Name = "comboBox_Anzahl";
            comboBox_Anzahl.Size = new Size(92, 29);
            comboBox_Anzahl.TabIndex = 5;
            comboBox_Anzahl.SelectedIndexChanged += comboBox_Anzahl_SelectedIndexChanged;
            // 
            // button_Entfernen
            // 
            button_Entfernen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Entfernen.Location = new Point(231, 137);
            button_Entfernen.Name = "button_Entfernen";
            button_Entfernen.Size = new Size(106, 31);
            button_Entfernen.TabIndex = 4;
            button_Entfernen.Text = "Entfernen";
            button_Entfernen.UseVisualStyleBackColor = true;
            button_Entfernen.Click += button_Entfernen_Click;
            // 
            // button_Hinzufuegen
            // 
            button_Hinzufuegen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Hinzufuegen.Location = new Point(115, 137);
            button_Hinzufuegen.Name = "button_Hinzufuegen";
            button_Hinzufuegen.Size = new Size(106, 31);
            button_Hinzufuegen.TabIndex = 3;
            button_Hinzufuegen.Text = "Hinzufuegen";
            button_Hinzufuegen.UseVisualStyleBackColor = true;
            button_Hinzufuegen.Click += button_Hinzufuegen_Click;
            // 
            // button_Stop
            // 
            button_Stop.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Stop.Location = new Point(231, 211);
            button_Stop.Name = "button_Stop";
            button_Stop.Size = new Size(106, 31);
            button_Stop.TabIndex = 2;
            button_Stop.Text = "Stop";
            button_Stop.UseVisualStyleBackColor = true;
            button_Stop.Click += button_Stop_Click;
            // 
            // button_Start
            // 
            button_Start.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Start.Location = new Point(6, 211);
            button_Start.Name = "button_Start";
            button_Start.Size = new Size(106, 31);
            button_Start.TabIndex = 1;
            button_Start.Text = "Start";
            button_Start.UseVisualStyleBackColor = true;
            button_Start.Click += button_Start_Click;
            // 
            // button_Anzeigen
            // 
            button_Anzeigen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Anzeigen.Location = new Point(115, 51);
            button_Anzeigen.Name = "button_Anzeigen";
            button_Anzeigen.Size = new Size(106, 31);
            button_Anzeigen.TabIndex = 0;
            button_Anzeigen.Text = "Anzeigen";
            button_Anzeigen.UseVisualStyleBackColor = true;
            button_Anzeigen.Click += button_Anzeigen_Click;
            // 
            // timer_Simulation
            // 
            timer_Simulation.Interval = 25;
            timer_Simulation.Tick += timer_Simulation_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1011);
            Controls.Add(groupBox_Bedienfeld);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Paint += Form1_Paint;
            groupBox_Bedienfeld.ResumeLayout(false);
            groupBox_Bedienfeld.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Bedienfeld;
        private Button button_Start;
        private Button button_Anzeigen;
        private Button button_Entfernen;
        private Button button_Hinzufuegen;
        private Button button_Stop;
        private Button button_Reset;
        private Label label1;
        private TextBox textBox_Anzahl;
        private ComboBox comboBox_Anzahl;
        private Label label2;
        private System.Windows.Forms.Timer timer_Simulation;
    }
}
