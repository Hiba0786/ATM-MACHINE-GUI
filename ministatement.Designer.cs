namespace ATM_Management_Machine
{
    partial class ministatement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ministatement));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.cityLbl = new System.Windows.Forms.Label();
            this.desLbl = new System.Windows.Forms.Label();
            this.tempLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.helpBtn = new System.Windows.Forms.RadioButton();
            this.slipGrid = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.slipGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(369, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 62);
            this.panel2.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "ATM MANAGEMENT MACHINE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.cityLbl);
            this.panel1.Controls.Add(this.desLbl);
            this.panel1.Controls.Add(this.tempLbl);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.slipGrid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(369, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 468);
            this.panel1.TabIndex = 31;
            // 
            // closeBtn
            // 
            this.closeBtn.AutoEllipsis = true;
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(29, 70);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(59, 50);
            this.closeBtn.TabIndex = 54;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.cityLbl.Location = new System.Drawing.Point(485, 132);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(68, 20);
            this.cityLbl.TabIndex = 53;
            this.cityLbl.Text = "weather";
            // 
            // desLbl
            // 
            this.desLbl.AutoSize = true;
            this.desLbl.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold);
            this.desLbl.Location = new System.Drawing.Point(231, 132);
            this.desLbl.Name = "desLbl";
            this.desLbl.Size = new System.Drawing.Size(46, 20);
            this.desLbl.TabIndex = 52;
            this.desLbl.Text = "Desc";
            // 
            // tempLbl
            // 
            this.tempLbl.Font = new System.Drawing.Font("Calisto MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLbl.Location = new System.Drawing.Point(25, 132);
            this.tempLbl.Name = "tempLbl";
            this.tempLbl.Size = new System.Drawing.Size(184, 30);
            this.tempLbl.TabIndex = 51;
            this.tempLbl.Text = "Temp";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.helpBtn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(511, 68);
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
            this.helpBtn.Location = new System.Drawing.Point(6, 11);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(96, 33);
            this.helpBtn.TabIndex = 6;
            this.helpBtn.TabStop = true;
            this.helpBtn.Text = "Help?";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.CheckedChanged += new System.EventHandler(this.helpBtn_CheckedChanged);
            // 
            // slipGrid
            // 
            this.slipGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.slipGrid.Location = new System.Drawing.Point(63, 165);
            this.slipGrid.Name = "slipGrid";
            this.slipGrid.RowHeadersWidth = 51;
            this.slipGrid.RowTemplate.Height = 24;
            this.slipGrid.Size = new System.Drawing.Size(490, 289);
            this.slipGrid.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(203, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mini Statement";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(1012, 526);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 53);
            this.button4.TabIndex = 59;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(1012, 453);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 51);
            this.button3.TabIndex = 58;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(1012, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 60);
            this.button2.TabIndex = 57;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1012, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 62);
            this.button1.TabIndex = 56;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(325, 526);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(29, 53);
            this.button5.TabIndex = 63;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(325, 453);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(29, 51);
            this.button6.TabIndex = 62;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(325, 368);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(29, 60);
            this.button7.TabIndex = 61;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(325, 291);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(29, 62);
            this.button8.TabIndex = 60;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // Shutdown
            // 
            this.Shutdown.BackColor = System.Drawing.Color.Transparent;
            this.Shutdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Shutdown.ForeColor = System.Drawing.Color.Transparent;
            this.Shutdown.Location = new System.Drawing.Point(1156, 666);
            this.Shutdown.Name = "Shutdown";
            this.Shutdown.Size = new System.Drawing.Size(26, 25);
            this.Shutdown.TabIndex = 64;
            this.Shutdown.UseVisualStyleBackColor = false;
            this.Shutdown.Click += new System.EventHandler(this.Shutdown_Click);
            // 
            // ministatement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1267, 760);
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
            this.Name = "ministatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ministatement";
            this.Load += new System.EventHandler(this.ministatement_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slipGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView slipGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton helpBtn;
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
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button Shutdown;
    }
}