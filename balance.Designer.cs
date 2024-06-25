namespace ATM_Management_Machine
{
    partial class balance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(balance));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cityLbl = new System.Windows.Forms.Label();
            this.balanceLbl = new System.Windows.Forms.Label();
            this.desLbl = new System.Windows.Forms.Label();
            this.accLbl = new System.Windows.Forms.Label();
            this.tempLbl = new System.Windows.Forms.Label();
            this.AccNumberlbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.helpBtn = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Shutdown = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(376, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 77);
            this.panel2.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATM MANAGEMENT MACHINE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.cityLbl);
            this.panel1.Controls.Add(this.balanceLbl);
            this.panel1.Controls.Add(this.desLbl);
            this.panel1.Controls.Add(this.accLbl);
            this.panel1.Controls.Add(this.tempLbl);
            this.panel1.Controls.Add(this.AccNumberlbl);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(376, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 483);
            this.panel1.TabIndex = 31;
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.cityLbl.Location = new System.Drawing.Point(497, 176);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(68, 20);
            this.cityLbl.TabIndex = 63;
            this.cityLbl.Text = "weather";
            // 
            // balanceLbl
            // 
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.balanceLbl.ForeColor = System.Drawing.Color.White;
            this.balanceLbl.Location = new System.Drawing.Point(357, 320);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(134, 38);
            this.balanceLbl.TabIndex = 34;
            this.balanceLbl.Text = "Balance";
            this.balanceLbl.Click += new System.EventHandler(this.balanceLbl_Click);
            // 
            // desLbl
            // 
            this.desLbl.AutoSize = true;
            this.desLbl.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.desLbl.Location = new System.Drawing.Point(243, 176);
            this.desLbl.Name = "desLbl";
            this.desLbl.Size = new System.Drawing.Size(46, 20);
            this.desLbl.TabIndex = 62;
            this.desLbl.Text = "Desc";
            // 
            // accLbl
            // 
            this.accLbl.AutoSize = true;
            this.accLbl.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.accLbl.ForeColor = System.Drawing.Color.White;
            this.accLbl.Location = new System.Drawing.Point(48, 248);
            this.accLbl.Name = "accLbl";
            this.accLbl.Size = new System.Drawing.Size(277, 38);
            this.accLbl.TabIndex = 33;
            this.accLbl.Text = "Account Number:";
            // 
            // tempLbl
            // 
            this.tempLbl.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLbl.Location = new System.Drawing.Point(37, 176);
            this.tempLbl.Name = "tempLbl";
            this.tempLbl.Size = new System.Drawing.Size(184, 30);
            this.tempLbl.TabIndex = 61;
            this.tempLbl.Text = "Temp";
            // 
            // AccNumberlbl
            // 
            this.AccNumberlbl.AutoSize = true;
            this.AccNumberlbl.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.AccNumberlbl.ForeColor = System.Drawing.Color.White;
            this.AccNumberlbl.Location = new System.Drawing.Point(357, 248);
            this.AccNumberlbl.Name = "AccNumberlbl";
            this.AccNumberlbl.Size = new System.Drawing.Size(277, 38);
            this.AccNumberlbl.TabIndex = 32;
            this.AccNumberlbl.Text = "Account Number:";
            // 
            // closeBtn
            // 
            this.closeBtn.AutoEllipsis = true;
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(18, 86);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(59, 50);
            this.closeBtn.TabIndex = 31;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.helpBtn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(511, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 50);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // helpBtn
            // 
            this.helpBtn.AutoEllipsis = true;
            this.helpBtn.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.helpBtn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.helpBtn.Location = new System.Drawing.Point(11, 2);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(96, 48);
            this.helpBtn.TabIndex = 6;
            this.helpBtn.TabStop = true;
            this.helpBtn.Text = "Help?";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.CheckedChanged += new System.EventHandler(this.helpBtn_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(47, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 38);
            this.label5.TabIndex = 19;
            this.label5.Text = "Current Balance:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(247, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Balance";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(1019, 525);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 53);
            this.button4.TabIndex = 55;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(1019, 452);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 42);
            this.button3.TabIndex = 54;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(1019, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 60);
            this.button2.TabIndex = 53;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1019, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 62);
            this.button1.TabIndex = 52;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(328, 525);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 53);
            this.button5.TabIndex = 59;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(328, 452);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 52);
            this.button6.TabIndex = 58;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(328, 367);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 60);
            this.button7.TabIndex = 57;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(328, 290);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(28, 62);
            this.button8.TabIndex = 56;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // Shutdown
            // 
            this.Shutdown.BackColor = System.Drawing.Color.Transparent;
            this.Shutdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Shutdown.ForeColor = System.Drawing.Color.Transparent;
            this.Shutdown.Location = new System.Drawing.Point(1154, 667);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(26, 25);
            this.Shutdown.TabIndex = 60;
            this.Shutdown.UseVisualStyleBackColor = false;
            this.Shutdown.Click += new System.EventHandler(this.Shutdown_Click);
            // 
            // balance
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1285, 758);
            this.Controls.Add(this.Shutdown);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "balance";
            this.Load += new System.EventHandler(this.balance_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton helpBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label AccNumberlbl;
        private System.Windows.Forms.Label accLbl;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button Shutdown;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label desLbl;
        private System.Windows.Forms.Label tempLbl;
    }
}