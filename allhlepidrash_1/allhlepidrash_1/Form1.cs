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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           /* var form1 = new Form1();
            var form2 = new Form2();
            form1.Controls.Add(menuStrip);
            form2.Controls.Add(menuStrip);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void planOfTheDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:\\Users\\danah\\Documents\\sxoli\\Αλληλεπίδραση\\help.chm", HelpNavigator.Topic, "html\\hs10.htm");
        }

        private void petFeederToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:\\Users\\danah\\Documents\\sxoli\\Αλληλεπίδραση\\help.chm", HelpNavigator.Topic, "html\\hs20.htm");
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:\\Users\\danah\\Documents\\sxoli\\Αλληλεπίδραση\\help.chm", HelpNavigator.Topic, "html\\hs5.htm");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = true;
            label1.Parent = button1;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
    }
}
