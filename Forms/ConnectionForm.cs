using DevicesOnNetwork;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Renci.SshNet;


namespace MobileRobotController
{
    public partial class ConnectionForm : Form
    {

        private ControllerForm controllerForm = null;
        private SshClient sshClient;

        private delegate void lstBoxUpdater();

        public ConnectionForm()
        {
            InitializeComponent();
            PopulateDeviceList();
        }

        private void Close_connection()
        {
            try
            {
                sshClient.Disconnect();
                sshClient.Dispose();
            }
            catch (Exception) { }
            btn_Connect.Enabled = true;
        }

        private void PopulateDeviceList()
        {
            List<NetworkDevice> devices = NetworkDeviceFinder.Find();

            foreach (NetworkDevice device in devices)
            {
                device.NameResolved += onDNSResolve;
                device.ResolveName();
            }

            lstBox_devices.DataSource = NetworkDeviceFinder.KnownDevices;
        }
         
        private void ResetNetworkList()
        {
            lstBox_devices.DataSource = null;
            lstBox_devices.DataSource = NetworkDeviceFinder.KnownDevices;
        }

        private void Connect()
        {
            NetworkDevice host = (NetworkDevice)lstBox_devices.SelectedItem;
            
            try
            {
                sshClient = new SshClient(host.Name, txtBox_username.Text, txtBox_password.Text);
                sshClient.Connect();
            }
            catch(ArgumentException)
            {
                MessageBox.Show("Username is required.");
                return;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            controllerForm = new ControllerForm(sshClient, host);
            btn_Connect.Enabled = false;
            controllerForm.FormClosing += ControllerForm_FormClosing;
            controllerForm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateDeviceList();
        }

        private void onDNSResolve(object sender, EventArgs e)
        {

            lstBox_devices.Invoke(new lstBoxUpdater(ResetNetworkList));

        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            if (controllerForm != null && !controllerForm.IsDisposed)
            {
                controllerForm.Close();
                Close_connection();
            }
        }

        private void ControllerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close_connection();
        }

        private void txtBox_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\x0D' && btn_Connect.Enabled) Connect();
        }
    }
}
