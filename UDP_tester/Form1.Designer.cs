namespace UDP_tester
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_Remote_IP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Message_Send = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRemote_Port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Local_Port = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Message_Received = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Sender = new System.Windows.Forms.TextBox();
            this.buttonSetLocalPort = new System.Windows.Forms.Button();
            this.textBox_Local_IP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Multicast_IP = new System.Windows.Forms.TextBox();
            this.checkBox_Multicast = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox_Remote_IP
            // 
            this.textBox_Remote_IP.Location = new System.Drawing.Point(12, 20);
            this.textBox_Remote_IP.Name = "textBox_Remote_IP";
            this.textBox_Remote_IP.Size = new System.Drawing.Size(100, 20);
            this.textBox_Remote_IP.TabIndex = 0;
            this.textBox_Remote_IP.Text = "192.168.1.100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remote IP address";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(186, 60);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Enable TX";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "1000";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Repetition rate (ms)";
            // 
            // textBox_Message_Send
            // 
            this.textBox_Message_Send.Location = new System.Drawing.Point(15, 222);
            this.textBox_Message_Send.Name = "textBox_Message_Send";
            this.textBox_Message_Send.Size = new System.Drawing.Size(212, 20);
            this.textBox_Message_Send.TabIndex = 6;
            this.textBox_Message_Send.Text = "Hello, are you there?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Message to Send";
            // 
            // textBoxRemote_Port
            // 
            this.textBoxRemote_Port.Location = new System.Drawing.Point(128, 20);
            this.textBoxRemote_Port.Name = "textBoxRemote_Port";
            this.textBoxRemote_Port.Size = new System.Drawing.Size(43, 20);
            this.textBoxRemote_Port.TabIndex = 8;
            this.textBoxRemote_Port.Text = "5001";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Remote Port";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(128, 60);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(43, 20);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Counter";
            // 
            // textBox_Local_Port
            // 
            this.textBox_Local_Port.Location = new System.Drawing.Point(124, 38);
            this.textBox_Local_Port.Name = "textBox_Local_Port";
            this.textBox_Local_Port.Size = new System.Drawing.Size(43, 20);
            this.textBox_Local_Port.TabIndex = 12;
            this.textBox_Local_Port.Text = "5001";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Local Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Message Received";
            // 
            // textBox_Message_Received
            // 
            this.textBox_Message_Received.Location = new System.Drawing.Point(15, 267);
            this.textBox_Message_Received.Multiline = true;
            this.textBox_Message_Received.Name = "textBox_Message_Received";
            this.textBox_Message_Received.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Message_Received.Size = new System.Drawing.Size(247, 74);
            this.textBox_Message_Received.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Remote Sender";
            // 
            // textBox_Sender
            // 
            this.textBox_Sender.Location = new System.Drawing.Point(20, 358);
            this.textBox_Sender.Multiline = true;
            this.textBox_Sender.Name = "textBox_Sender";
            this.textBox_Sender.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Sender.Size = new System.Drawing.Size(186, 74);
            this.textBox_Sender.TabIndex = 16;
            // 
            // buttonSetLocalPort
            // 
            this.buttonSetLocalPort.Location = new System.Drawing.Point(185, 34);
            this.buttonSetLocalPort.Name = "buttonSetLocalPort";
            this.buttonSetLocalPort.Size = new System.Drawing.Size(38, 23);
            this.buttonSetLocalPort.TabIndex = 18;
            this.buttonSetLocalPort.Text = "Set";
            this.buttonSetLocalPort.UseVisualStyleBackColor = true;
            this.buttonSetLocalPort.Click += new System.EventHandler(this.buttonSetLocalPort_Click);
            // 
            // textBox_Local_IP
            // 
            this.textBox_Local_IP.Enabled = false;
            this.textBox_Local_IP.Location = new System.Drawing.Point(8, 37);
            this.textBox_Local_IP.Name = "textBox_Local_IP";
            this.textBox_Local_IP.Size = new System.Drawing.Size(100, 20);
            this.textBox_Local_IP.TabIndex = 19;
            this.textBox_Local_IP.Text = "192.168.1.100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Local IP address";
            // 
            // textBox_Multicast_IP
            // 
            this.textBox_Multicast_IP.Location = new System.Drawing.Point(9, 89);
            this.textBox_Multicast_IP.Name = "textBox_Multicast_IP";
            this.textBox_Multicast_IP.Size = new System.Drawing.Size(100, 20);
            this.textBox_Multicast_IP.TabIndex = 21;
            this.textBox_Multicast_IP.Text = "224.0.0.67";
            // 
            // checkBox_Multicast
            // 
            this.checkBox_Multicast.AutoSize = true;
            this.checkBox_Multicast.Location = new System.Drawing.Point(129, 91);
            this.checkBox_Multicast.Name = "checkBox_Multicast";
            this.checkBox_Multicast.Size = new System.Drawing.Size(104, 17);
            this.checkBox_Multicast.TabIndex = 22;
            this.checkBox_Multicast.Text = "Enable Multicast";
            this.checkBox_Multicast.UseVisualStyleBackColor = true;
            this.checkBox_Multicast.CheckedChanged += new System.EventHandler(this.checkBox_Multicast_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "MultiCast IP address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.checkBox_Multicast);
            this.groupBox1.Controls.Add(this.textBox_Multicast_IP);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_Local_IP);
            this.groupBox1.Controls.Add(this.buttonSetLocalPort);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_Local_Port);
            this.groupBox1.Location = new System.Drawing.Point(4, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 117);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(212, 385);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(50, 23);
            this.button_Clear.TabIndex = 25;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 437);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_Sender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Message_Received);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRemote_Port);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Message_Send);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Remote_IP);
            this.Name = "Form1";
            this.Text = "UDP tester by CiccioCB V0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox_Remote_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Message_Send;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRemote_Port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Local_Port;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Message_Received;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Sender;
        private System.Windows.Forms.Button buttonSetLocalPort;
        private System.Windows.Forms.TextBox textBox_Local_IP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Multicast_IP;
        private System.Windows.Forms.CheckBox checkBox_Multicast;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Clear;
    }
}

