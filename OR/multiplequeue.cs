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
    public partial class multiplequeue : Form
    {
        public multiplequeue()
        {
            InitializeComponent();
        }

        private void mean_arrival_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg(*.jpg)|*.jpg|";
        }

        private void avg_utilization_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            textBox4.Text = ((b) / (a * c)).ToString();



        }

        private void po_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double p = Convert.ToDouble(textBox4.Text);

            double factorial(double n)
            {
                if (n == 0 || n == 1)
                {
                    return 1;
                }
                else
                {
                    return n * factorial(n - 1);
                }
            }
            double sum = 0;
            for (var i = 0; i < a; i++)
            {
                sum += (Math.Pow((b / c), i)) / factorial(i);
            }
            double x = (Math.Pow((b / c), a)) / factorial(a);
            double y = 1 / (1 - p);
            double pNote = 1 / (sum + x * y);
            textBox5.Text = (pNote).ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double p = Convert.ToDouble(textBox4.Text);

            double factorial(double n)
            {
                if (n == 0 || n == 1)
                {
                    return 1;
                }
                else
                {
                    return n * factorial(n - 1);
                }
            }
            double sum = 0;
            for (var i = 0; i < a; i++)
            {
                sum += (Math.Pow((b / c), i)) / factorial(i);
            }
            double x = (Math.Pow((b / c), a)) / factorial(a);
            double y = 1 / (1 - p);
            double pNote = 1 / (sum + x * y);
            double lq = (pNote * Math.Pow((b / c), a) * p) / (factorial(a) * Math.Pow((1 - p), 2));
            textBox6.Text = (lq).ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double p = Convert.ToDouble(textBox4.Text);

            double factorial(double n)
            {
                if (n == 0 || n == 1)
                {
                    return 1;
                }
                else
                {
                    return n * factorial(n - 1);
                }
            }
            double sum = 0;
            for (var i = 0; i < a; i++)
            {
                sum += (Math.Pow((b / c), i)) / factorial(i);
            }
            double x = (Math.Pow((b / c), a)) / factorial(a);
            double y = 1 / (1 - p);
            double pNote = 1 / (sum + x * y);
            double lq = (pNote * Math.Pow((b / c), a) * p) / (factorial(a) * Math.Pow((1 - p), 2));
            textBox7.Text = (lq / b).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double wq = Convert.ToDouble(textBox7.Text);
            double c = Convert.ToDouble(textBox3.Text);
            textBox8.Text = (wq + (1 / c)).ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double w = Convert.ToDouble(textBox8.Text);
            double b = Convert.ToDouble(textBox2.Text);
            textBox9.Text = (w * b).ToString();

        }
    }
}
