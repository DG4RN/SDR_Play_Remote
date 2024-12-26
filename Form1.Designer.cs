namespace SDR_Play_Remote
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.IO.Ports.SerialPort serialPTT;
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSendmsg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LNAcheckBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonANT3 = new System.Windows.Forms.RadioButton();
            this.radioButtonANT2 = new System.Windows.Forms.RadioButton();
            this.radioButtonANT1 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            serialPTT = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPTT
            // 
            serialPTT.PortName = "COM28";
            serialPTT.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PttHandler);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 132);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnClose.Location = new System.Drawing.Point(277, 188);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close\r\n";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnCloseClick);
            this.btnClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseMove);
            // 
            // btnSendmsg
            // 
            this.btnSendmsg.Location = new System.Drawing.Point(31, 26);
            this.btnSendmsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendmsg.Name = "btnSendmsg";
            this.btnSendmsg.Size = new System.Drawing.Size(99, 30);
            this.btnSendmsg.TabIndex = 2;
            this.btnSendmsg.Text = "Send";
            this.btnSendmsg.UseVisualStyleBackColor = true;
            this.btnSendmsg.Visible = false;
            this.btnSendmsg.Click += new System.EventHandler(this.btnSendmsgClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(200, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "                             ";
            // 
            // LNAcheckBox1
            // 
            this.LNAcheckBox1.AutoSize = true;
            this.LNAcheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNAcheckBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LNAcheckBox1.Location = new System.Drawing.Point(77, 144);
            this.LNAcheckBox1.Name = "LNAcheckBox1";
            this.LNAcheckBox1.Size = new System.Drawing.Size(136, 22);
            this.LNAcheckBox1.TabIndex = 4;
            this.LNAcheckBox1.Text = "LNA ON / OFF";
            this.LNAcheckBox1.UseVisualStyleBackColor = true;
            this.LNAcheckBox1.CheckedChanged += new System.EventHandler(this.LNAcheckBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.radioButtonANT3);
            this.groupBox1.Controls.Add(this.radioButtonANT2);
            this.groupBox1.Controls.Add(this.radioButtonANT1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(58, 188);
            this.groupBox1.MaximumSize = new System.Drawing.Size(160, 150);
            this.groupBox1.MinimumSize = new System.Drawing.Size(160, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 150);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARRAYS";
            // 
            // radioButtonANT3
            // 
            this.radioButtonANT3.AutoSize = true;
            this.radioButtonANT3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButtonANT3.Location = new System.Drawing.Point(7, 100);
            this.radioButtonANT3.Name = "radioButtonANT3";
            this.radioButtonANT3.Size = new System.Drawing.Size(84, 20);
            this.radioButtonANT3.TabIndex = 2;
            this.radioButtonANT3.Text = "Antenna 3";
            this.radioButtonANT3.UseVisualStyleBackColor = true;
            this.radioButtonANT3.CheckedChanged += new System.EventHandler(this.radioButtonANT3_CheckedChanged);
            this.radioButtonANT3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.radioButtonANT3_MouseMove);
            // 
            // radioButtonANT2
            // 
            this.radioButtonANT2.AutoSize = true;
            this.radioButtonANT2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.radioButtonANT2.Location = new System.Drawing.Point(7, 61);
            this.radioButtonANT2.Name = "radioButtonANT2";
            this.radioButtonANT2.Size = new System.Drawing.Size(84, 20);
            this.radioButtonANT2.TabIndex = 1;
            this.radioButtonANT2.Text = "Antenna 2";
            this.radioButtonANT2.UseVisualStyleBackColor = true;
            this.radioButtonANT2.CheckedChanged += new System.EventHandler(this.radioButtonANT2_CheckedChanged);
            this.radioButtonANT2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.radioButtonANT2_MouseMove);
            // 
            // radioButtonANT1
            // 
            this.radioButtonANT1.AutoSize = true;
            this.radioButtonANT1.Checked = true;
            this.radioButtonANT1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.radioButtonANT1.Location = new System.Drawing.Point(7, 22);
            this.radioButtonANT1.Name = "radioButtonANT1";
            this.radioButtonANT1.Size = new System.Drawing.Size(84, 20);
            this.radioButtonANT1.TabIndex = 0;
            this.radioButtonANT1.TabStop = true;
            this.radioButtonANT1.Text = "Antenna 1";
            this.radioButtonANT1.UseVisualStyleBackColor = true;
            this.radioButtonANT1.CheckedChanged += new System.EventHandler(this.radioButtonANT1_CheckedChanged);
            this.radioButtonANT1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.radioButtonANT1_MouseMove);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBox2.Location = new System.Drawing.Point(58, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "RX / TX Indicator\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(457, 358);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LNAcheckBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendmsg);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "SDR_Play_Remote by DG4RN";
            this.Load += new System.EventHandler(this.radioButtonANT1_CheckedChanged);
            this.Shown += new System.EventHandler(this.InitCom);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSendmsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox LNAcheckBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonANT3;
        private System.Windows.Forms.RadioButton radioButtonANT2;
        private System.Windows.Forms.RadioButton radioButtonANT1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

