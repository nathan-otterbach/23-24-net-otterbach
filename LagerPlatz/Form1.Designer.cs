namespace LagerPlatz
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
            groupBox2 = new GroupBox();
            label6 = new Label();
            pictureBox_abgelaufen = new PictureBox();
            label_Belegt = new Label();
            label_Frei = new Label();
            pictureBox_kritisch = new PictureBox();
            pictureBox_normal = new PictureBox();
            groupBox3 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboBox_Regalnummer = new ComboBox();
            comboBox_Status = new ComboBox();
            button_kritisch = new Button();
            comboBox_Ebene = new ComboBox();
            button_Status = new Button();
            groupBox4 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            Platz3 = new Label();
            Platz2 = new Label();
            Platz1 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_abgelaufen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_kritisch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_normal).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(pictureBox_abgelaufen);
            groupBox2.Controls.Add(label_Belegt);
            groupBox2.Controls.Add(label_Frei);
            groupBox2.Controls.Add(pictureBox_kritisch);
            groupBox2.Controls.Add(pictureBox_normal);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 175);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(252, 200);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hinweis";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(139, 151);
            label6.Name = "label6";
            label6.Size = new Size(107, 25);
            label6.TabIndex = 6;
            label6.Text = "abgelaufen";
            // 
            // pictureBox_abgelaufen
            // 
            pictureBox_abgelaufen.BackColor = Color.Red;
            pictureBox_abgelaufen.Location = new Point(15, 145);
            pictureBox_abgelaufen.Name = "pictureBox_abgelaufen";
            pictureBox_abgelaufen.Size = new Size(100, 35);
            pictureBox_abgelaufen.TabIndex = 5;
            pictureBox_abgelaufen.TabStop = false;
            // 
            // label_Belegt
            // 
            label_Belegt.AutoSize = true;
            label_Belegt.Location = new Point(140, 95);
            label_Belegt.Name = "label_Belegt";
            label_Belegt.Size = new Size(72, 25);
            label_Belegt.TabIndex = 4;
            label_Belegt.Text = "kritisch";
            // 
            // label_Frei
            // 
            label_Frei.AutoSize = true;
            label_Frei.Location = new Point(140, 40);
            label_Frei.Name = "label_Frei";
            label_Frei.Size = new Size(72, 25);
            label_Frei.TabIndex = 3;
            label_Frei.Text = "normal";
            // 
            // pictureBox_kritisch
            // 
            pictureBox_kritisch.BackColor = Color.Yellow;
            pictureBox_kritisch.Location = new Point(15, 88);
            pictureBox_kritisch.Name = "pictureBox_kritisch";
            pictureBox_kritisch.Size = new Size(100, 35);
            pictureBox_kritisch.TabIndex = 2;
            pictureBox_kritisch.TabStop = false;
            // 
            // pictureBox_normal
            // 
            pictureBox_normal.BackColor = Color.Green;
            pictureBox_normal.Location = new Point(15, 32);
            pictureBox_normal.Name = "pictureBox_normal";
            pictureBox_normal.Size = new Size(100, 35);
            pictureBox_normal.TabIndex = 1;
            pictureBox_normal.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(comboBox_Regalnummer);
            groupBox3.Controls.Add(comboBox_Status);
            groupBox3.Controls.Add(button_kritisch);
            groupBox3.Controls.Add(comboBox_Ebene);
            groupBox3.Controls.Add(button_Status);
            groupBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(453, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(335, 369);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Status ändern";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 41);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 10;
            label5.Text = "Ebene";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 101);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 9;
            label4.Text = "Regalnummer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 160);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 8;
            label3.Text = "Status";
            // 
            // comboBox_Regalnummer
            // 
            comboBox_Regalnummer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_Regalnummer.FormattingEnabled = true;
            comboBox_Regalnummer.Items.AddRange(new object[] { "Platz 1", "Platz 2", "Platz 3", "Platz 4" });
            comboBox_Regalnummer.Location = new Point(157, 101);
            comboBox_Regalnummer.Name = "comboBox_Regalnummer";
            comboBox_Regalnummer.Size = new Size(172, 29);
            comboBox_Regalnummer.TabIndex = 7;
            // 
            // comboBox_Status
            // 
            comboBox_Status.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_Status.FormattingEnabled = true;
            comboBox_Status.Items.AddRange(new object[] { "normal", "kritisch", "abgelaufen" });
            comboBox_Status.Location = new Point(157, 160);
            comboBox_Status.Name = "comboBox_Status";
            comboBox_Status.Size = new Size(172, 29);
            comboBox_Status.TabIndex = 6;
            // 
            // button_kritisch
            // 
            button_kritisch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_kritisch.Location = new Point(54, 323);
            button_kritisch.Name = "button_kritisch";
            button_kritisch.Size = new Size(226, 40);
            button_kritisch.TabIndex = 5;
            button_kritisch.Text = "kritisch entfernen";
            button_kritisch.UseVisualStyleBackColor = true;
            button_kritisch.Click += button_kritisch_Click;
            // 
            // comboBox_Ebene
            // 
            comboBox_Ebene.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_Ebene.FormattingEnabled = true;
            comboBox_Ebene.Items.AddRange(new object[] { "Ebene 1", "Ebene 2", "Ebene 3", "Ebene 4" });
            comboBox_Ebene.Location = new Point(157, 41);
            comboBox_Ebene.Name = "comboBox_Ebene";
            comboBox_Ebene.Size = new Size(172, 29);
            comboBox_Ebene.TabIndex = 4;
            // 
            // button_Status
            // 
            button_Status.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Status.Location = new Point(54, 267);
            button_Status.Name = "button_Status";
            button_Status.Size = new Size(226, 40);
            button_Status.TabIndex = 3;
            button_Status.Text = "Status ändern";
            button_Status.UseVisualStyleBackColor = true;
            button_Status.Click += button_Status_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label1);
            groupBox4.Location = new Point(12, 387);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(776, 51);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Info";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 0;
            label1.Text = "© Nathan Otterbach, GSCR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(356, 107);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 12;
            label2.Text = "Platz4";
            // 
            // Platz3
            // 
            Platz3.AutoSize = true;
            Platz3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Platz3.Location = new Point(245, 107);
            Platz3.Name = "Platz3";
            Platz3.Size = new Size(63, 25);
            Platz3.TabIndex = 11;
            Platz3.Text = "Platz3";
            // 
            // Platz2
            // 
            Platz2.AutoSize = true;
            Platz2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Platz2.Location = new Point(135, 107);
            Platz2.Name = "Platz2";
            Platz2.Size = new Size(63, 25);
            Platz2.TabIndex = 10;
            Platz2.Text = "Platz2";
            // 
            // Platz1
            // 
            Platz1.AutoSize = true;
            Platz1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Platz1.Location = new Point(27, 107);
            Platz1.Name = "Platz1";
            Platz1.Size = new Size(63, 25);
            Platz1.TabIndex = 9;
            Platz1.Text = "Platz1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(Platz3);
            Controls.Add(Platz2);
            Controls.Add(Platz1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "LagerPlatz";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_abgelaufen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_kritisch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_normal).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox2;
        private PictureBox pictureBox_kritisch;
        private PictureBox pictureBox_normal;
        private GroupBox groupBox3;
        private ComboBox comboBox_Ebene;
        private Button button_Status;
        private GroupBox groupBox4;
        private Label label_Belegt;
        private Label label_Frei;
        private Label label1;
        private Label label6;
        private PictureBox pictureBox_abgelaufen;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox comboBox_Regalnummer;
        private ComboBox comboBox_Status;
        private Button button_kritisch;
        private Label label2;
        private Label Platz3;
        private Label Platz2;
        private Label Platz1;
    }
}