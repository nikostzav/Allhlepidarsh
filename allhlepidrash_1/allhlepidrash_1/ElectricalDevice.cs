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
    public partial class ElectricalDevice : Form
    {
        public ElectricalDevice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ElectricalDevice1 ed1 = new ElectricalDevice1();
            ed1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int numb = r.Next(1, 3); 
            if (numb == 1)
            {
                Shoe s = new Shoe();
                s.Show();
            }
            else
            {
                Shoe2 s2 = new Shoe2();
                s2.Show(); 
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }
    }
}
