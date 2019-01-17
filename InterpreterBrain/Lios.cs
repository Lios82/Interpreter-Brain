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
    public partial class Lios : Form
    {
        int s = 0;

        public Lios()
        {
            InitializeComponent();
        }

        private void Lios_Load(object sender, EventArgs e)
        {
            timer1.Interval = 600;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            if(s==5)
            {
                Application.Exit();
            }
        }
    }
}
