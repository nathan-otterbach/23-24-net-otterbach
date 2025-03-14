namespace Perspektivische_Felder
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
            draw = new Button();
            animate = new Button();
            delete = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // draw
            // 
            draw.Location = new Point(713, 359);
            draw.Name = "draw";
            draw.Size = new Size(75, 23);
            draw.TabIndex = 0;
            draw.Text = "Anzeigen";
            draw.UseVisualStyleBackColor = true;
            draw.Click += draw_Click;
            // 
            // animate
            // 
            animate.Location = new Point(713, 388);
            animate.Name = "animate";
            animate.Size = new Size(75, 23);
            animate.TabIndex = 1;
            animate.Text = "Animiere";
            animate.UseVisualStyleBackColor = true;
            animate.Click += animate_Click;
            // 
            // delete
            // 
            delete.Location = new Point(713, 417);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 2;
            delete.Text = "Lösche";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(delete);
            Controls.Add(animate);
            Controls.Add(draw);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button draw;
        private Button animate;
        private Button delete;
        private System.Windows.Forms.Timer timer1;
    }
}
