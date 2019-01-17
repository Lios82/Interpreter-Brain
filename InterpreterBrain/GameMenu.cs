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
    public partial class GameMenu : Form
    {
        int n;
        public GameMenu(int n)
        {
            InitializeComponent();
            this.n = n;
            if(n==1)
            {
                button1.Text = "ভুল নির্ণয় সেট";
                button2.Text = "আউটপুট নির্ণয় সেট";
                button3.Text = "মিশ্র সেট ( সহয )";
                button6.Text = "মিশ্র সেট ( কঠিন )";
                button7.Text = "মিশ্র সেট ( ঊদ্ভট )";
            }
            else
            {
                button1.Text = "Error Findout Set";
                button2.Text = "Output Findout Set";
                button3.Text = "Miscellaneous Set ( Easy )";
                button6.Text = "Miscellaneous Set ( Hard )";
                button7.Text = "Miscellaneous Set ( Harassing )";
            }
        }

        private void GameMenu_Load(object sender, EventArgs e)
        {

        }

        private void Call(int x)
        {
            this.Hide();
            GamePage gp = new GamePage(x);
            gp.Owner = this;
            gp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(n==1)
            {
                Call(1);
            }
            else
            {
                Call(6);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (n == 1)
            {
                Call(2);
            }
            else
            {
                Call(7);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (n == 1)
            {
                Call(3);
            }
            else
            {
                Call(8);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (n == 1)
            {
                Call(4);
            }
            else
            {
                Call(9);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (n == 1)
            {
                Call(5);
            }
            else
            {
                Call(10);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Lios l = new Lios();
            l.Owner = this;
            l.Show();
        }
    }
}
