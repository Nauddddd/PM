using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Management;

namespace PowerManager
{
    public partial class FormController : Form
    {
        public FormController()
        {
            InitializeComponent();
            LoadStatusBar();
        }

        StatusBarPanel statusBarPanel = new StatusBarPanel();
        StatusBarPanel timeDownPanel = new StatusBarPanel();

        void LoadStatusBar()
        {
            StatusBar bar = new StatusBar();

            bar.ShowPanels = true;
            bar.Panels.Add(statusBarPanel);
            bar.Panels.Add(timeDownPanel);

            statusBarPanel.Text = "Waiting...";
            timeDownPanel.Text = "";

            this.Controls.Add(bar);
        }
            

        decimal timeLeft = 0;

        
        //Tính toán thời gian
        void calculateTime()
        {
            if (numGio.Value != 0 | numPhut.Value != 0 | numGiay.Value != 0)
            {
                timeLeft = numGiay.Value + numPhut.Value * 60 + numGio.Value * 60 * 60;
            }
            
                
        }

        void ShutDown(string cmd)
        {
            System.Diagnostics.Process.Start("shutdown", cmd);
        }
        private void btnShutDown_Click(object sender, EventArgs e)
        {
            if (numGio.Value == 0 && numPhut.Value == 0 && numGiay.Value == 0)
            {
                MessageBox.Show("Bạn chưa chọn thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                calculateTime();
                ShutDown("-s -t " + timeLeft.ToString());
                statusBarPanel.Text = "Shutdown after";
                timeDownPanel.Text = timeLeft + " seconds";
                timer1.Start();

                btnCancel.Enabled = true;
                btnShutDown.Enabled = false;
                btnRestart.Enabled = false;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (numGio.Value == 0 && numPhut.Value == 0 && numGiay.Value == 0)
            {
                MessageBox.Show("Bạn chưa chọn thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                calculateTime();
                ShutDown("-r -t " + timeLeft.ToString());
                timer1.Start();
                
                statusBarPanel.Text = "Restart after";
                timeDownPanel.Text = timeLeft + " seconds";

                btnCancel.Enabled = true;
                btnShutDown.Enabled = false;
                btnRestart.Enabled = false;
            }

        }

        private void numGiay_ValueChanged(object sender, EventArgs e)
        {
            if (numGiay.Value >= 60)
            {
                numPhut.Value++;
                numGiay.Value = 0;
            }
            
        }

        private void numPhut_ValueChanged(object sender, EventArgs e)
        {
            if (numPhut.Value >= 60)
            {
                numGio.Value++;
                numPhut.Value = 0;
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ShutDown("-a");
            numGio.Value = 0;
            numPhut.Value = 0;
            numGiay.Value = 0;

            timer1.Stop();
            statusBarPanel.Text = "Waiting...";
            timeDownPanel.Text = "";

            btnRestart.Enabled = true;
            btnShutDown.Enabled = true;
            btnCancel.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            timeDownPanel.Text = timeLeft.ToString() + " seconds";
        }
        
        private void trackBarBrightness_Scroll(object sender, EventArgs e)
        {
            ManagementClass mclass = new ManagementClass("WmimonitorBrightnessMethods");
            mclass.Scope = new ManagementScope(@"\\.\root/wmi");
            ManagementObjectCollection instances = mclass.GetInstances();
            foreach (ManagementObject instance in instances)
            {
                ulong timeout = 1;
                ushort brightness = System.Convert.ToUInt16(trackBarBrightness.Value * 10);
                object[] args = new object[] { timeout, brightness };
                instance.InvokeMethod("WmiSetBrightness", args);
            }


        }

        
        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.Focus();
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitForm_Click(object sender, EventArgs e)
        {
            notifyIcon.Dispose();          
            Application.ExitThread();
            Environment.Exit(Environment.ExitCode);
        }

        private void showForm_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void FormController_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void FormController_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void FormController_Load(object sender, EventArgs e)
        {

        }
    }
}
