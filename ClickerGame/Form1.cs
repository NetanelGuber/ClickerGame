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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using System.Data.SQLite;

namespace ClickerGame
{
    public partial class Form1 : Form
    {
        public static long Clicks = 0;
        public static long ClickPowerPrice = 10;
        public static long MultiplyPowerPrice = 5000;
        public static long ClickPower = 1;
        public static long cps = 0;
        public static long Rebirths = 0;

        int sec = 0;
        int min = 0;
        int hr = 0;

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
        long MindBlowingClicker = 125000000000;
        long TheInfinityClicker = 250000000000;

        private Thread thread1;
        private Thread thread2;
        private Thread thread3;

        // Define connection string (replace YourDataBaseName with your database name)
        string connectionString = "Data Source=UserData.db;Version=3;";
        SQLiteConnection m_dbConnection;
        public Form1()
        {
            InitializeComponent();

            // Create a new SQLite connection
            m_dbConnection = new SQLiteConnection(connectionString);

            // Open the connection
            m_dbConnection.Open();

            CreateDatabaseTableIfNotExist();

            string sql = "SELECT * FROM GameData ORDER BY Id DESC LIMIT 1";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Clicks = (long)reader["Clicks"];
                ClickPowerPrice = (long)reader["ClickPowerPrice"];
                MultiplyPowerPrice = (long)reader["MultiplyPowerPrice"];
                ClickPower = (long)reader["ClickPower"];
                cps = (long)reader["cps"];
                Form3.Rebirths = (long)reader["Rebirths"];
                Form3.RebirthPrice = (long)reader["RebirthPrice"];
            }

            label_pointerPrice.Text = SlowClicker.ToString("#,##0");
            label5.Text = OkayClicker.ToString("#,##0");
            label6.Text = BetterClicker.ToString("#,##0");
            label7.Text = UltraClicker.ToString("#,##0");
            label8.Text = HyperClicker.ToString("#,##0");
            label9.Text = MegaClicker.ToString("#,##0");
            label10.Text = GigaClicker.ToString("#,##0");
            label11.Text = OmegaClicker.ToString("#,##0");
            label12.Text = ExtraordinaryClicker.ToString("#,##0");
            label13.Text = PenultimateClicker.ToString("#,##0");
            label14.Text = ExcessiveClicker.ToString("#,##0");
            label15.Text = RevolutionaryClicker.ToString("#,##0");
            label16.Text = EternalClicker.ToString("#,##0");
            label18.Text = SuperbClicker.ToString("#,##0");
            label19.Text = DeluxeClicker.ToString("#,##0");
            label20.Text = TerrficClicker.ToString("#,##0");
            label21.Text = OutstandingClicker.ToString("#,##0");
            label22.Text = IncredibleClicker.ToString("#,##0");
            label23.Text = UnbelievableClicker.ToString("#,##0");
            label24.Text = AstonishingClicker.ToString("#,##0");
            label25.Text = MindBlowingClicker.ToString("#,##0");
            label26.Text = TheInfinityClicker.ToString("#,##0");

            thread1 = new Thread(new ThreadStart(UpdateText));
            thread2 = new Thread(new ThreadStart(Time));
            thread3 = new Thread(new ThreadStart(ClickCPS));
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private void UpdateText()
        {
            Thread.Sleep(1000);
            while (true)
            {
                Rebirths = Form3.Rebirths;
                this.Invoke((MethodInvoker)delegate
                {
                    clicks_label.Text = Clicks.ToString("#,##0");
                    label_clickingPowerPrice.Text = ClickPowerPrice.ToString("#,##0");
                    label_multiplyPowerPrice.Text = MultiplyPowerPrice.ToString("#,##0");
                    current_cps.Text = cps.ToString("#,##0");
                    current_rebirths.Text = Rebirths.ToString("#,##0");
                    label_clickingPower.Text = ClickPower.ToString("#,##0");
                    label_seconds.Text = sec.ToString();
                    label_minutes.Text = min.ToString();
                    label_hours.Text = hr.ToString();
                });

                Thread.Sleep(50);
            }
        }

        private void Time()
        {
            Thread.Sleep(1000);
            while (true)
            {
                if (sec >= 60)
                {
                    sec -= 60;
                    min += 1;
                }
                if (min >= 60)
                {
                    min -= 60;
                    hr += 1;
                }

                sec += 1;
                Thread.Sleep(1000);
            }
        }

        private void ClickCPS()
        {
            while (true)
            {
                Clicks += cps * (Rebirths + 1);
                Thread.Sleep(1000);
            }
        }

        private void click_button_Click(object sender, EventArgs e)
        {
            Clicks = (Clicks + ClickPower) + (Rebirths * ClickPower);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Clicks >= ClickPowerPrice)
            {
                Clicks -= ClickPowerPrice;
                ClickPowerPrice = ClickPowerPrice * 2;
                ClickPower++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Clicks >= MultiplyPowerPrice)
            {
                Clicks -= MultiplyPowerPrice;
                MultiplyPowerPrice = MultiplyPowerPrice * 2;
                ClickPower = ClickPower * 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Clicks >= SlowClicker)
            {
                Clicks -= SlowClicker;
                cps += 1;
            }
        }

        private void label_pointerPrice_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("This is the price.", label_pointerPrice);
        }

        private void tutorial_button_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Clicks >= OkayClicker)
            {
                Clicks -= OkayClicker;
                cps += 5;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Clicks >= BetterClicker)
            {
                Clicks -= BetterClicker;
                cps += 10;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Clicks >= UltraClicker)
            {
                Clicks -= UltraClicker;
                cps += 20;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Clicks >= HyperClicker)
            {
                Clicks -= HyperClicker;
                cps += 100;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Clicks >= MegaClicker)
            {
                Clicks -= MegaClicker;
                cps += 350;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Clicks >= GigaClicker)
            {
                Clicks -= GigaClicker;
                cps += 1000;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Clicks >= OmegaClicker)
            {
                Clicks -= OmegaClicker;
                cps += 3000;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Clicks >= ExtraordinaryClicker)
            {
                Clicks -= ExtraordinaryClicker;
                cps += 6000;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Clicks >= PenultimateClicker)
            {
                Clicks -= PenultimateClicker;
                cps += 50000;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Clicks >= ExcessiveClicker)
            {
                Clicks -= ExcessiveClicker;
                cps += 75000;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Clicks >= RevolutionaryClicker)
            {
                Clicks -= RevolutionaryClicker;
                cps += 100000;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Clicks >= EternalClicker)
            {
                Clicks -= EternalClicker;
                cps += 500000;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Clicks >= SuperbClicker)
            {
                Clicks -= SuperbClicker;
                cps += 750000;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Clicks >= DeluxeClicker)
            {
                Clicks -= DeluxeClicker;
                cps += 1500000;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Clicks >= TerrficClicker)
            {
                Clicks -= TerrficClicker;
                cps += 2500000;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (Clicks >= OutstandingClicker)
            {
                Clicks -= OutstandingClicker;
                cps += 5000000;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (Clicks >= IncredibleClicker)
            {
                Clicks -= IncredibleClicker;
                cps += 10000000;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (Clicks >= UnbelievableClicker)
            {
                Clicks -= UnbelievableClicker;
                cps += 20000000;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (Clicks >= AstonishingClicker)
            {
                Clicks -= AstonishingClicker;
                cps += 50000000;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (Clicks >= MindBlowingClicker)
            {
                Clicks -= MindBlowingClicker;
                cps += 100000000;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (Clicks >= TheInfinityClicker)
            {
                Clicks -= TheInfinityClicker;
                cps += 250000000;
            }
        }

        private void rebirthSection_button_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void CreateDatabaseTableIfNotExist()
        {
            string sql = @"CREATE TABLE IF NOT EXISTS GameData (
                        Id INTEGER PRIMARY KEY,
                        Clicks INTEGER,
                        ClickPowerPrice INTEGER,
                        MultiplyPowerPrice INTEGER,
                        ClickPower INTEGER,
                        cps INTEGER,
                        Rebirths INTEGER,
                        RebirthPrice INTEGER
                    )";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO GameData (Clicks, ClickPowerPrice, MultiplyPowerPrice, ClickPower, cps, Rebirths, RebirthPrice) 
                           VALUES (@Clicks, @ClickPowerPrice, @MultiplyPowerPrice, @ClickPower, @cps, @Rebirths, @RebirthPrice)";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);

            command.Parameters.AddWithValue("@Clicks", Clicks);
            command.Parameters.AddWithValue("@ClickPowerPrice", ClickPowerPrice);
            command.Parameters.AddWithValue("@MultiplyPowerPrice", MultiplyPowerPrice);
            command.Parameters.AddWithValue("@ClickPower", ClickPower);
            command.Parameters.AddWithValue("@cps", cps);
            command.Parameters.AddWithValue("@Rebirths", Form3.Rebirths);
            command.Parameters.AddWithValue("@RebirthPrice", Form3.RebirthPrice);

            command.ExecuteNonQuery();

            thread1.Abort();
            thread2.Abort();
            thread3.Abort();
            this.Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
        }
    }
}