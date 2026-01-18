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
    public partial class singlequeue : Form
    {
        public singlequeue()
        {
            InitializeComponent();
        }
        private void avg_utilization_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(textBox1.Text);
            double n2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (n1 / n2).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(textBox1.Text);
            double n2 = Convert.ToDouble(textBox2.Text);
            textBox4.Text = (n1 / (n2 - n1)).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n3 = Convert.ToDouble(textBox3.Text);
            double n4 = Convert.ToDouble(textBox4.Text);
            textBox5.Text = (n3 * n4).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(textBox1.Text);
            double n2 = Convert.ToDouble(textBox2.Text);
            textBox6.Text = (1 / (n2 - n1)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double n3 = Convert.ToDouble(textBox3.Text);
            double n5 = Convert.ToDouble(textBox6.Text);
            textBox7.Text = (n3 * n5).ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {



            double n9 = Convert.ToDouble(textBox3.Text);
            double n = Convert.ToDouble(textBox8.Text);
            double sum = 0;


            for (var i = 0; i <= n; i++)
            {
                sum += (Math.Pow(n9, n));
            }
            textBox9.Text = (1 - (1 - n9) * sum).ToString();







        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg(*.jpg)|*.jpg| ";
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
