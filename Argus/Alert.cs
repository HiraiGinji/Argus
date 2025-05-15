using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Argus
{
    public partial class Alert : Form
    {

        private Timer flickerTimer;
        private int flickerCount = 0;
        public Alert(string productNames)
        {
            InitializeComponent();
            label2.Text = productNames;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.Opacity = 0.9;

            flickerTimer = new Timer();
            flickerTimer.Interval = 200;
            flickerTimer.Start();

            Task.Delay(10000).ContinueWith(t => this.Invoke((Action)(() => this.Close())));
        }

        private void Alert_Load(object sender, EventArgs e)
        {

        }

        private void Alert_Load_1(object sender, EventArgs e)
        {

        }
    }
}
