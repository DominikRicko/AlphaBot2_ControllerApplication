namespace MobileRobotController
{
    partial class ConnectionForm
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
            System.Windows.Forms.Label lb_devices;
            this.btn_Connect = new System.Windows.Forms.Button();
            this.txtBox_username = new System.Windows.Forms.TextBox();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.lstBox_devices = new System.Windows.Forms.ListBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            lb_devices = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_devices
            // 
            lb_devices.AutoSize = true;
            lb_devices.Enabled = false;
            lb_devices.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_devices.Location = new System.Drawing.Point(12, 13);
            lb_devices.Name = "lb_devices";
            lb_devices.Size = new System.Drawing.Size(104, 29);
            lb_devices.TabIndex = 1;
            lb_devices.Text = "Devices";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(464, 385);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(102, 54);
            this.btn_Connect.TabIndex = 3;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // txtBox_username
            // 
            this.txtBox_username.Location = new System.Drawing.Point(20, 404);
            this.txtBox_username.Name = "txtBox_username";
            this.txtBox_username.Size = new System.Drawing.Size(140, 22);
            this.txtBox_username.TabIndex = 1;
            this.txtBox_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Login_KeyPress);
            // 
            // txtBox_password
            // 
            this.txtBox_password.Location = new System.Drawing.Point(166, 404);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.PasswordChar = '*';
            this.txtBox_password.Size = new System.Drawing.Size(140, 22);
            this.txtBox_password.TabIndex = 2;
            this.txtBox_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Login_KeyPress);
            // 
            // lstBox_devices
            // 
            this.lstBox_devices.FormattingEnabled = true;
            this.lstBox_devices.ItemHeight = 16;
            this.lstBox_devices.Location = new System.Drawing.Point(13, 55);
            this.lstBox_devices.Name = "lstBox_devices";
            this.lstBox_devices.Size = new System.Drawing.Size(775, 308);
            this.lstBox_devices.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(572, 385);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(101, 54);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(679, 384);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(109, 55);
            this.btn_disconnect.TabIndex = 5;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.lstBox_devices);
            this.Controls.Add(this.txtBox_password);
            this.Controls.Add(this.txtBox_username);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(lb_devices);
            this.Name = "ConnectionForm";
            this.Text = "ConnectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox txtBox_username;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.ListBox lstBox_devices;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

