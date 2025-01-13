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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            bool missing = false;
            Random r = new Random();
            int numb = r.Next(1,3);
            if (numb == 1)
            {
                DialogResult dr = MessageBox.Show("You are busy today,want me to feed your pet ?","",MessageBoxButtons.YesNo); 
                if(dr == DialogResult.Yes)
                {
                    missing = true;
                }
            }
            var form3 = new Form3(missing);
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Plan p = new Plan();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ElectricalDevice ed = new ElectricalDevice();
            ed.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
     
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }
    }
}
