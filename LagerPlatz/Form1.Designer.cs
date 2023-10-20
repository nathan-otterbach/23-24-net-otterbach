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
            groupBox1 = new GroupBox();
            Platz3 = new Label();
            Platz2 = new Label();
            Platz1 = new Label();
            pictureBox_Platz3 = new PictureBox();
            pictureBox_Platz2 = new PictureBox();
            pictureBox_Platz1 = new PictureBox();
            groupBox2 = new GroupBox();
            label_Belegt = new Label();
            label_Frei = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            groupBox3 = new GroupBox();
            comboBox1 = new ComboBox();
            button_Status = new Button();
            groupBox4 = new GroupBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Platz3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Platz2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Platz1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Platz3);
            groupBox1.Controls.Add(Platz2);
            groupBox1.Controls.Add(Platz1);
            groupBox1.Controls.Add(pictureBox_Platz3);
            groupBox1.Controls.Add(pictureBox_Platz2);
            groupBox1.Controls.Add(pictureBox_Platz1);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(238, 354);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Plätze";
            // 
            // Platz3
            // 
            Platz3.AutoSize = true;
            Platz3.Location = new Point(6, 283);
            Platz3.Name = "Platz3";
            Platz3.Size = new Size(63, 25);
            Platz3.TabIndex = 6;
            Platz3.Text = "Platz3";
            // 
            // Platz2
            // 
            Platz2.AutoSize = true;
            Platz2.Location = new Point(6, 169);
            Platz2.Name = "Platz2";
            Platz2.Size = new Size(63, 25);
            Platz2.TabIndex = 5;
            Platz2.Text = "Platz2";
            // 
            // Platz1
            // 
            Platz1.AutoSize = true;
            Platz1.Location = new Point(6, 54);
            Platz1.Name = "Platz1";
            Platz1.Size = new Size(63, 25);
            Platz1.TabIndex = 4;
            Platz1.Text = "Platz1";
            // 
            // pictureBox_Platz3
            // 
            pictureBox_Platz3.BackColor = Color.Green;
            pictureBox_Platz3.Location = new Point(132, 269);
            pictureBox_Platz3.Name = "pictureBox_Platz3";
            pictureBox_Platz3.Size = new Size(100, 50);
            pictureBox_Platz3.TabIndex = 2;
            pictureBox_Platz3.TabStop = false;
            // 
            // pictureBox_Platz2
            // 
            pictureBox_Platz2.BackColor = Color.Green;
            pictureBox_Platz2.Location = new Point(132, 156);
            pictureBox_Platz2.Name = "pictureBox_Platz2";
            pictureBox_Platz2.Size = new Size(100, 50);
            pictureBox_Platz2.TabIndex = 1;
            pictureBox_Platz2.TabStop = false;
            // 
            // pictureBox_Platz1
            // 
            pictureBox_Platz1.BackColor = Color.Green;
            pictureBox_Platz1.Location = new Point(132, 43);
            pictureBox_Platz1.Name = "pictureBox_Platz1";
            pictureBox_Platz1.Size = new Size(100, 50);
            pictureBox_Platz1.TabIndex = 0;
            pictureBox_Platz1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label_Belegt);
            groupBox2.Controls.Add(label_Frei);
            groupBox2.Controls.Add(pictureBox5);
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(281, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(238, 142);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Status Platz";
            // 
            // label_Belegt
            // 
            label_Belegt.AutoSize = true;
            label_Belegt.Location = new Point(140, 98);
            label_Belegt.Name = "label_Belegt";
            label_Belegt.Size = new Size(65, 25);
            label_Belegt.TabIndex = 4;
            label_Belegt.Text = "Belegt";
            // 
            // label_Frei
            // 
            label_Frei.AutoSize = true;
            label_Frei.Location = new Point(140, 42);
            label_Frei.Name = "label_Frei";
            label_Frei.Size = new Size(43, 25);
            label_Frei.TabIndex = 3;
            label_Frei.Text = "Frei";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Yellow;
            pictureBox5.Location = new Point(15, 88);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 35);
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Green;
            pictureBox4.Location = new Point(15, 32);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 35);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(button_Status);
            groupBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(281, 212);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(238, 142);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Steuerung";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Platz1", "Platz2", "Platz3" });
            comboBox1.Location = new Point(6, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 29);
            comboBox1.TabIndex = 4;
            // 
            // button_Status
            // 
            button_Status.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Status.Location = new Point(6, 87);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "LagerPlatz";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Platz3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Platz2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Platz1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox_Platz3;
        private PictureBox pictureBox_Platz2;
        private PictureBox pictureBox_Platz1;
        private GroupBox groupBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private GroupBox groupBox3;
        private ComboBox comboBox1;
        private Button button_Status;
        private GroupBox groupBox4;
        private Label Platz3;
        private Label Platz2;
        private Label Platz1;
        private Label label_Belegt;
        private Label label_Frei;
        private Label label1;
    }
}