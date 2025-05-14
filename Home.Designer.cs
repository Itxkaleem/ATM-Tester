namespace WinFormsApp1
{
    partial class Home
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
            panel1 = new Panel();
            label6 = new Label();
            label1 = new Label();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel2 = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
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
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(963, 0);
            label6.Name = "label6";
            label6.Size = new Size(27, 29);
            label6.TabIndex = 11;
            label6.Text = "X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(217, 9);
            label1.Name = "label1";
            label1.Size = new Size(505, 33);
            label1.TabIndex = 1;
            label1.Text = "SELECT YOUR TRANSACTION PLEASE";
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSlateGray;
            button3.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.AliceBlue;
            button3.Location = new Point(576, 104);
            button3.Name = "button3";
            button3.Size = new Size(170, 66);
            button3.TabIndex = 13;
            button3.Text = "WITHDRAW";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.AliceBlue;
            button1.Location = new Point(576, 222);
            button1.Name = "button1";
            button1.Size = new Size(170, 66);
            button1.TabIndex = 14;
            button1.Text = "MINI STATEMENT";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateGray;
            button2.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.AliceBlue;
            button2.Location = new Point(258, 222);
            button2.Name = "button2";
            button2.Size = new Size(171, 66);
            button2.TabIndex = 15;
            button2.Text = "FAST CASH";
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSlateGray;
            button4.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.AliceBlue;
            button4.Location = new Point(258, 104);
            button4.Name = "button4";
            button4.Size = new Size(171, 66);
            button4.TabIndex = 16;
            button4.Text = "DEPOSIT";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSlateGray;
            button5.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.AliceBlue;
            button5.Location = new Point(576, 335);
            button5.Name = "button5";
            button5.Size = new Size(170, 66);
            button5.TabIndex = 17;
            button5.Text = "BALANCE";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkSlateGray;
            button6.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.AliceBlue;
            button6.Location = new Point(258, 335);
            button6.Name = "button6";
            button6.Size = new Size(171, 66);
            button6.TabIndex = 18;
            button6.Text = "CHANGE PIN";
            button6.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 495);
            panel2.Name = "panel2";
            panel2.Size = new Size(995, 10);
            panel2.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(448, 447);
            label5.Name = "label5";
            label5.Size = new Size(94, 24);
            label5.TabIndex = 20;
            label5.Text = "Log Out";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 505);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label1;
        private Button button3;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel panel2;
        private Label label5;
    }
}