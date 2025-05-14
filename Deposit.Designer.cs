namespace WinFormsApp1
{
    partial class Deposit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            textBox1 = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label1 = new Label();
            button1 = new Button();
            label13 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = Color.DarkSlateGray;
            panel2.Location = new Point(0, 495);
            panel2.Name = "panel2";
            panel2.Size = new Size(995, 10);
            panel2.TabIndex = 34;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(439, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 31);
            textBox1.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(273, 168);
            label5.Name = "label5";
            label5.Size = new Size(124, 28);
            label5.TabIndex = 32;
            label5.Text = "Amount :";
            label5.Click += label5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(995, 50);
            panel1.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(967, 0);
            label6.Name = "label6";
            label6.Size = new Size(27, 29);
            label6.TabIndex = 11;
            label6.Text = "X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(251, 9);
            label1.Name = "label1";
            label1.Size = new Size(424, 38);
            label1.TabIndex = 1;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Bahnschrift", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.AliceBlue;
            button1.Location = new Point(543, 279);
            button1.Name = "button1";
            button1.Size = new Size(188, 44);
            button1.TabIndex = 36;
            button1.Text = "DEPOSIT";
            button1.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DarkSlateGray;
            label13.Location = new Point(581, 326);
            label13.Name = "label13";
            label13.Size = new Size(94, 24);
            label13.TabIndex = 35;
            label13.Text = "Log Out";
            label13.Click += label13_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(273, 96);
            label2.Name = "label2";
            label2.Size = new Size(467, 40);
            label2.TabIndex = 12;
            label2.Text = "Enter amount to Deposit";
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 505);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label13);
            Controls.Add(panel2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Deposit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deposit";
            Load += Deposit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private TextBox textBox1;
        private Label label5;
        private Panel panel1;
        private Label label6;
        private Label label1;
        private Button button1;
        private Label label13;
        private Label label2;
    }
}