
namespace torreta
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
            this.components = new System.ComponentModel.Container();
            this.screen = new System.Windows.Forms.Panel();
            this.lblScreenPos = new System.Windows.Forms.Label();
            this.lblScreenSize = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLTX = new System.Windows.Forms.Label();
            this.lblControllerStatus = new System.Windows.Forms.Label();
            this.lblConsola = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblOnOff = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPorts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMousePos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLTY = new System.Windows.Forms.Label();
            this.lblRTX = new System.Windows.Forms.Label();
            this.lblRTY = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(814, 591);
            this.screen.TabIndex = 0;
            this.screen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.screen_MouseMove);
            // 
            // lblScreenPos
            // 
            this.lblScreenPos.AutoSize = true;
            this.lblScreenPos.Location = new System.Drawing.Point(3, 78);
            this.lblScreenPos.Name = "lblScreenPos";
            this.lblScreenPos.Size = new System.Drawing.Size(22, 15);
            this.lblScreenPos.TabIndex = 2;
            this.lblScreenPos.Text = "x,y";
            // 
            // lblScreenSize
            // 
            this.lblScreenSize.AutoSize = true;
            this.lblScreenSize.Location = new System.Drawing.Point(3, 63);
            this.lblScreenSize.Name = "lblScreenSize";
            this.lblScreenSize.Size = new System.Drawing.Size(26, 15);
            this.lblScreenSize.TabIndex = 1;
            this.lblScreenSize.Text = "w,h";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblRTY);
            this.panel1.Controls.Add(this.lblRTX);
            this.panel1.Controls.Add(this.lblLTY);
            this.panel1.Controls.Add(this.lblLTX);
            this.panel1.Controls.Add(this.lblControllerStatus);
            this.panel1.Controls.Add(this.lblConsola);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(658, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 591);
            this.panel1.TabIndex = 3;
            // 
            // lblLTX
            // 
            this.lblLTX.AutoSize = true;
            this.lblLTX.Location = new System.Drawing.Point(4, 243);
            this.lblLTX.Name = "lblLTX";
            this.lblLTX.Size = new System.Drawing.Size(72, 15);
            this.lblLTX.TabIndex = 13;
            this.lblLTX.Text = "leftThumbX:";
            // 
            // lblControllerStatus
            // 
            this.lblControllerStatus.AutoSize = true;
            this.lblControllerStatus.Location = new System.Drawing.Point(3, 228);
            this.lblControllerStatus.Name = "lblControllerStatus";
            this.lblControllerStatus.Size = new System.Drawing.Size(97, 15);
            this.lblControllerStatus.TabIndex = 12;
            this.lblControllerStatus.Text = "Controller status:";
            // 
            // lblConsola
            // 
            this.lblConsola.Location = new System.Drawing.Point(3, 316);
            this.lblConsola.Multiline = true;
            this.lblConsola.Name = "lblConsola";
            this.lblConsola.Size = new System.Drawing.Size(150, 263);
            this.lblConsola.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblOnOff);
            this.panel2.Controls.Add(this.btnConnect);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbPorts);
            this.panel2.Controls.Add(this.lblScreenSize);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblScreenPos);
            this.panel2.Controls.Add(this.lblMousePos);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 225);
            this.panel2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Disconnect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOnOff
            // 
            this.lblOnOff.AutoSize = true;
            this.lblOnOff.ForeColor = System.Drawing.Color.Red;
            this.lblOnOff.Location = new System.Drawing.Point(85, 157);
            this.lblOnOff.Name = "lblOnOff";
            this.lblOnOff.Size = new System.Drawing.Size(28, 15);
            this.lblOnOff.TabIndex = 10;
            this.lblOnOff.Text = "OFF";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(4, 153);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mouse";
            // 
            // cmbPorts
            // 
            this.cmbPorts.FormattingEnabled = true;
            this.cmbPorts.Location = new System.Drawing.Point(3, 124);
            this.cmbPorts.Name = "cmbPorts";
            this.cmbPorts.Size = new System.Drawing.Size(140, 23);
            this.cmbPorts.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ports";
            // 
            // lblMousePos
            // 
            this.lblMousePos.AutoSize = true;
            this.lblMousePos.Location = new System.Drawing.Point(3, 26);
            this.lblMousePos.Name = "lblMousePos";
            this.lblMousePos.Size = new System.Drawing.Size(22, 15);
            this.lblMousePos.TabIndex = 3;
            this.lblMousePos.Text = "x,y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Screen";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLTY
            // 
            this.lblLTY.AutoSize = true;
            this.lblLTY.Location = new System.Drawing.Point(4, 258);
            this.lblLTY.Name = "lblLTY";
            this.lblLTY.Size = new System.Drawing.Size(72, 15);
            this.lblLTY.TabIndex = 14;
            this.lblLTY.Text = "leftThumbY:";
            // 
            // lblRTX
            // 
            this.lblRTX.AutoSize = true;
            this.lblRTX.Location = new System.Drawing.Point(4, 273);
            this.lblRTX.Name = "lblRTX";
            this.lblRTX.Size = new System.Drawing.Size(80, 15);
            this.lblRTX.TabIndex = 15;
            this.lblRTX.Text = "rigthThumbX:";
            // 
            // lblRTY
            // 
            this.lblRTY.AutoSize = true;
            this.lblRTY.Location = new System.Drawing.Point(4, 288);
            this.lblRTY.Name = "lblRTY";
            this.lblRTY.Size = new System.Drawing.Size(80, 15);
            this.lblRTY.TabIndex = 16;
            this.lblRTY.Text = "rightThumbY:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.screen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Move += new System.EventHandler(this.Form1_Move);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.Label lblScreenPos;
        private System.Windows.Forms.Label lblScreenSize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMousePos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOnOff;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox lblConsola;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblControllerStatus;
        private System.Windows.Forms.Label lblLTX;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblRTY;
        private System.Windows.Forms.Label lblRTX;
        private System.Windows.Forms.Label lblLTY;
    }
}

