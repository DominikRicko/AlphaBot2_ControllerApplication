using System;
using System.Windows.Forms;
using Renci.SshNet;
using System.IO;
using Renci.SshNet.Common;

namespace MobileRobotController
{
    class SSHConsole
    {
        public SshClient sshClient { get; private set; }
        public TextBoxBase outputBox { get; private set; }

        private ShellStream sshStream;

        private delegate void delegateUpdate();

        private EventHandler onSSHException;
        
        public event EventHandler SSHException
        {
            add
            {
                onSSHException += value;
            }
            remove
            {
                onSSHException -= value;
            }
        }

        protected virtual void OnSSHException(EventArgs e)
        {
            onSSHException?.Invoke(this, e);
        }

        public SSHConsole(SshClient sshClient, TextBoxBase outputTextBox)
        {
            this.sshClient = sshClient;
            this.outputBox = outputTextBox;

            sshStream = sshClient.CreateShellStream("dumb", 80, 24, (uint)outputTextBox.Width, (uint)outputTextBox.Height, outputTextBox.MaxLength);

            sshStream.DataReceived += SshStream_DataReceived;

        }

        private void SshStream_DataReceived(object sender, ShellDataEventArgs e)
        {
            if (outputBox.InvokeRequired)
            {
                outputBox.Invoke(new delegateUpdate(UpdateOutput));
            }
        }

        public void UpdateOutput()
        {
            
            if (sshStream.DataAvailable)
            {
                try
                {
                    StreamReader reader = new StreamReader(sshStream);
                    string outputFrom = reader.ReadToEnd();
                    outputBox.AppendText(outputFrom);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                outputBox.SelectionStart = outputBox.Text.Length;
                outputBox.ScrollToCaret();
            }
        }

        public void WriteLine(string line)
        {
            try
            {
                sshStream.WriteLine(line);
            }
            catch (Exception)
            {
                OnSSHException(new EventArgs());
            }
        }

    }
}