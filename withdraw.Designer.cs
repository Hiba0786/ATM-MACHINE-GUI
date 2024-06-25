namespace ATM_Management_Machine
{
    partial class withdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(withdraw));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cityLbl = new System.Windows.Forms.Label();
            this.desLbl = new System.Windows.Forms.Label();
            this.tempLbl = new System.Windows.Forms.Label();
            this.balanceLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.helpBtn = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.wdBtn = new System.Windows.Forms.Button();
            this.wdBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Shutdown = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(366, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 67);
            this.panel2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATM MANAGEMENT MACHINE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.cityLbl);
            this.panel1.Controls.Add(this.desLbl);
            this.panel1.Controls.Add(this.tempLbl);
            this.panel1.Controls.Add(this.balanceLbl);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.wdBtn);
            this.panel1.Controls.Add(this.wdBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(366, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 485);
            this.panel1.TabIndex = 21;
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.cityLbl.Location = new System.Drawing.Point(514, 227);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(68, 20);
            this.cityLbl.TabIndex = 54;
            this.cityLbl.Text = "weather";
            // 
            // desLbl
            // 
            this.desLbl.AutoSize = true;
            this.desLbl.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.desLbl.Location = new System.Drawing.Point(260, 227);
            this.desLbl.Name = "desLbl";
            this.desLbl.Size = new System.Drawing.Size(46, 20);
            this.desLbl.TabIndex = 53;
            this.desLbl.Text = "Desc";
            // 
            // tempLbl
            // 
            this.tempLbl.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLbl.Location = new System.Drawing.Point(54, 227);
            this.tempLbl.Name = "tempLbl";
            this.tempLbl.Size = new System.Drawing.Size(184, 30);
            this.tempLbl.TabIndex = 52;
            this.tempLbl.Text = "Temp";
            // 
            // balanceLbl
            // 
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.balanceLbl.ForeColor = System.Drawing.Color.White;
            this.balanceLbl.Location = new System.Drawing.Point(376, 336);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(134, 38);
            this.balanceLbl.TabIndex = 36;
            this.balanceLbl.Text = "Balance";
            // 
            // closeBtn
            // 
            this.closeBtn.AutoEllipsis = true;
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(13, 75);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(59, 50);
            this.closeBtn.TabIndex = 31;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(185, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 38);
            this.label6.TabIndex = 29;
            this.label6.Text = "Available Balance";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.helpBtn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(511, 75);
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
            this.helpBtn.Location = new System.Drawing.Point(6, 0);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(96, 50);
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
            this.label5.Location = new System.Drawing.Point(36, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 38);
            this.label5.TabIndex = 19;
            this.label5.Text = "Current Balance:";
            // 
            // wdBtn
            // 
            this.wdBtn.AutoEllipsis = true;
            this.wdBtn.BackColor = System.Drawing.Color.Black;
            this.wdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wdBtn.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.wdBtn.ForeColor = System.Drawing.Color.White;
            this.wdBtn.Location = new System.Drawing.Point(248, 413);
            this.wdBtn.Name = "wdBtn";
            this.wdBtn.Size = new System.Drawing.Size(168, 59);
            this.wdBtn.TabIndex = 8;
            this.wdBtn.Text = "Withdraw";
            this.wdBtn.UseVisualStyleBackColor = false;
            this.wdBtn.Click += new System.EventHandler(this.wdBtn_Click);
            // 
            // wdBox
            // 
            this.wdBox.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Bold);
            this.wdBox.Location = new System.Drawing.Point(324, 266);
            this.wdBox.Name = "wdBox";
            this.wdBox.Size = new System.Drawing.Size(239, 39);
            this.wdBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(95, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(241, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Withdraw";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(1019, 527);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 53);
            this.button4.TabIndex = 56;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(1019, 447);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 55);
            this.button3.TabIndex = 55;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(1019, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 60);
            this.button2.TabIndex = 54;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1019, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 62);
            this.button1.TabIndex = 53;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Shutdown
            // 
            this.Shutdown.BackColor = System.Drawing.Color.Transparent;
            this.Shutdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Shutdown.Location = new System.Drawing.Point(1153, 666);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(29, 28);
            this.Shutdown.TabIndex = 52;
            this.Shutdown.UseVisualStyleBackColor = false;
            this.Shutdown.Click += new System.EventHandler(this.Shutdown_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(323, 527);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 53);
            this.button5.TabIndex = 60;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(323, 447);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 55);
            this.button6.TabIndex = 59;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(323, 369);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(37, 60);
            this.button7.TabIndex = 58;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(323, 292);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(37, 62);
            this.button8.TabIndex = 57;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // withdraw
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1285, 765);
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
            this.Name = "withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "withdraw";
            this.Load += new System.EventHandler(this.withdraw_Load);
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
        private System.Windows.Forms.Button wdBtn;
        private System.Windows.Forms.TextBox wdBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Shutdown;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label desLbl;
        private System.Windows.Forms.Label tempLbl;
    }
}