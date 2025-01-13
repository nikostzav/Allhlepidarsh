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
    public partial class Shoe : Form
    {
        public Shoe()
        {
            InitializeComponent();
        }

        private void Shoe_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:\\Users\\danah\\Documents\\sxoli\\Αλληλεπίδραση\\help.chm", HelpNavigator.Topic, "html\\hs17.htm");
        }
    }
}
