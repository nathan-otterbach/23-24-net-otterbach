namespace Gauß_algorithmus
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
            label5 = new Label();
            textBox4 = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 300);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Übung: Gauß Algorithmus";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 265);
            label5.Name = "label5";
            label5.Size = new Size(161, 25);
            label5.TabIndex = 14;
            label5.Text = "Time passed in µs";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(244, 261);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 33);
            textBox4.TabIndex = 13;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(623, 256);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(99, 29);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "iterative";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(232, 216);
            button1.Name = "button1";
            button1.Size = new Size(124, 35);
            button1.TabIndex = 11;
            button1.Text = "ausgeben";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(612, 166);
            button4.Name = "button4";
            button4.Size = new Size(124, 35);
            button4.TabIndex = 10;
            button4.Text = "1 - 1000000";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(612, 125);
            button3.Name = "button3";
            button3.Size = new Size(124, 35);
            button3.TabIndex = 9;
            button3.Text = "50 - 500000";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(612, 84);
            button2.Name = "button2";
            button2.Size = new Size(124, 35);
            button2.TabIndex = 8;
            button2.Text = "1 - 100";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 29);
            label4.Name = "label4";
            label4.Size = new Size(350, 20);
            label4.TabIndex = 7;
            label4.Text = "Gewerbliche Schule Crailsheim © Nathan Otterbach";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(210, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 33);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(210, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 33);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(51, 172);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 5;
            label3.Text = "Ergebnis";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(210, 166);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 33);
            textBox3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(51, 133);
            label2.Name = "label2";
            label2.Size = new Size(36, 21);
            label2.TabIndex = 4;
            label2.Text = "End";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 92);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 3;
            label1.Text = "Start";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private CheckBox checkBox1;
        private Label label5;
        private TextBox textBox4;
    }
}