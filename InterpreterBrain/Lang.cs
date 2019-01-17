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
    public partial class Lang : Form
    {
        public Lang()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu(1);
            m.Owner = this;
            m.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            MainMenu m = new MainMenu(2);
            m.Owner = this;
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Lios l = new Lios();
            l.Owner = this;
            l.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Hide();
            MainMenu m = new MainMenu(1);
            m.Owner = this;
            m.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Hide();
            MainMenu m = new MainMenu(2);
            m.Owner = this;
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you are Bangladeshi or native Bangla speker then we recommend you to chose \"Yes, I am Bangladeshi\" for communicate with this application in Bangla. If not, please select another option so that you may communicate with this in English.\nThank you.");
        }
    }
}
