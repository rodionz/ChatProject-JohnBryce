﻿namespace ClientInterface
{
    partial class SignIn
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IPmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.MaskedTextBox();
            this.clearIP = new System.Windows.Forms.Button();
            this.UsernameClearButton = new System.Windows.Forms.Button();
            this.Clearportbutton = new System.Windows.Forms.Button();
            this.ConfirmIP = new System.Windows.Forms.Button();
            this.NicknameConfirmationButton = new System.Windows.Forms.Button();
            this.PortConfirmationButtom = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.IPconfirmationLabel = new System.Windows.Forms.Label();
            this.NickNameConfirmationLabel = new System.Windows.Forms.Label();
            this.portConfirmationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Enter you port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter Your UserName:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter IP Adress:";
            // 
            // IPmaskedTextBox
            // 
            this.IPmaskedTextBox.Location = new System.Drawing.Point(333, 62);
            this.IPmaskedTextBox.Mask = " ###.###.###.###";
            this.IPmaskedTextBox.Name = "IPmaskedTextBox";
            this.IPmaskedTextBox.Size = new System.Drawing.Size(108, 20);
            this.IPmaskedTextBox.TabIndex = 17;
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(333, 115);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(108, 20);
            this.UserNameBox.TabIndex = 18;
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(333, 166);
            this.portTextBox.Mask = "00000";
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(108, 20);
            this.portTextBox.TabIndex = 19;
            this.portTextBox.ValidatingType = typeof(int);
            // 
            // clearIP
            // 
            this.clearIP.BackColor = System.Drawing.Color.Red;
            this.clearIP.Location = new System.Drawing.Point(518, 60);
            this.clearIP.Name = "clearIP";
            this.clearIP.Size = new System.Drawing.Size(66, 23);
            this.clearIP.TabIndex = 20;
            this.clearIP.Text = "Clear";
            this.clearIP.UseVisualStyleBackColor = false;
            this.clearIP.Click += new System.EventHandler(this.clearIP_Click);
            // 
            // UsernameClearButton
            // 
            this.UsernameClearButton.BackColor = System.Drawing.Color.Red;
            this.UsernameClearButton.Location = new System.Drawing.Point(518, 115);
            this.UsernameClearButton.Name = "UsernameClearButton";
            this.UsernameClearButton.Size = new System.Drawing.Size(66, 23);
            this.UsernameClearButton.TabIndex = 21;
            this.UsernameClearButton.Text = "Clear";
            this.UsernameClearButton.UseVisualStyleBackColor = false;
            this.UsernameClearButton.Click += new System.EventHandler(this.UsernameClearButton_Click);
            // 
            // Clearportbutton
            // 
            this.Clearportbutton.BackColor = System.Drawing.Color.Red;
            this.Clearportbutton.Location = new System.Drawing.Point(518, 166);
            this.Clearportbutton.Name = "Clearportbutton";
            this.Clearportbutton.Size = new System.Drawing.Size(66, 23);
            this.Clearportbutton.TabIndex = 22;
            this.Clearportbutton.Text = "Clear";
            this.Clearportbutton.UseVisualStyleBackColor = false;
            this.Clearportbutton.Click += new System.EventHandler(this.Clearportbutton_Click);
            // 
            // ConfirmIP
            // 
            this.ConfirmIP.Font = new System.Drawing.Font("Narkisim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ConfirmIP.Location = new System.Drawing.Point(636, 56);
            this.ConfirmIP.Name = "ConfirmIP";
            this.ConfirmIP.Size = new System.Drawing.Size(86, 26);
            this.ConfirmIP.TabIndex = 23;
            this.ConfirmIP.Text = "ConfirmIP";
            this.ConfirmIP.UseVisualStyleBackColor = true;
            this.ConfirmIP.Click += new System.EventHandler(this.ConfirmIP_Click);
            // 
            // NicknameConfirmationButton
            // 
            this.NicknameConfirmationButton.Font = new System.Drawing.Font("Narkisim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NicknameConfirmationButton.Location = new System.Drawing.Point(636, 114);
            this.NicknameConfirmationButton.Name = "NicknameConfirmationButton";
            this.NicknameConfirmationButton.Size = new System.Drawing.Size(125, 24);
            this.NicknameConfirmationButton.TabIndex = 24;
            this.NicknameConfirmationButton.Text = "Confirm UserName";
            this.NicknameConfirmationButton.UseVisualStyleBackColor = true;
            // 
            // PortConfirmationButtom
            // 
            this.PortConfirmationButtom.Font = new System.Drawing.Font("Narkisim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PortConfirmationButtom.Location = new System.Drawing.Point(636, 167);
            this.PortConfirmationButtom.Name = "PortConfirmationButtom";
            this.PortConfirmationButtom.Size = new System.Drawing.Size(97, 23);
            this.PortConfirmationButtom.TabIndex = 25;
            this.PortConfirmationButtom.Text = "Confirm port";
            this.PortConfirmationButtom.UseVisualStyleBackColor = true;
            this.PortConfirmationButtom.Click += new System.EventHandler(this.PortConfirmationButtom_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Font = new System.Drawing.Font("David", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ConnectButton.Location = new System.Drawing.Point(342, 259);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(120, 32);
            this.ConnectButton.TabIndex = 26;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            // 
            // IPconfirmationLabel
            // 
            this.IPconfirmationLabel.AutoSize = true;
            this.IPconfirmationLabel.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.IPconfirmationLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.IPconfirmationLabel.Location = new System.Drawing.Point(840, 70);
            this.IPconfirmationLabel.Name = "IPconfirmationLabel";
            this.IPconfirmationLabel.Size = new System.Drawing.Size(0, 16);
            this.IPconfirmationLabel.TabIndex = 27;
            // 
            // NickNameConfirmationLabel
            // 
            this.NickNameConfirmationLabel.AutoSize = true;
            this.NickNameConfirmationLabel.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NickNameConfirmationLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.NickNameConfirmationLabel.Location = new System.Drawing.Point(840, 122);
            this.NickNameConfirmationLabel.Name = "NickNameConfirmationLabel";
            this.NickNameConfirmationLabel.Size = new System.Drawing.Size(0, 16);
            this.NickNameConfirmationLabel.TabIndex = 28;
            // 
            // portConfirmationLabel
            // 
            this.portConfirmationLabel.AutoSize = true;
            this.portConfirmationLabel.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.portConfirmationLabel.Location = new System.Drawing.Point(840, 174);
            this.portConfirmationLabel.Name = "portConfirmationLabel";
            this.portConfirmationLabel.Size = new System.Drawing.Size(0, 16);
            this.portConfirmationLabel.TabIndex = 29;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1066, 453);
            this.Controls.Add(this.portConfirmationLabel);
            this.Controls.Add(this.NickNameConfirmationLabel);
            this.Controls.Add(this.IPconfirmationLabel);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.PortConfirmationButtom);
            this.Controls.Add(this.NicknameConfirmationButton);
            this.Controls.Add(this.ConfirmIP);
            this.Controls.Add(this.Clearportbutton);
            this.Controls.Add(this.UsernameClearButton);
            this.Controls.Add(this.clearIP);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.IPmaskedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox IPmaskedTextBox;
        public System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.MaskedTextBox portTextBox;
        private System.Windows.Forms.Button clearIP;
        private System.Windows.Forms.Button UsernameClearButton;
        private System.Windows.Forms.Button Clearportbutton;
        public System.Windows.Forms.Button ConfirmIP;
        public System.Windows.Forms.Button NicknameConfirmationButton;
        private System.Windows.Forms.Button PortConfirmationButtom;
        public System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label IPconfirmationLabel;
        private System.Windows.Forms.Label NickNameConfirmationLabel;
        private System.Windows.Forms.Label portConfirmationLabel;
    }
}