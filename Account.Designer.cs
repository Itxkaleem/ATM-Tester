
namespace WinFormsApp1
{
    partial class Account
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
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            AccountNotb = new TextBox();
            fnametb = new TextBox();
            phonetb = new TextBox();
            addresstb = new TextBox();
            nametb = new TextBox();
            blancetb = new TextBox();
            pincodetb = new TextBox();
            educationtb = new ComboBox();
            dobtable = new DateTimePicker();
            label13 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            occupation = new TextBox();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(66, 276);
            label3.Name = "label3";
            label3.Size = new Size(110, 28);
            label3.TabIndex = 5;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(66, 220);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 6;
            label2.Text = "Fname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(66, 169);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 7;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(66, 114);
            label5.Name = "label5";
            label5.Size = new Size(166, 28);
            label5.TabIndex = 8;
            label5.Text = "Account No.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(501, 276);
            label7.Name = "label7";
            label7.Size = new Size(152, 28);
            label7.TabIndex = 9;
            label7.Text = "Occupation";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(501, 220);
            label8.Name = "label8";
            label8.Size = new Size(152, 28);
            label8.TabIndex = 10;
            label8.Text = "Education ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkSlateGray;
            label9.Location = new Point(501, 169);
            label9.Name = "label9";
            label9.Size = new Size(110, 28);
            label9.TabIndex = 11;
            label9.Text = "Balance";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkSlateGray;
            label10.Location = new Point(501, 114);
            label10.Name = "label10";
            label10.Size = new Size(124, 28);
            label10.TabIndex = 12;
            label10.Text = "Pin Code";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DarkSlateGray;
            label11.Location = new Point(513, 330);
            label11.Name = "label11";
            label11.Size = new Size(82, 28);
            label11.TabIndex = 13;
            label11.Text = "D.O.B";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("SimSun", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DarkSlateGray;
            label12.Location = new Point(66, 330);
            label12.Name = "label12";
            label12.Size = new Size(82, 28);
            label12.TabIndex = 14;
            label12.Text = "Phone";
            // 
            // AccountNotb
            // 
            AccountNotb.Location = new Point(238, 114);
            AccountNotb.Name = "AccountNotb";
            AccountNotb.Size = new Size(207, 31);
            AccountNotb.TabIndex = 15;
            // 
            // fnametb
            // 
            fnametb.Location = new Point(238, 221);
            fnametb.Name = "fnametb";
            fnametb.Size = new Size(207, 31);
            fnametb.TabIndex = 16;
            // 
            // phonetb
            // 
            phonetb.Location = new Point(238, 327);
            phonetb.Name = "phonetb";
            phonetb.Size = new Size(207, 31);
            phonetb.TabIndex = 17;
            // 
            // addresstb
            // 
            addresstb.Location = new Point(238, 277);
            addresstb.Name = "addresstb";
            addresstb.Size = new Size(207, 31);
            addresstb.TabIndex = 18;
            // 
            // nametb
            // 
            nametb.Location = new Point(238, 166);
            nametb.Name = "nametb";
            nametb.Size = new Size(207, 31);
            nametb.TabIndex = 19;
            // 
            // blancetb
            // 
            blancetb.Location = new Point(659, 162);
            blancetb.Name = "blancetb";
            blancetb.Size = new Size(207, 31);
            blancetb.TabIndex = 24;
            // 
            // pincodetb
            // 
            pincodetb.Location = new Point(659, 110);
            pincodetb.Name = "pincodetb";
            pincodetb.Size = new Size(207, 31);
            pincodetb.TabIndex = 20;
            // 
            // educationtb
            // 
            educationtb.FormattingEnabled = true;
            educationtb.Items.AddRange(new object[] { "Non Graduate", "Graduate", "Under Graduate" });
            educationtb.Location = new Point(659, 221);
            educationtb.Name = "educationtb";
            educationtb.Size = new Size(207, 33);
            educationtb.TabIndex = 25;
            // 
            // dobtable
            // 
            dobtable.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dobtable.Location = new Point(659, 330);
            dobtable.Name = "dobtable";
            dobtable.Size = new Size(207, 29);
            dobtable.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("SimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.DarkSlateGray;
            label13.Location = new Point(431, 451);
            label13.Name = "label13";
            label13.Size = new Size(94, 24);
            label13.TabIndex = 28;
            label13.Text = "Log Out";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Bahnschrift", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.AliceBlue;
            button1.Location = new Point(417, 404);
            button1.Name = "button1";
            button1.Size = new Size(128, 44);
            button1.TabIndex = 29;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = Color.DarkSlateGray;
            panel2.Location = new Point(0, 495);
            panel2.Name = "panel2";
            panel2.Size = new Size(995, 10);
            panel2.TabIndex = 30;
            // 
            // occupation
            // 
            occupation.Location = new Point(659, 276);
            occupation.Name = "occupation";
            occupation.Size = new Size(207, 31);
            occupation.TabIndex = 31;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 505);
            Controls.Add(occupation);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(label13);
            Controls.Add(dobtable);
            Controls.Add(educationtb);
            Controls.Add(blancetb);
            Controls.Add(pincodetb);
            Controls.Add(nametb);
            Controls.Add(addresstb);
            Controls.Add(phonetb);
            Controls.Add(fnametb);
            Controls.Add(AccountNotb);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account";
            Text = "Account";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox AccountNotb;
        private TextBox fnametb;
        private TextBox phonetb;
        private TextBox addresstb;
        private TextBox nametb;
        private TextBox blancetb;
        private TextBox pincodetb;
        private ComboBox educationtb;
        private DateTimePicker dobtable;
        private Label label13;
        private Button button1;
        private Panel panel2;
        private TextBox occupation;
    }
}