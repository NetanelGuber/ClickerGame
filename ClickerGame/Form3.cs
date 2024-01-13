using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace ClickerGame
{
    public partial class Form3 : Form
    {

        public static long RebirthPrice = 5000000000000;
        public static long Rebirths = 0;
        private Thread thread1;
        public Form3()
        {
            InitializeComponent();
            thread1 = new Thread(new ThreadStart(UpdateText));
            thread1.Start();
        }

        private void UpdateText()
        {
            Thread.Sleep(1000);
            while (true)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    label_rebirthPrice.Text = RebirthPrice.ToString("#,##0");
                });

                Thread.Sleep(50);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.Clicks >= RebirthPrice)
            {
                Rebirths += 1;
                RebirthPrice = RebirthPrice * 3;
                Form1.Clicks = 0;
                Form1.cps = 0;
                Form1.ClickPower = 1;
                Form1.ClickPowerPrice = 10;
                Form1.MultiplyPowerPrice = 5000;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thread1.Abort();
            this.Close();
        }
    }
}
