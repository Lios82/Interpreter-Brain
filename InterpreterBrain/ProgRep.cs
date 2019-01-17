using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace InterpreterBrain
{
    public partial class ProgRep : Form
    {
        public ProgRep(int n, int scr)
        {
            InitializeComponent();
            x = n;
            if(n>5)
            {
                label1.Text = "Your Status: ";
                label3.Text = "Your Present: ";
                button1.Text = "Back to Game Menu";
                button3.Text = "Main Menu";
                button2.Text = "Exit this";
            }
            sum = scr;
        }

        int x,sum,img;

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            if(x<=5)
            {
                GameMenu gm = new GameMenu(1);
                gm.Owner = this;
                gm.Show();
            }
            else
            {
                GameMenu gm = new GameMenu(0);
                gm.Owner = this;
                gm.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            if(x<=5)
            {
                MainMenu m = new MainMenu(1);
                m.Owner = this;
                m.Show();
            }
            else
            {
                MainMenu m = new MainMenu(0);
                m.Owner = this;
                m.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Lios l = new Lios();
            l.Owner = this;
            l.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void ProgRep_Load(object sender, EventArgs e)
        {
            label2.Text = sum.ToString();
            if (x<=5)
            {               
                if (sum >= 80.00)
                {
                    img = 10;
                    label4.Text = "বাহ, আপনি A+ পেয়েছেন!!";
                    label5.Text = "আপনি দেখি খুবই ভাল Programmer";
                    label6.Text = "আপনি সর্বদা নিজেকে নিজের প্রতিদ্বন্দি মেনে চলবেন।";
                    pictureBox1.Image = Image.FromFile("EmoImages\\Scr" + img.ToString() + ".jpg");
                }
                else if (sum >= 70)
                {
                    img = 8;
                    label4.Text = "আপনি A পেয়েছেন।";
                    label5.Text = "আপনি ভাল Programming পারেন";
                    label6.Text = "আপনি ভাল Programmer, কিন্তু সেটা শুধু আপনার একার জানাই \nযথেষ্ট নয়।";
                    pictureBox1.Image = Image.FromFile("EmoImages\\Scr" + img.ToString() + ".jpg");
                }
                else if (sum >= 60)
                {
                    img = 7;
                    label4.Text = "আপনি A- পেয়েছেন।";
                    label5.Text = "আপনাকে আরও পরিশ্রম করতে হবে।";
                    label6.Text = "আপনাকে আরও বেশি একাগ্রতার সাথে কাজ করতে হবে, \nCandlelight Meditation করতে পারেন";
                    pictureBox1.Image = Image.FromFile("EmoImages\\Scr" + img.ToString() + ".jpg");
                }
                else if (sum >= 50)
                {
                    img = 6;
                    label4.Text = "আপনি B পেয়েছেন।";
                    label5.Text = "আপনাকে অনেক পরিশ্রম করতে হবে।";
                    label6.Text = "সবসময় Text editor এ coding না করে খাতায় \ncode লিখার অভ্যাস করুন।";
                    pictureBox1.Image = Image.FromFile("EmoImages\\Scr" + img.ToString() + ".jpg");
                }
                else
                {
                    img = 1;
                    label4.Text = "আপনি Fail করেছেন।";
                    label5.Text = "আপনার programming এর ভিত্তি যথেষ্ট পরিমাণে শক্ত নয়।";
                    label6.Text = "ভয় নেই, কেউ জ্ঞান নিয়ে জন্মে না, জন্মানোর পরে জ্ঞান অর্জন করে।";
                    pictureBox1.Image = Image.FromFile("EmoImages\\Scr" + img.ToString() + ".jpg");
                }
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                if (sum >= 80.00)
                {
                    img = 10;
                    label4.Text = "WOW, you've conquered A+!!";
                    label5.Text = "Really you are a better programmer.";
                    label6.Text = "Feel yourself as your competitor. Best of luck.";
                    pictureBox1.Image = Image.FromFile("EmoImages\\Scr" + img.ToString() + ".jpg");
                }
                else if (sum >= 70)
                {
                    img = 8;
                    label4.Text = "You achived A.";
                    label5.Text = "Your are really a good programmer.";
                    label6.Text = "You are a good Programmer, but always remember\nthat there's no limit of progress.";
                    pictureBox1.Image = Image.FromFile("EmoImages\\Scr" + img.ToString() + ".jpg");
                }
                else if (sum >= 60)
                {
                    img = 7;
                    label4.Text = "You've got A-";
                    label5.Text = "You have to more intensive.";
                    label6.Text = "You've to increase your concentration, \nyou may adopt Candlelight Meditation.";
                    pictureBox1.Image = Image.FromFile("EmoImages\\Scr" + img.ToString() + ".jpg");
                }
                else if (sum >= 50)
                {
                    img = 6;
                    label4.Text = "mmm, you've got B";
                    label5.Text = "You have to dedicate yourself more in programming.";
                    label6.Text = "Try to write code on blank paper, you'll must improve.";
                    pictureBox1.Image = Image.FromFile("EmoImages\\Scr" + img.ToString() + ".jpg");
                }
                else
                {
                    img = 1;
                    label4.Text = "You Failed in this test.";
                    label5.Text = "You have to build a strong base in programmnig.";
                    label6.Text = "Don't worry, no one born with knowledge,\neveryone achive knoledge after born.";
                    pictureBox1.Image = Image.FromFile("EmoImages\\Scr" + img.ToString() + ".jpg");
                }
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
