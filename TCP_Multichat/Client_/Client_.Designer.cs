namespace Client_
{
    partial class Client_
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
            this.sendBtn = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.messageLv = new System.Windows.Forms.ListView();
            this.guestName = new System.Windows.Forms.TextBox();
            this.inputIP = new System.Windows.Forms.TextBox();
            this.inputPort = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.Transparent;
            this.sendBtn.FlatAppearance.BorderSize = 0;
            this.sendBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sendBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ForeColor = System.Drawing.Color.White;
            this.sendBtn.Location = new System.Drawing.Point(707, 437);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(76, 46);
            this.sendBtn.TabIndex = 9;
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(197)))));
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.ForeColor = System.Drawing.Color.White;
            this.txtMessage.Location = new System.Drawing.Point(381, 439);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(313, 36);
            this.txtMessage.TabIndex = 8;
            this.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // messageLv
            // 
            this.messageLv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.messageLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageLv.ForeColor = System.Drawing.Color.White;
            this.messageLv.Location = new System.Drawing.Point(370, 50);
            this.messageLv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.messageLv.Name = "messageLv";
            this.messageLv.Size = new System.Drawing.Size(407, 377);
            this.messageLv.TabIndex = 7;
            this.messageLv.UseCompatibleStateImageBehavior = false;
            this.messageLv.View = System.Windows.Forms.View.List;
            // 
            // guestName
            // 
            this.guestName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(197)))));
            this.guestName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guestName.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestName.ForeColor = System.Drawing.Color.White;
            this.guestName.Location = new System.Drawing.Point(89, 74);
            this.guestName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guestName.Name = "guestName";
            this.guestName.Size = new System.Drawing.Size(194, 30);
            this.guestName.TabIndex = 6;
            this.guestName.Text = "Guest";
            this.guestName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inputIP
            // 
            this.inputIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(197)))));
            this.inputIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputIP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputIP.ForeColor = System.Drawing.Color.White;
            this.inputIP.Location = new System.Drawing.Point(89, 157);
            this.inputIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputIP.Name = "inputIP";
            this.inputIP.Size = new System.Drawing.Size(194, 30);
            this.inputIP.TabIndex = 11;
            this.inputIP.Text = "127.0.0.1";
            this.inputIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inputPort
            // 
            this.inputPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(197)))));
            this.inputPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputPort.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPort.ForeColor = System.Drawing.Color.White;
            this.inputPort.Location = new System.Drawing.Point(89, 240);
            this.inputPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputPort.Name = "inputPort";
            this.inputPort.Size = new System.Drawing.Size(194, 30);
            this.inputPort.TabIndex = 13;
            this.inputPort.Text = "1111";
            this.inputPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(121, 329);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 46);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Client_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Client_.Properties.Resources.USER;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputPort);
            this.Controls.Add(this.inputIP);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.messageLv);
            this.Controls.Add(this.guestName);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Client_";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ListView messageLv;
        private System.Windows.Forms.TextBox guestName;
        private System.Windows.Forms.TextBox inputIP;
        private System.Windows.Forms.TextBox inputPort;
        private System.Windows.Forms.Button button1;
    }
}

