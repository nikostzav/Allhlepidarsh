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
    public partial class Form3 : Form
    {
        bool missing;
        public Form3(bool missing2)
        {
            missing = missing2;
            InitializeComponent();
            tm.Interval = 1000;
            tm.Tick += new EventHandler(timer1_Tick);
            tm.Start();
            

            
                
        }
        Timer tm = new Timer();
        Timer tm2 = new Timer();
        int X = 0;
        int Y = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
            // pictureBox6.Parent = pictureBox5;
            string data = "If you want to feed your pet, please tap to pet room.";
            label7.Text = data;
            label7.AutoSize = true;
            label7.MaximumSize = new Size(100, 0);
            if (missing)
                label7.Visible = false;
            if (missing == true)
            {
                tm2.Interval = 10000;
                tm2.Tick += new EventHandler(timer2_Tick);
                tm2.Start();
            }
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {

             if (pictureBox6.Location == pictureBox1.Location)
            {
                //pictureBox6.Parent = pictureBox1;
                pictureBox6.Visible = true;              
                pictureBox6.Location = new Point(157, 157);          
            }
            else if (pictureBox6.Left == 157 && pictureBox6.Top == 157)
            {
                pictureBox6.Location = new Point(157, 450);


            }
            else if (pictureBox6.Left == 157 && pictureBox6.Top == 450)
            {
                pictureBox6.Location = new Point(900, 450);
                //  pictureBox6.Parent = pictureBox2;

            }
            else if (pictureBox6.Left == 900 && pictureBox6.Top == 450)
            {
                pictureBox6.Location = new Point(850, 157);
                //  pictureBox6.Parent = pictureBox1;

            }
            else if (pictureBox6.Left == 850 && pictureBox6.Top == 157)
            {
                pictureBox6.Location = new Point(450, 250);
                // pictureBox6.Parent = pictureBox5;

            }
            else if (pictureBox6.Left == 450 && pictureBox6.Top == 250)
            {
                pictureBox6.Location = new Point(157, 157);
                // pictureBox6.Parent = pictureBox3;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            panel1.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("The food has added to the bowl");
            label7.Visible = true;
            panel1.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:\\Users\\danah\\Documents\\sxoli\\Αλληλεπίδραση\\help.chm", HelpNavigator.Topic, "html\\hs20.htm");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            Random r = new Random();
            String message = "";
            String message1 = "Left 100gr of food";
            String message2 = "Pet eat the food";
            String message3 = "Pet threw the food";
            String message4 = "Refilling water";
            String message5 = "Refilling food";
            int numb = r.Next(1, 6);
            switch (numb)
            {
                case 1:
                    message = message1;
                    break;
                case 2:
                    message = message2;
                    break;
                case 3:
                    message = message3;
                    break;
                case 4:
                    message = message4;
                    break;
                case 5:
                    message = message5;
                    break;
            }
            MessageBox.Show(message);
            tm2.Stop();
            
            
        }
    }
}

