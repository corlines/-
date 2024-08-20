namespace demon1
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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            correct = new Label();
            wrong = new Label();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(223, 319);
            listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 337);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // correct
            // 
            correct.AutoSize = true;
            correct.Location = new Point(14, 371);
            correct.Name = "correct";
            correct.Size = new Size(77, 15);
            correct.TabIndex = 4;
            correct.Text = "맞은 개수 : 0";
            // 
            // wrong
            // 
            wrong.AutoSize = true;
            wrong.Location = new Point(157, 371);
            wrong.Name = "wrong";
            wrong.Size = new Size(77, 15);
            wrong.TabIndex = 5;
            wrong.Text = "틀린 개수 : 0";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(14, 410);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(221, 23);
            progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 450);
            Controls.Add(progressBar1);
            Controls.Add(wrong);
            Controls.Add(correct);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private Label correct;
        private Label wrong;
        private ProgressBar progressBar1;
    }
}
