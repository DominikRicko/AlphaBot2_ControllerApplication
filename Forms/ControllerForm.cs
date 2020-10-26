using System;
using System.Drawing;
using System.Windows.Forms;
using DevicesOnNetwork;
using Renci.SshNet;
using AForge.Video;

namespace MobileRobotController
{
    public partial class ControllerForm : Form
    {

        private MJPEGStream camera;
        private SSHConsole sshConsole;
        private AlphaBot2Controller controller;

        public ControllerForm(SshClient sshClient, NetworkDevice device)
        {
            InitializeComponent();

            pBox_video.SizeMode = PictureBoxSizeMode.StretchImage; 
            this.Text = device.Name;

            sshConsole = new SSHConsole(sshClient,rtxBox,label_Ping);
            sshConsole.SSHException += SshConsole_SSHException;

            camera = new MJPEGStream("http://" + device.IP.ToString() + ":8080/?action=stream");
            camera.NewFrame += new NewFrameEventHandler(Video_newFrame);

            sshConsole.WriteLine("cd AlphaBot2/mjpg-streamer/mjpg-streamer-experimental/");
            sshConsole.WriteLine("nohup ./start.sh &");
            sshConsole.WriteLine("cd");

            camera.Start();

            controller = new AlphaBot2Controller(sshConsole);

        }

        private void Cleanup()
        {
            controller.Destroy();

            camera.Stop();
        }

        private Keys ButtonToKey(Button whichButton)
        {
            if (whichButton.Equals(btn_move_forward))
            {
                return Keys.Up;
            }
            else if (whichButton.Equals(btn_move_backward))
            {
                return Keys.Down;
            }
            else if (whichButton.Equals(btn_move_left))
            {
                return Keys.Left;
            }
            else if (whichButton.Equals(btn_move_right))
            {
                return Keys.Right;
            }
            else if (whichButton.Equals(btn_cam_up))
            {
                return Keys.W;
            }
            else if (whichButton.Equals(btn_cam_down))
            {
                return Keys.S;
            }
            else if (whichButton.Equals(btn_cam_left))
            {
                return Keys.A;
            }
            else if (whichButton.Equals(btn_cam_right))
            {
                return Keys.D;
            }
            return Keys.None;
        }

        private void SshConsole_SSHException(object sender, EventArgs e)
        {
            Cleanup();
        }

        private void ControllerForm_Closing(Object sender, FormClosingEventArgs e)
        {
            Cleanup();
            sshConsole.WriteLine("\x04");
            sshConsole.WriteLine("sudo killall mjpg_streamer");
        }

        private void Video_newFrame(object sender, NewFrameEventArgs e)
        {
            pBox_video.Image = (Bitmap)e.Frame.Clone();
        }

        private void ControllerForm_KeyDown(object sender, KeyEventArgs e)
        {
            controller.RegisterPressedKey(e.KeyCode);
        }

        private void ControllerForm_KeyUp(object sender, KeyEventArgs e)
        {
            controller.UnregisterPressedKey(e.KeyCode);
        }

        private void Button_Down(object sender, MouseEventArgs e)
        {
            controller.RegisterPressedKey(ButtonToKey((Button)sender));
        }

        private void Mouse_Away(object sender, EventArgs e)
        {
            controller.UnregisterPressedKey(ButtonToKey((Button)sender));
        }

        private void Button_Up(object sender, MouseEventArgs e)
        {
            controller.UnregisterPressedKey(ButtonToKey((Button)sender));
        }

    }
}
