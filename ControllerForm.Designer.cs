namespace MobileRobotController
{
    partial class ControllerForm
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
            this.pBox_video = new System.Windows.Forms.PictureBox();
            this.btn_move_forward = new System.Windows.Forms.Button();
            this.btn_move_left = new System.Windows.Forms.Button();
            this.btn_move_backward = new System.Windows.Forms.Button();
            this.btn_move_right = new System.Windows.Forms.Button();
            this.rtxBox = new System.Windows.Forms.RichTextBox();
            this.gb_Movement = new System.Windows.Forms.GroupBox();
            this.gb_cam_rotation = new System.Windows.Forms.GroupBox();
            this.btn_cam_left = new System.Windows.Forms.Button();
            this.btn_cam_up = new System.Windows.Forms.Button();
            this.btn_cam_down = new System.Windows.Forms.Button();
            this.btn_cam_right = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_video)).BeginInit();
            this.gb_Movement.SuspendLayout();
            this.gb_cam_rotation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBox_video
            // 
            this.pBox_video.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBox_video.Enabled = false;
            this.pBox_video.Location = new System.Drawing.Point(247, 12);
            this.pBox_video.Name = "pBox_video";
            this.pBox_video.Size = new System.Drawing.Size(830, 453);
            this.pBox_video.TabIndex = 0;
            this.pBox_video.TabStop = false;
            // 
            // btn_move_forward
            // 
            this.btn_move_forward.BackColor = System.Drawing.Color.Transparent;
            this.btn_move_forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_move_forward.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_move_forward.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_move_forward.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_move_forward.Location = new System.Drawing.Point(80, 21);
            this.btn_move_forward.Name = "btn_move_forward";
            this.btn_move_forward.Size = new System.Drawing.Size(68, 68);
            this.btn_move_forward.TabIndex = 1;
            this.btn_move_forward.TabStop = false;
            this.btn_move_forward.Text = "UP";
            this.btn_move_forward.UseVisualStyleBackColor = false;
            this.btn_move_forward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.btn_move_forward.MouseLeave += new System.EventHandler(this.Mouse_Away);
            this.btn_move_forward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Up);
            // 
            // btn_move_left
            // 
            this.btn_move_left.BackColor = System.Drawing.Color.Transparent;
            this.btn_move_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_move_left.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_move_left.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_move_left.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_move_left.Location = new System.Drawing.Point(6, 95);
            this.btn_move_left.Name = "btn_move_left";
            this.btn_move_left.Size = new System.Drawing.Size(68, 68);
            this.btn_move_left.TabIndex = 7;
            this.btn_move_left.TabStop = false;
            this.btn_move_left.Text = "LEFT";
            this.btn_move_left.UseVisualStyleBackColor = false;
            this.btn_move_left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.btn_move_left.MouseLeave += new System.EventHandler(this.Mouse_Away);
            this.btn_move_left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Up);
            // 
            // btn_move_backward
            // 
            this.btn_move_backward.BackColor = System.Drawing.Color.Transparent;
            this.btn_move_backward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_move_backward.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_move_backward.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_move_backward.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_move_backward.Location = new System.Drawing.Point(80, 95);
            this.btn_move_backward.Name = "btn_move_backward";
            this.btn_move_backward.Size = new System.Drawing.Size(68, 68);
            this.btn_move_backward.TabIndex = 8;
            this.btn_move_backward.TabStop = false;
            this.btn_move_backward.Text = "DOWN";
            this.btn_move_backward.UseVisualStyleBackColor = false;
            this.btn_move_backward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.btn_move_backward.MouseLeave += new System.EventHandler(this.Mouse_Away);
            this.btn_move_backward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Up);
            // 
            // btn_move_right
            // 
            this.btn_move_right.BackColor = System.Drawing.Color.Transparent;
            this.btn_move_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_move_right.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_move_right.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_move_right.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_move_right.Location = new System.Drawing.Point(154, 95);
            this.btn_move_right.Name = "btn_move_right";
            this.btn_move_right.Size = new System.Drawing.Size(68, 68);
            this.btn_move_right.TabIndex = 9;
            this.btn_move_right.TabStop = false;
            this.btn_move_right.Text = "RIGHT";
            this.btn_move_right.UseVisualStyleBackColor = false;
            this.btn_move_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.btn_move_right.MouseLeave += new System.EventHandler(this.Mouse_Away);
            this.btn_move_right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Up);
            // 
            // rtxBox
            // 
            this.rtxBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.rtxBox.Enabled = false;
            this.rtxBox.Font = new System.Drawing.Font("Monospac821 BT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rtxBox.Location = new System.Drawing.Point(247, 472);
            this.rtxBox.MaxLength = 1500;
            this.rtxBox.Name = "rtxBox";
            this.rtxBox.ReadOnly = true;
            this.rtxBox.Size = new System.Drawing.Size(830, 127);
            this.rtxBox.TabIndex = 12;
            this.rtxBox.TabStop = false;
            this.rtxBox.Text = "";
            // 
            // gb_Movement
            // 
            this.gb_Movement.Controls.Add(this.btn_move_left);
            this.gb_Movement.Controls.Add(this.btn_move_forward);
            this.gb_Movement.Controls.Add(this.btn_move_backward);
            this.gb_Movement.Controls.Add(this.btn_move_right);
            this.gb_Movement.Location = new System.Drawing.Point(12, 431);
            this.gb_Movement.Name = "gb_Movement";
            this.gb_Movement.Size = new System.Drawing.Size(229, 168);
            this.gb_Movement.TabIndex = 13;
            this.gb_Movement.TabStop = false;
            this.gb_Movement.Text = "Movement";
            // 
            // gb_cam_rotation
            // 
            this.gb_cam_rotation.Controls.Add(this.btn_cam_left);
            this.gb_cam_rotation.Controls.Add(this.btn_cam_up);
            this.gb_cam_rotation.Controls.Add(this.btn_cam_down);
            this.gb_cam_rotation.Controls.Add(this.btn_cam_right);
            this.gb_cam_rotation.Location = new System.Drawing.Point(12, 257);
            this.gb_cam_rotation.Name = "gb_cam_rotation";
            this.gb_cam_rotation.Size = new System.Drawing.Size(229, 168);
            this.gb_cam_rotation.TabIndex = 14;
            this.gb_cam_rotation.TabStop = false;
            this.gb_cam_rotation.Text = "Camera Rotation";
            // 
            // btn_cam_left
            // 
            this.btn_cam_left.BackColor = System.Drawing.Color.Transparent;
            this.btn_cam_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cam_left.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cam_left.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cam_left.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cam_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cam_left.Location = new System.Drawing.Point(6, 95);
            this.btn_cam_left.Name = "btn_cam_left";
            this.btn_cam_left.Size = new System.Drawing.Size(68, 68);
            this.btn_cam_left.TabIndex = 7;
            this.btn_cam_left.TabStop = false;
            this.btn_cam_left.Text = "A";
            this.btn_cam_left.UseVisualStyleBackColor = false;
            this.btn_cam_left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.btn_cam_left.MouseLeave += new System.EventHandler(this.Mouse_Away);
            this.btn_cam_left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Up);
            // 
            // btn_cam_up
            // 
            this.btn_cam_up.BackColor = System.Drawing.Color.Transparent;
            this.btn_cam_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cam_up.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cam_up.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cam_up.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cam_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cam_up.Location = new System.Drawing.Point(80, 21);
            this.btn_cam_up.Name = "btn_cam_up";
            this.btn_cam_up.Size = new System.Drawing.Size(68, 68);
            this.btn_cam_up.TabIndex = 1;
            this.btn_cam_up.TabStop = false;
            this.btn_cam_up.Text = "W";
            this.btn_cam_up.UseVisualStyleBackColor = false;
            this.btn_cam_up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.btn_cam_up.MouseLeave += new System.EventHandler(this.Mouse_Away);
            this.btn_cam_up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Up);
            // 
            // btn_cam_down
            // 
            this.btn_cam_down.BackColor = System.Drawing.Color.Transparent;
            this.btn_cam_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cam_down.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cam_down.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cam_down.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cam_down.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cam_down.Location = new System.Drawing.Point(80, 95);
            this.btn_cam_down.Name = "btn_cam_down";
            this.btn_cam_down.Size = new System.Drawing.Size(68, 68);
            this.btn_cam_down.TabIndex = 8;
            this.btn_cam_down.TabStop = false;
            this.btn_cam_down.Text = "S";
            this.btn_cam_down.UseVisualStyleBackColor = false;
            this.btn_cam_down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.btn_cam_down.MouseLeave += new System.EventHandler(this.Mouse_Away);
            this.btn_cam_down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Up);
            // 
            // btn_cam_right
            // 
            this.btn_cam_right.BackColor = System.Drawing.Color.Transparent;
            this.btn_cam_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cam_right.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cam_right.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cam_right.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cam_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cam_right.Location = new System.Drawing.Point(154, 95);
            this.btn_cam_right.Name = "btn_cam_right";
            this.btn_cam_right.Size = new System.Drawing.Size(68, 68);
            this.btn_cam_right.TabIndex = 9;
            this.btn_cam_right.TabStop = false;
            this.btn_cam_right.Text = "D";
            this.btn_cam_right.UseVisualStyleBackColor = false;
            this.btn_cam_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.btn_cam_right.MouseLeave += new System.EventHandler(this.Mouse_Away);
            this.btn_cam_right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Up);
            // 
            // ControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 605);
            this.Controls.Add(this.gb_cam_rotation);
            this.Controls.Add(this.gb_Movement);
            this.Controls.Add(this.rtxBox);
            this.Controls.Add(this.pBox_video);
            this.KeyPreview = true;
            this.Name = "ControllerForm";
            this.Text = "ControllerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControllerForm_Closing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControllerForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ControllerForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_video)).EndInit();
            this.gb_Movement.ResumeLayout(false);
            this.gb_cam_rotation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox_video;
        private System.Windows.Forms.Button btn_move_forward;
        private System.Windows.Forms.Button btn_move_left;
        private System.Windows.Forms.Button btn_move_backward;
        private System.Windows.Forms.Button btn_move_right;
        private System.Windows.Forms.RichTextBox rtxBox;
        private System.Windows.Forms.GroupBox gb_Movement;
        private System.Windows.Forms.GroupBox gb_cam_rotation;
        private System.Windows.Forms.Button btn_cam_left;
        private System.Windows.Forms.Button btn_cam_up;
        private System.Windows.Forms.Button btn_cam_down;
        private System.Windows.Forms.Button btn_cam_right;
    }
}