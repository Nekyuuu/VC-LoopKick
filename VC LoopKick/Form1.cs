using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VC_LoopKick
{
    public partial class Form1 : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        int r = 255, g = 0, b = 0;
        [DllImport("vc.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr DisconnectUser(byte[] token, byte[] serverid, byte[] victimid);

        private bool pause = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void confPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void serveridTextbox_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            disconnectTimer.Stop();
            disconnectTimer.Interval = Convert.ToInt32(intervalNumeric.Value);
            disconnectTimer.Start();
        }

        private void disconnectTimer_Tick(object sender, EventArgs e)
        {
            var token = Encoding.UTF8.GetBytes(tokenTextbox.Text);
            var victimid = Encoding.UTF8.GetBytes(victimidTextbox.Text);
            var serverid = Encoding.UTF8.GetBytes(serveridTextbox.Text);

            var resultbytes = DisconnectUser(token, serverid, victimid);
            var output = Marshal.PtrToStringAnsi(resultbytes);
            logTextbox.Text = logTextbox.Text + output + "\n";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimiseBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            disconnectTimer.Stop();
        }

        private void clearLogsButton_Click(object sender, EventArgs e)
        {
            logTextbox.Text = "";
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (pause)
            {
                disconnectTimer.Stop();
                pauseButton.Text = "Resume.";
                pause = false;
            }
            else
            {
                disconnectTimer.Start();
                pauseButton.Text = "Pause.";
                pause = true;
            }
        }

        private void creditLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var uri = "http://nekyuu.tk";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void rgbTimer_Tick(object sender, EventArgs e)
        {
            rgbPanel.BackColor = Color.FromArgb(r, g, b);

            if (r > 0 && b == 0)
            {
                r--;
                g++;
            }
            if (g > 0 && r == 0)
            {
                g--;
                b++;
            }
            if (b > 0 && g == 0)
            {
                b--;
                r++;
            }
        }
    }
}
