namespace _3D_Array
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
            button_3d_ausgeben = new Button();
            button_3d_loeschen = new Button();
            richTextBox1 = new RichTextBox();
            button_reservieren = new Button();
            textBox_reihe = new TextBox();
            textBox_platz = new TextBox();
            textBox_saal = new TextBox();
            label_saal = new Label();
            label_reihe = new Label();
            label_platz = new Label();
            button_stornieren = new Button();
            SuspendLayout();
            // 
            // button_3d_ausgeben
            // 
            button_3d_ausgeben.Location = new Point(69, 21);
            button_3d_ausgeben.Name = "button_3d_ausgeben";
            button_3d_ausgeben.Size = new Size(150, 23);
            button_3d_ausgeben.TabIndex = 0;
            button_3d_ausgeben.Text = "3d ausgeben";
            button_3d_ausgeben.UseVisualStyleBackColor = true;
            button_3d_ausgeben.Click += button_3d_ausgeben_Click;
            // 
            // button_3d_loeschen
            // 
            button_3d_loeschen.Location = new Point(69, 50);
            button_3d_loeschen.Name = "button_3d_loeschen";
            button_3d_loeschen.Size = new Size(150, 23);
            button_3d_loeschen.TabIndex = 1;
            button_3d_loeschen.Text = "3d loeschen";
            button_3d_loeschen.UseVisualStyleBackColor = true;
            button_3d_loeschen.Click += button_3d_loeschen_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(271, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(282, 230);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // button_reservieren
            // 
            button_reservieren.Location = new Point(69, 79);
            button_reservieren.Name = "button_reservieren";
            button_reservieren.Size = new Size(150, 23);
            button_reservieren.TabIndex = 3;
            button_reservieren.Text = "reservieren";
            button_reservieren.UseVisualStyleBackColor = true;
            button_reservieren.Click += button_reservieren_Click;
            // 
            // textBox_reihe
            // 
            textBox_reihe.Location = new Point(119, 188);
            textBox_reihe.Name = "textBox_reihe";
            textBox_reihe.Size = new Size(100, 23);
            textBox_reihe.TabIndex = 4;
            // 
            // textBox_platz
            // 
            textBox_platz.Location = new Point(119, 217);
            textBox_platz.Name = "textBox_platz";
            textBox_platz.Size = new Size(100, 23);
            textBox_platz.TabIndex = 5;
            // 
            // textBox_saal
            // 
            textBox_saal.Location = new Point(119, 159);
            textBox_saal.Name = "textBox_saal";
            textBox_saal.Size = new Size(100, 23);
            textBox_saal.TabIndex = 6;
            // 
            // label_saal
            // 
            label_saal.AutoSize = true;
            label_saal.Location = new Point(52, 162);
            label_saal.Name = "label_saal";
            label_saal.Size = new Size(28, 15);
            label_saal.TabIndex = 7;
            label_saal.Text = "Saal";
            // 
            // label_reihe
            // 
            label_reihe.AutoSize = true;
            label_reihe.Location = new Point(52, 191);
            label_reihe.Name = "label_reihe";
            label_reihe.Size = new Size(36, 15);
            label_reihe.TabIndex = 8;
            label_reihe.Text = "Reihe";
            // 
            // label_platz
            // 
            label_platz.AutoSize = true;
            label_platz.Location = new Point(52, 220);
            label_platz.Name = "label_platz";
            label_platz.Size = new Size(32, 15);
            label_platz.TabIndex = 9;
            label_platz.Text = "Platz";
            // 
            // button_stornieren
            // 
            button_stornieren.Location = new Point(69, 108);
            button_stornieren.Name = "button_stornieren";
            button_stornieren.Size = new Size(150, 23);
            button_stornieren.TabIndex = 10;
            button_stornieren.Text = "stornieren";
            button_stornieren.UseVisualStyleBackColor = true;
            button_stornieren.Click += button_stornieren_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_stornieren);
            Controls.Add(label_platz);
            Controls.Add(label_reihe);
            Controls.Add(label_saal);
            Controls.Add(textBox_saal);
            Controls.Add(textBox_platz);
            Controls.Add(textBox_reihe);
            Controls.Add(button_reservieren);
            Controls.Add(richTextBox1);
            Controls.Add(button_3d_loeschen);
            Controls.Add(button_3d_ausgeben);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_3d_ausgeben;
        private Button button_3d_loeschen;
        private RichTextBox richTextBox1;
        private Button button_reservieren;
        private TextBox textBox_reihe;
        private TextBox textBox_platz;
        private TextBox textBox_saal;
        private Label label_saal;
        private Label label_reihe;
        private Label label_platz;
        private Button button_stornieren;
    }
}
