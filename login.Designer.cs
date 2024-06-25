namespace ATM_Management_Machine
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cityLbl = new System.Windows.Forms.Label();
            this.desLbl = new System.Windows.Forms.Label();
            this.tempLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.forgotBtn = new System.Windows.Forms.LinkLabel();
            this.signupBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.pinBox = new System.Windows.Forms.TextBox();
            this.accBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Shutdown = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.cityLbl);
            this.panel1.Controls.Add(this.desLbl);
            this.panel1.Controls.Add(this.tempLbl);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.forgotBtn);
            this.panel1.Controls.Add(this.signupBtn);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.pinBox);
            this.panel1.Controls.Add(this.accBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(376, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 468);
            this.panel1.TabIndex = 0;
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.cityLbl.Location = new System.Drawing.Point(508, 138);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(68, 20);
            this.cityLbl.TabIndex = 33;
            this.cityLbl.Text = "weather";
            // 
            // desLbl
            // 
            this.desLbl.AutoSize = true;
            this.desLbl.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.desLbl.Location = new System.Drawing.Point(254, 138);
            this.desLbl.Name = "desLbl";
            this.desLbl.Size = new System.Drawing.Size(46, 20);
            this.desLbl.TabIndex = 32;
            this.desLbl.Text = "Desc";
            // 
            // tempLbl
            // 
            this.tempLbl.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLbl.Location = new System.Drawing.Point(48, 138);
            this.tempLbl.Name = "tempLbl";
            this.tempLbl.Size = new System.Drawing.Size(184, 30);
            this.tempLbl.TabIndex = 31;
            this.tempLbl.Text = "Temp";
            // 
            // closeBtn
            // 
            this.closeBtn.AutoEllipsis = true;
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(14, 68);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(59, 50);
            this.closeBtn.TabIndex = 30;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // forgotBtn
            // 
            this.forgotBtn.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.forgotBtn.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotBtn.LinkColor = System.Drawing.Color.MidnightBlue;
            this.forgotBtn.Location = new System.Drawing.Point(29, 375);
            this.forgotBtn.Name = "forgotBtn";
            this.forgotBtn.Size = new System.Drawing.Size(194, 31);
            this.forgotBtn.TabIndex = 9;
            this.forgotBtn.TabStop = true;
            this.forgotBtn.Text = "Forgot Pin/ Acc Num?";
            this.forgotBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotBtn_LinkClicked);
            // 
            // signupBtn
            // 
            this.signupBtn.BackColor = System.Drawing.Color.Black;
            this.signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signupBtn.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.signupBtn.ForeColor = System.Drawing.Color.White;
            this.signupBtn.Location = new System.Drawing.Point(289, 404);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(166, 48);
            this.signupBtn.TabIndex = 8;
            this.signupBtn.Text = "Sign up";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.Black;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBtn.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(289, 336);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(166, 48);
            this.loginBtn.TabIndex = 7;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // pinBox
            // 
            this.pinBox.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Bold);
            this.pinBox.Location = new System.Drawing.Point(258, 287);
            this.pinBox.Name = "pinBox";
            this.pinBox.ShortcutsEnabled = false;
            this.pinBox.Size = new System.Drawing.Size(239, 39);
            this.pinBox.TabIndex = 5;
            this.pinBox.UseSystemPasswordChar = true;
            // 
            // accBox
            // 
            this.accBox.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Bold);
            this.accBox.Location = new System.Drawing.Point(258, 189);
            this.accBox.Multiline = true;
            this.accBox.Name = "accBox";
            this.accBox.Size = new System.Drawing.Size(239, 39);
            this.accBox.TabIndex = 4;
            this.accBox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "PIN CODE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "ACC NUM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(262, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "LOGIN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(376, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 62);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATM MANAGEMENT MACHINE";
            // 
            // Shutdown
            // 
            this.Shutdown.BackColor = System.Drawing.Color.Transparent;
            this.Shutdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Shutdown.Location = new System.Drawing.Point(1152, 665);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(29, 31);
            this.Shutdown.TabIndex = 47;
            this.Shutdown.UseVisualStyleBackColor = false;
            this.Shutdown.Click += new System.EventHandler(this.Shutdown_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(1019, 528);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 53);
            this.button4.TabIndex = 51;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(1019, 455);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 42);
            this.button3.TabIndex = 50;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(1019, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 60);
            this.button2.TabIndex = 49;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1019, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 62);
            this.button1.TabIndex = 48;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(328, 528);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 53);
            this.button5.TabIndex = 55;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(328, 449);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 51);
            this.button6.TabIndex = 54;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(328, 370);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 60);
            this.button7.TabIndex = 53;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(328, 293);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(28, 62);
            this.button8.TabIndex = 52;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // helpBtn
            // 
            this.helpBtn.AutoEllipsis = true;
            this.helpBtn.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.helpBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.helpBtn.Location = new System.Drawing.Point(6, 11);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(96, 33);
            this.helpBtn.TabIndex = 6;
            this.helpBtn.TabStop = true;
            this.helpBtn.Text = "Help?";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.CheckedChanged += new System.EventHandler(this.helpBtn_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.helpBtn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(512, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 50);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1324, 761);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Shutdown);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox pinBox;
        private System.Windows.Forms.TextBox accBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel forgotBtn;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button Shutdown;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label desLbl;
        private System.Windows.Forms.Label tempLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton helpBtn;
    }
}