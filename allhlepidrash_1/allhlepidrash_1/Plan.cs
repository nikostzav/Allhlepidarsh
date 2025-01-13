using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allhlepidrash_1
{
    public partial class Plan : Form
    {
        public Plan()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to plan!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to plan!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to plan!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to plan!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to plan!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to plan!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Plan2 p2 = new Plan2();
            p2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:\\Users\\danah\\Documents\\sxoli\\Αλληλεπίδραση\\help.chm", HelpNavigator.Topic, "html\\hs10.htm");
        }
    }
}
