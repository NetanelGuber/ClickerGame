using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class Form6 : Form
    {
        int SlowClicker = 10;
        int OkayClicker = 50;
        int BetterClicker = 250;
        int UltraClicker = 500;
        int HyperClicker = 5000;
        int MegaClicker = 20000;
        int GigaClicker = 100000;
        int OmegaClicker = 250000;
        int ExtraordinaryClicker = 500000;
        int PenultimateClicker = 1000000;
        int ExcessiveClicker = 2500000;
        int RevolutionaryClicker = 10000000;
        int EternalClicker = 100000000;
        int SuperbClicker = 500000000;
        int DeluxeClicker = 1000000000;
        long TerrficClicker = 2500000000;
        long OutstandingClicker = 5000000000;
        long IncredibleClicker = 10000000000;
        long UnbelievableClicker = 30000000000;
        long AstonishingClicker = 75000000000;

        long CpsPerUpgrade = 0;
        long PriceForButton = 0;

        private Thread thread1;
        public Form6()
        {
            InitializeComponent();

            label2.Text = SlowClicker.ToString("#,##0");
            label3.Text = OkayClicker.ToString("#,##0");
            label4.Text = BetterClicker.ToString("#,##0");
            label5.Text = UltraClicker.ToString("#,##0");
            label6.Text = HyperClicker.ToString("#,##0");
            label7.Text = MegaClicker.ToString("#,##0");
            label8.Text = GigaClicker.ToString("#,##0");
            label9.Text = OmegaClicker.ToString("#,##0");
            label10.Text = ExtraordinaryClicker.ToString("#,##0");
            label11.Text = PenultimateClicker.ToString("#,##0");
            label12.Text = ExcessiveClicker.ToString("#,##0");
            label13.Text = RevolutionaryClicker.ToString("#,##0");
            label14.Text = EternalClicker.ToString("#,##0");
            label15.Text = SuperbClicker.ToString("#,##0");
            label16.Text = DeluxeClicker.ToString("#,##0");
            label17.Text = TerrficClicker.ToString("#,##0");
            label18.Text = OutstandingClicker.ToString("#,##0");
            label19.Text = IncredibleClicker.ToString("#,##0");
            label20.Text = UnbelievableClicker.ToString("#,##0");
            label21.Text = AstonishingClicker.ToString("#,##0");

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
                    label23.Text = CpsPerUpgrade.ToString("#,##0");
                    label24.Text = PriceForButton.ToString("#,##0");
                });

                Thread.Sleep(50);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            thread1.Abort();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form1.Clicks >= SlowClicker) 
            {
                CpsPerUpgrade += 1;
                PriceForButton += SlowClicker;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form1.Clicks >= OkayClicker)
            {
                CpsPerUpgrade += 5;
                PriceForButton += OkayClicker;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Form1.Clicks >= BetterClicker)
            {
                CpsPerUpgrade += 10;
                PriceForButton += BetterClicker;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Form1.Clicks >= UltraClicker)
            {
                CpsPerUpgrade += 20;
                PriceForButton += UltraClicker;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Form1.Clicks >= HyperClicker)
            {
                CpsPerUpgrade += 100;
                PriceForButton += HyperClicker;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Form1.Clicks >= MegaClicker)
            {
                CpsPerUpgrade += 350;
                PriceForButton += MegaClicker;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Form1.Clicks >= GigaClicker)
            {
                CpsPerUpgrade += 1000;
                PriceForButton += GigaClicker;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Form1.Clicks >= OmegaClicker)
            {
                CpsPerUpgrade += 3000;
                PriceForButton += OmegaClicker;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Form1.Clicks >= ExtraordinaryClicker)
            {
                CpsPerUpgrade += 6000;
                PriceForButton += ExtraordinaryClicker;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Form1.Clicks >= PenultimateClicker)
            {
                CpsPerUpgrade += 50000;
                PriceForButton += PenultimateClicker;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Form1.Clicks >= ExcessiveClicker)
            {
                CpsPerUpgrade += 75000;
                PriceForButton += ExcessiveClicker;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Form1.Clicks >= RevolutionaryClicker)
            {
                CpsPerUpgrade += 150000;
                PriceForButton += RevolutionaryClicker;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Form1.Clicks >= EternalClicker)
            {
                CpsPerUpgrade += 500000;
                PriceForButton += EternalClicker;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Form1.Clicks >= SuperbClicker)
            {
                CpsPerUpgrade += 750000;
                PriceForButton += SuperbClicker;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Form1.Clicks >= DeluxeClicker)
            {
                CpsPerUpgrade += 1500000;
                PriceForButton += DeluxeClicker;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (Form1.Clicks >= TerrficClicker)
            {
                CpsPerUpgrade += 2500000;
                PriceForButton += TerrficClicker;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (Form1.Clicks >= OutstandingClicker)
            {
                CpsPerUpgrade += 5000000;
                PriceForButton += OutstandingClicker;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (Form1.Clicks >= IncredibleClicker)
            {
                CpsPerUpgrade += 10000000;
                PriceForButton += IncredibleClicker;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Form1.Clicks >= AstonishingClicker)
            {
                CpsPerUpgrade += 50000000;
                PriceForButton += AstonishingClicker;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Form1.Clicks >= UnbelievableClicker)
            {
                CpsPerUpgrade += 10000000;
                PriceForButton += UnbelievableClicker;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.Clicks >= PriceForButton)
            {
                Form1.Clicks -= PriceForButton;
                Form1.cps += CpsPerUpgrade;
                CpsPerUpgrade = 0;
                PriceForButton = 0;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            CpsPerUpgrade = 0;
            PriceForButton = 0;
        }
    }
}
