using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OR
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            simplex ss = new simplex();
            ss.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            linear ll = new linear();
            ll.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            moving mm = new moving();
            mm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            graphical gg = new graphical();
            gg.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            singlequeue sq = new singlequeue();
            sq.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            multiplequeue mq = new multiplequeue();
            mq.ShowDialog();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }
    }
}
