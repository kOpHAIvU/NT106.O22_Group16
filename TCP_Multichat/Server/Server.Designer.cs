namespace Server
{
    partial class Server
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
            this.sendBtn = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.messageLv = new System.Windows.Forms.ListView();
            this.listen = new System.Windows.Forms.Button();
            this.inputPort = new System.Windows.Forms.TextBox();
            this.inputIP = new System.Windows.Forms.TextBox();
            this.serverName = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
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
            this.sendBtn.Location = new System.Drawing.Point(710, 436);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(68, 46);
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
            this.txtMessage.Size = new System.Drawing.Size(309, 36);
            this.txtMessage.TabIndex = 8;
            this.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // messageLv
            // 
            this.messageLv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.messageLv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageLv.ForeColor = System.Drawing.Color.White;
            this.messageLv.HideSelection = false;
            this.messageLv.Location = new System.Drawing.Point(369, 51);
            this.messageLv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.messageLv.Name = "messageLv";
            this.messageLv.Size = new System.Drawing.Size(407, 377);
            this.messageLv.TabIndex = 7;
            this.messageLv.UseCompatibleStateImageBehavior = false;
            this.messageLv.View = System.Windows.Forms.View.List;
            // 
            // listen
            // 
            this.listen.BackColor = System.Drawing.Color.Transparent;
            this.listen.FlatAppearance.BorderSize = 0;
            this.listen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.listen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.listen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listen.Location = new System.Drawing.Point(117, 328);
            this.listen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listen.Name = "listen";
            this.listen.Size = new System.Drawing.Size(174, 46);
            this.listen.TabIndex = 21;
            this.listen.UseVisualStyleBackColor = false;
            this.listen.Click += new System.EventHandler(this.listen_Click);
            // 
            // inputPort
            // 
            this.inputPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(197)))));
            this.inputPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputPort.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPort.ForeColor = System.Drawing.Color.White;
            this.inputPort.Location = new System.Drawing.Point(86, 241);
            this.inputPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputPort.Name = "inputPort";
            this.inputPort.Size = new System.Drawing.Size(201, 30);
            this.inputPort.TabIndex = 20;
            this.inputPort.Text = "1111";
            this.inputPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inputIP
            // 
            this.inputIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(197)))));
            this.inputIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputIP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputIP.ForeColor = System.Drawing.Color.White;
            this.inputIP.Location = new System.Drawing.Point(87, 158);
            this.inputIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputIP.Name = "inputIP";
            this.inputIP.Size = new System.Drawing.Size(199, 30);
            this.inputIP.TabIndex = 18;
            this.inputIP.Text = "127.0.0.1";
            this.inputIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // serverName
            // 
            this.serverName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(197)))));
            this.serverName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serverName.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverName.ForeColor = System.Drawing.Color.White;
            this.serverName.Location = new System.Drawing.Point(96, 74);
            this.serverName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(188, 30);
            this.serverName.TabIndex = 16;
            this.serverName.Text = "Server";
            this.serverName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Server.Properties.Resources.SERVER;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 504);
            this.Controls.Add(this.listen);
            this.Controls.Add(this.inputPort);
            this.Controls.Add(this.inputIP);
            this.Controls.Add(this.serverName);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.messageLv);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Server";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ListView messageLv;
        private System.Windows.Forms.Button listen;
        private System.Windows.Forms.TextBox inputPort;
        private System.Windows.Forms.TextBox inputIP;
        private System.Windows.Forms.TextBox serverName;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}

