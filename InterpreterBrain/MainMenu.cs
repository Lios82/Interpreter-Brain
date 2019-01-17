using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterpreterBrain
{
    public partial class MainMenu : Form
    {
        int n;

        public MainMenu(int n)
        {
            InitializeComponent();
            this.n = n;
            try
            {
                if(n==1)
                {
                    button1.Text = "আমি প্রস্তুত";
                    button2.Text = "জেনে নিন Team Lios সম্পর্কে";
                    button3.Text = "খেলবো না, বাড়ি যাবো";
                }
                else
                {
                    button1.Text = "Ready to survive";
                    button2.Text = "About Team Lios";
                    button3.Text = "Not interested";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Hide();
            Lios l = new Lios();
            l.Owner = this;
            l.Show();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (n == 2)
                MessageBox.Show("To know about us, please visit our website www.lios.co\n");
            else
                MessageBox.Show("আমাদের সম্পর্কে জানতে আমাদের নিজস্ব ওয়েবসাইট www.lios.co তে প্রবেশ করুন।\n");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            GameMenu gm = new GameMenu(n);
            gm.Owner = this;
            gm.Show();
        }
    }
}
