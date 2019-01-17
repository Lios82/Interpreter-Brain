using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InterpreterBrain
{
    public partial class GamePage : Form
    {
        MySqlConnection mc;
        MySqlCommand cmd;
        string ms = "SELECT * FROM `",ans,st="set";
        MySqlDataReader mdr;
        DateTime d;
        TimeSpan t=new TimeSpan();
        int n,sum=0,x;

        public GamePage(int n)
        {
            InitializeComponent();
            x = n;
            MessageBox.Show("Please wait, this won't take a long.");
            try
            {
                mc = new MySqlConnection();
                mc.ConnectionString = "Server=MYSQL5011.HostBuddy.com;Database=db_a05317_test;Uid=a05317_test;Pwd=#TeamLios2016;";
                mc.Open();
                MessageBox.Show("Thanks for your patience.");
                cmd = new MySqlCommand(ms+st + n.ToString() + "`", mc);
                mdr = cmd.ExecuteReader();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if(n<=5)
            {
                this.n = 1;
                label2.Text = "Status: ";
                button1.Text = "আমি নিশ্চিত";
                button2.Text = "এখন বাড়ী যাবো";
                button3.Text = "নতুন করে শুরু করবো";
            }
            else
            {
                this.n = 2;
                label2.Text = "Status: ";
                button1.Text = "Submit";
                button2.Text = "Exit this game";
                button3.Text = "Back to Game Menu";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            GameMenu gm = new GameMenu(n);
            gm.Owner = this;
            gm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lios l = new Lios();
            l.Owner = this;
            l.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Lios l = new Lios();
            l.Owner = this;
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t = DateTime.Now.Subtract(d);            
            if(checkBox1.Checked==true && checkBox1.Text==ans)
            {
                if(checkBox2.Checked==true)
                {
                    Cnt(-1);
                }
                else
                {
                    if(t.TotalSeconds<=30)
                    {
                        Cnt(10);
                    }
                    else if(t.TotalSeconds<=60)
                    {
                        Cnt(9);
                    }
                    else if(t.TotalSeconds<=90)
                    {
                        Cnt(8);
                    }
                    else if(t.TotalSeconds<=120)
                    {
                        Cnt(7);
                    }
                    else if(t.TotalSeconds<=150)
                    {
                        Cnt(6);
                    }
                    else if(t.TotalSeconds<=180)
                    {
                        Cnt(5);
                    }
                    else if(t.TotalSeconds<=210)
                    {
                        Cnt(4);
                    }
                    else if(t.TotalSeconds<=240)
                    {
                        Cnt(3);
                    }
                    else if(t.TotalSeconds<=270)
                    {
                        Cnt(2);
                    }
                    else if(t.TotalSeconds<=300)
                    {
                        Cnt(1);
                    }
                    else
                    {
                        Cnt(-1);
                    }
                }
            }
            else if(checkBox2.Checked == true && checkBox2.Text == ans)
            {
                if (checkBox1.Checked == true)
                {
                    Cnt(-1);
                }
                else
                {
                    if (t.TotalSeconds <= 30)
                    {
                        Cnt(10);
                    }
                    else if (t.TotalSeconds <= 60)
                    {
                        Cnt(9);
                    }
                    else if (t.TotalSeconds <= 90)
                    {
                        Cnt(8);
                    }
                    else if (t.TotalSeconds <= 120)
                    {
                        Cnt(7);
                    }
                    else if (t.TotalSeconds <= 150)
                    {
                        Cnt(6);
                    }
                    else if (t.TotalSeconds <= 180)
                    {
                        Cnt(5);
                    }
                    else if (t.TotalSeconds <= 210)
                    {
                        Cnt(4);
                    }
                    else if (t.TotalSeconds <= 240)
                    {
                        Cnt(3);
                    }
                    else if (t.TotalSeconds <= 270)
                    {
                        Cnt(2);
                    }
                    else if (t.TotalSeconds <= 300)
                    {
                        Cnt(1);
                    }
                    else
                    {
                        Cnt(-1);
                    }
                }
            }
            else
            {
                Cnt(-1);
            }
            label3.Text = sum.ToString();
            GamePage_Load(sender, e);
        }

        int p = 0;

        private void GamePage_Load(object sender, EventArgs e)
        {
            d = DateTime.Now;
            p++;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            if(x<=5)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile("Trashes\\bin\\recycle\\Spyware\\recycle\\spam\\Scandal_1\\Virus\\Worm\\Malware\\set" + x.ToString()+"\\Archive\\Q"+p.ToString()+".jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("এই সেটটি শেষ করার জন্য আপনাকে ধন্যবাদ।");
                    Hide();
                    ProgRep pr = new ProgRep(x,sum);
                    pr.Owner = this;
                    pr.Show();
                }
            }
            else
            {
                try
                {
                    pictureBox1.Image = Image.FromFile("Trashes\\bin\\recycle\\Spyware\\recycle\\spam\\Scandal_1\\Virus\\Worm\\Malware\\set" + (x-5).ToString() + "\\Archive\\Q" + p.ToString() + ".jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thanks for completing this set.");
                    Hide();
                    ProgRep pr = new ProgRep(x,sum);
                    pr.Owner = this;
                    pr.Show();
                }
            }
            while (mdr.Read())
            {
                label4.Text = mdr["Qsn"].ToString();
                checkBox1.Text = mdr["Opn1"].ToString();
                checkBox2.Text = mdr["Opn2"].ToString();
                ans = mdr["Ans"].ToString();
                break;
            }
        }
        void Cnt(int n)
        {
            sum += n;
            if(x>5)
            {
                label5.Text = "You scored " + n.ToString() + " in previous question.";
            }
            else
            {
                if (n == 1)
                    label5.Text = "আগের প্রশ্নে আপনার অর্জন ১";
                else if (n==2)
                    label5.Text = "আগের প্রশ্নে আপনার অর্জন ২";
                else if(n==3)
                    label5.Text = "আগের প্রশ্নে আপনার অর্জন ৩";
                else if(n==4)
                    label5.Text = "আগের প্রশ্নে আপনার অর্জন ৪";
                else if(n==5)
                    label5.Text = "আগের প্রশ্নে আপনার অর্জন ৫";
                else if(n==6)
                    label5.Text = "আগের প্রশ্নে আপনার অর্জন ৬";
                else if(n==7)
                    label5.Text = "আগের প্রশ্নে আপনার অর্জন ৭";
                else if(n==8)
                    label5.Text = "আগের প্রশ্নে আপনার অর্জন ৮";
                else if(n==9)
                    label5.Text = "আগের প্রশ্নে আপনার অর্জন ৯";
                else if(n==10)
                    label5.Text = "আগের প্রশ্নে আপনার অর্জন ১০";
                else
                {
                    label5.Text = "আগের প্রশ্নে আপনি ভুল উত্তর দিয়েছেন";
                }
            }
            if (n==-1)
            {              
                label5.ForeColor = Color.Red;
            }
            else
            {
                label5.ForeColor = Color.Green;
            }
            if(n>0)
                pictureBox2.Image = Image.FromFile("EmoImages\\Scr"+n.ToString()+".jpg");
            else
                pictureBox2.Image = Image.FromFile("EmoImages\\Scr" + n.ToString() + ".jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
