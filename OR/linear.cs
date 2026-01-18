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
    public partial class linear : Form
    {
        public linear()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n = int.Parse(textBox14.Text);

            double sumX = double.Parse(textBox1.Text) + double.Parse(textBox2.Text) +
                    double.Parse(textBox3.Text) + double.Parse(textBox4.Text) +
                    double.Parse(textBox5.Text) + double.Parse(textBox6.Text);

            double sumY = double.Parse(textBox7.Text) + double.Parse(textBox8.Text) +
                    double.Parse(textBox9.Text) + double.Parse(textBox10.Text) +
                    double.Parse(textBox11.Text) + double.Parse(textBox12.Text);

            double sumX2 = (double.Parse(textBox1.Text) * double.Parse(textBox1.Text)) +
                (double.Parse(textBox2.Text) * double.Parse(textBox2.Text)) +
                (double.Parse(textBox3.Text) * double.Parse(textBox3.Text)) +
                (double.Parse(textBox4.Text) * double.Parse(textBox4.Text)) +
                (double.Parse(textBox5.Text) * double.Parse(textBox5.Text)) +
                (double.Parse(textBox6.Text) * double.Parse(textBox6.Text));

            double sumXY = (double.Parse(textBox1.Text) * double.Parse(textBox7.Text)) +
                (double.Parse(textBox2.Text) * double.Parse(textBox8.Text)) +
                (double.Parse(textBox3.Text) * double.Parse(textBox9.Text)) +
                (double.Parse(textBox4.Text) * double.Parse(textBox10.Text)) +
                (double.Parse(textBox5.Text) * double.Parse(textBox11.Text)) +
                (double.Parse(textBox6.Text) * double.Parse(textBox12.Text));

            double a = (((sumY) * (sumX2)) - ((sumX) * (sumXY))) / (((n) * (sumX2)) - ((sumX) * (sumX)));

            double b = (((n) * (sumXY)) - ((sumX) * (sumY))) / (((n) * (sumX2)) - ((sumX) * (sumX)));

            double x = double.Parse(textBox13.Text);

            double Y = a + (b * x);

            label4.Text = Y.ToString();
        }
        private void linear_Load(object sender, EventArgs e)
        {

        }

     
    }
}
