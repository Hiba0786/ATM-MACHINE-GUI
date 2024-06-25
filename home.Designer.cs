namespace ATM_Management_Machine
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.dBox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.transferBtn = new System.Windows.Forms.Button();
            this.cityLbl = new System.Windows.Forms.Label();
            this.AccNumlbl = new System.Windows.Forms.Label();
            this.desLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.tempLbl = new System.Windows.Forms.Label();
            this.cpBtn = new System.Windows.Forms.Button();
            this.msBtn = new System.Windows.Forms.Button();
            this.fcBtn = new System.Windows.Forms.Button();
            this.wBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Shutdown = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.helpBtn = new System.Windows.Forms.RadioButton();
            this.balanceLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dBox
            // 
            this.dBox.BackColor = System.Drawing.Color.Black;
            this.dBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dBox.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.dBox.ForeColor = System.Drawing.Color.White;
            this.dBox.Location = new System.Drawing.Point(29, 183);
            this.dBox.Name = "dBox";
            this.dBox.Size = new System.Drawing.Size(176, 48);
            this.dBox.TabIndex = 8;
            this.dBox.Text = "Deposit";
            this.dBox.UseVisualStyleBackColor = false;
            this.dBox.Click += new System.EventHandler(this.dBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATM MANAGEMENT MACHINE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(375, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 62);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.balanceLbl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.transferBtn);
            this.panel1.Controls.Add(this.cityLbl);
            this.panel1.Controls.Add(this.AccNumlbl);
            this.panel1.Controls.Add(this.desLbl);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.tempLbl);
            this.panel1.Controls.Add(this.cpBtn);
            this.panel1.Controls.Add(this.msBtn);
            this.panel1.Controls.Add(this.fcBtn);
            this.panel1.Controls.Add(this.wBtn);
            this.panel1.Controls.Add(this.dBox);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(375, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 470);
            this.panel1.TabIndex = 11;
            // 
            // transferBtn
            // 
            this.transferBtn.BackColor = System.Drawing.Color.Black;
            this.transferBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.transferBtn.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.transferBtn.ForeColor = System.Drawing.Color.White;
            this.transferBtn.Location = new System.Drawing.Point(435, 260);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(180, 48);
            this.transferBtn.TabIndex = 55;
            this.transferBtn.Text = "Transfer";
            this.transferBtn.UseVisualStyleBackColor = false;
            this.transferBtn.Click += new System.EventHandler(this.transferBtn_Click);
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.cityLbl.Location = new System.Drawing.Point(495, 137);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(68, 20);
            this.cityLbl.TabIndex = 54;
            this.cityLbl.Text = "weather";
            // 
            // AccNumlbl
            // 
            this.AccNumlbl.AutoSize = true;
            this.AccNumlbl.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNumlbl.ForeColor = System.Drawing.Color.White;
            this.AccNumlbl.Location = new System.Drawing.Point(31, 431);
            this.AccNumlbl.Name = "AccNumlbl";
            this.AccNumlbl.Size = new System.Drawing.Size(174, 22);
            this.AccNumlbl.TabIndex = 31;
            this.AccNumlbl.Text = "Account Number:";
            // 
            // desLbl
            // 
            this.desLbl.AutoSize = true;
            this.desLbl.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.desLbl.Location = new System.Drawing.Point(241, 137);
            this.desLbl.Name = "desLbl";
            this.desLbl.Size = new System.Drawing.Size(46, 20);
            this.desLbl.TabIndex = 53;
            this.desLbl.Text = "Desc";
            // 
            // closeBtn
            // 
            this.closeBtn.AutoEllipsis = true;
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(18, 68);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(59, 50);
            this.closeBtn.TabIndex = 30;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // tempLbl
            // 
            this.tempLbl.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLbl.Location = new System.Drawing.Point(35, 137);
            this.tempLbl.Name = "tempLbl";
            this.tempLbl.Size = new System.Drawing.Size(184, 30);
            this.tempLbl.TabIndex = 52;
            this.tempLbl.Text = "Temp";
            // 
            // cpBtn
            // 
            this.cpBtn.BackColor = System.Drawing.Color.Black;
            this.cpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cpBtn.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.cpBtn.ForeColor = System.Drawing.Color.White;
            this.cpBtn.Location = new System.Drawing.Point(435, 339);
            this.cpBtn.Name = "cpBtn";
            this.cpBtn.Size = new System.Drawing.Size(180, 48);
            this.cpBtn.TabIndex = 15;
            this.cpBtn.Text = "Change Pin";
            this.cpBtn.UseVisualStyleBackColor = false;
            this.cpBtn.Click += new System.EventHandler(this.cpBtn_Click);
            // 
            // msBtn
            // 
            this.msBtn.BackColor = System.Drawing.Color.Black;
            this.msBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.msBtn.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.msBtn.ForeColor = System.Drawing.Color.White;
            this.msBtn.Location = new System.Drawing.Point(435, 183);
            this.msBtn.Name = "msBtn";
            this.msBtn.Size = new System.Drawing.Size(180, 48);
            this.msBtn.TabIndex = 13;
            this.msBtn.Text = "Mini Statement";
            this.msBtn.UseVisualStyleBackColor = false;
            this.msBtn.Click += new System.EventHandler(this.msBtn_Click);
            // 
            // fcBtn
            // 
            this.fcBtn.BackColor = System.Drawing.Color.Black;
            this.fcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fcBtn.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.fcBtn.ForeColor = System.Drawing.Color.White;
            this.fcBtn.Location = new System.Drawing.Point(29, 343);
            this.fcBtn.Name = "fcBtn";
            this.fcBtn.Size = new System.Drawing.Size(176, 48);
            this.fcBtn.TabIndex = 12;
            this.fcBtn.Text = "Fast Cash";
            this.fcBtn.UseVisualStyleBackColor = false;
            this.fcBtn.Click += new System.EventHandler(this.fcBtn_Click);
            // 
            // wBtn
            // 
            this.wBtn.BackColor = System.Drawing.Color.Black;
            this.wBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wBtn.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.wBtn.ForeColor = System.Drawing.Color.White;
            this.wBtn.Location = new System.Drawing.Point(29, 260);
            this.wBtn.Name = "wBtn";
            this.wBtn.Size = new System.Drawing.Size(176, 48);
            this.wBtn.TabIndex = 11;
            this.wBtn.Text = "Withdraw";
            this.wBtn.UseVisualStyleBackColor = false;
            this.wBtn.Click += new System.EventHandler(this.wBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Black;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutBtn.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(240, 68);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(166, 48);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.Transparent;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn4.Location = new System.Drawing.Point(321, 517);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(39, 64);
            this.Btn4.TabIndex = 45;
            this.Btn4.UseVisualStyleBackColor = false;
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.Transparent;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn3.Location = new System.Drawing.Point(321, 450);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(39, 52);
            this.Btn3.TabIndex = 44;
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.Transparent;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn2.Location = new System.Drawing.Point(321, 365);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(39, 64);
            this.Btn2.TabIndex = 43;
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.Transparent;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn1.Location = new System.Drawing.Point(321, 288);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(39, 64);
            this.Btn1.TabIndex = 42;
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Shutdown
            // 
            this.Shutdown.BackColor = System.Drawing.Color.Transparent;
            this.Shutdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Shutdown.ForeColor = System.Drawing.Color.Transparent;
            this.Shutdown.Location = new System.Drawing.Point(1153, 668);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(26, 25);
            this.Shutdown.TabIndex = 46;
            this.Shutdown.UseVisualStyleBackColor = false;
            this.Shutdown.Click += new System.EventHandler(this.Shutdown_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.Transparent;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn5.Location = new System.Drawing.Point(1015, 288);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(39, 64);
            this.Btn5.TabIndex = 38;
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.Transparent;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn6.Location = new System.Drawing.Point(1015, 365);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(39, 64);
            this.Btn6.TabIndex = 39;
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.Transparent;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn7.Location = new System.Drawing.Point(1015, 450);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(39, 52);
            this.Btn7.TabIndex = 40;
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.helpBtn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(499, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 50);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            // 
            // helpBtn
            // 
            this.helpBtn.AutoEllipsis = true;
            this.helpBtn.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.helpBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.helpBtn.Location = new System.Drawing.Point(6, 13);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(96, 33);
            this.helpBtn.TabIndex = 6;
            this.helpBtn.TabStop = true;
            this.helpBtn.Text = "Help?";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.CheckedChanged += new System.EventHandler(this.helpBtn_CheckedChanged);
            // 
            // balanceLbl
            // 
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLbl.ForeColor = System.Drawing.Color.White;
            this.balanceLbl.Location = new System.Drawing.Point(514, 431);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(83, 22);
            this.balanceLbl.TabIndex = 58;
            this.balanceLbl.Text = "Balance";
            this.balanceLbl.Click += new System.EventHandler(this.balanceLbl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(331, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 22);
            this.label5.TabIndex = 57;
            this.label5.Text = "Current Balance:";
            // 
            // home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1321, 765);
            this.Controls.Add(this.Shutdown);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button dBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cpBtn;
        private System.Windows.Forms.Button msBtn;
        private System.Windows.Forms.Button fcBtn;
        private System.Windows.Forms.Button wBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label AccNumlbl;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Shutdown;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label desLbl;
        private System.Windows.Forms.Label tempLbl;
        private System.Windows.Forms.Button transferBtn;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton helpBtn;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.Label label5;
    }
}