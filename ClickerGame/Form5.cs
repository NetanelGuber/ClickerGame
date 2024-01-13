using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Form1.Rebirths >= 1)
            {
                Form7 form = new Form7();
                form.Show();
            }
        }
    }
}
