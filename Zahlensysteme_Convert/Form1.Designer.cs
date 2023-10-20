namespace Zahlensysteme_Convert
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
            button_dualTohex = new Button();
            button_hexTodual = new Button();
            button_hexTodez = new Button();
            button_dextohex = new Button();
            button_dualTodez = new Button();
            button_dezTodual = new Button();
            textBox_in = new TextBox();
            label3 = new Label();
            textBox_out = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_dualTohex);
            groupBox1.Controls.Add(button_hexTodual);
            groupBox1.Controls.Add(button_hexTodez);
            groupBox1.Controls.Add(button_dextohex);
            groupBox1.Controls.Add(button_dualTodez);
            groupBox1.Controls.Add(button_dezTodual);
            groupBox1.Controls.Add(textBox_in);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox_out);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 426);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // button_dualTohex
            // 
            button_dualTohex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_dualTohex.Location = new Point(612, 290);
            button_dualTohex.Name = "button_dualTohex";
            button_dualTohex.Size = new Size(124, 35);
            button_dualTohex.TabIndex = 14;
            button_dualTohex.Text = "DUAL --> HEX";
            button_dualTohex.UseVisualStyleBackColor = true;
            button_dualTohex.Click += button_dualTohex_Click;
            // 
            // button_hexTodual
            // 
            button_hexTodual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_hexTodual.Location = new Point(612, 249);
            button_hexTodual.Name = "button_hexTodual";
            button_hexTodual.Size = new Size(124, 35);
            button_hexTodual.TabIndex = 13;
            button_hexTodual.Text = "HEX --> DUAL";
            button_hexTodual.UseVisualStyleBackColor = true;
            button_hexTodual.Click += button_hexTodual_Click;
            // 
            // button_hexTodez
            // 
            button_hexTodez.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_hexTodez.Location = new Point(612, 208);
            button_hexTodez.Name = "button_hexTodez";
            button_hexTodez.Size = new Size(124, 35);
            button_hexTodez.TabIndex = 12;
            button_hexTodez.Text = "HEX --> DEZ";
            button_hexTodez.UseVisualStyleBackColor = true;
            button_hexTodez.Click += button_hexTodez_Click;
            // 
            // button_dextohex
            // 
            button_dextohex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_dextohex.Location = new Point(612, 166);
            button_dextohex.Name = "button_dextohex";
            button_dextohex.Size = new Size(124, 35);
            button_dextohex.TabIndex = 10;
            button_dextohex.Text = "DEZ --> HEX";
            button_dextohex.UseVisualStyleBackColor = true;
            button_dextohex.Click += button_dextohex_Click;
            // 
            // button_dualTodez
            // 
            button_dualTodez.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_dualTodez.Location = new Point(612, 125);
            button_dualTodez.Name = "button_dualTodez";
            button_dualTodez.Size = new Size(124, 35);
            button_dualTodez.TabIndex = 9;
            button_dualTodez.Text = "DUAL --> DEZ";
            button_dualTodez.UseVisualStyleBackColor = true;
            button_dualTodez.Click += button_dualTodez_Click;
            // 
            // button_dezTodual
            // 
            button_dezTodual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_dezTodual.Location = new Point(612, 84);
            button_dezTodual.Name = "button_dezTodual";
            button_dezTodual.Size = new Size(124, 35);
            button_dezTodual.TabIndex = 8;
            button_dezTodual.Text = "DEZ --> DUAL";
            button_dezTodual.UseVisualStyleBackColor = true;
            button_dezTodual.Click += button_dezTodual_Click;
            // 
            // textBox_in
            // 
            textBox_in.Location = new Point(161, 86);
            textBox_in.Name = "textBox_in";
            textBox_in.Size = new Size(301, 33);
            textBox_in.TabIndex = 0;
            textBox_in.TextChanged += textBox_in_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(51, 172);
            label3.Name = "label3";
            label3.Size = new Size(41, 21);
            label3.TabIndex = 5;
            label3.Text = "OUT";
            // 
            // textBox_out
            // 
            textBox_out.Location = new Point(161, 166);
            textBox_out.Name = "textBox_out";
            textBox_out.Size = new Size(301, 33);
            textBox_out.TabIndex = 2;
            textBox_out.TextChanged += textBox_out_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 92);
            label1.Name = "label1";
            label1.Size = new Size(26, 21);
            label1.TabIndex = 3;
            label1.Text = "IN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button_dextohex;
        private Button button_dualTodez;
        private Button button_dezTodual;
        private TextBox textBox_in;
        private Label label3;
        private TextBox textBox_out;
        private Label label1;
        private Button button_dualTohex;
        private Button button_hexTodual;
        private Button button_hexTodez;
    }
}