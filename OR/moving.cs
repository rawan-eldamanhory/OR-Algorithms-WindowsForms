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
    public partial class moving : Form
    {
        public moving()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //3 moving average
            int a = 3;
            textBox8.Text = "-";
            textBox9.Text = "-";
            textBox10.Text = "-";
            textBox11.Text = ((int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text)) / a).ToString();
            textBox12.Text = ((int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text)) / a).ToString();
            textBox13.Text = ((int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text)) / a).ToString();
            textBox14.Text = ((int.Parse(textBox4.Text) + int.Parse(textBox5.Text) + int.Parse(textBox6.Text)) / a).ToString();

            // |ERROR|

            textBox22.Text = "-";
            textBox21.Text = "-";
            textBox20.Text = "-";
            textBox19.Text = (int.Parse(textBox4.Text) - int.Parse(textBox11.Text)).ToString();
            textBox18.Text = (int.Parse(textBox5.Text) - int.Parse(textBox12.Text)).ToString();
            textBox17.Text = (int.Parse(textBox6.Text) - int.Parse(textBox13.Text)).ToString();
            textBox16.Text = (int.Parse(textBox7.Text) - int.Parse(textBox14.Text)).ToString();
            int r = Int32.Parse(textBox19.Text);
            if (r < 0)
            {
                r = r * -1;             
            }
            textBox19.Text = r.ToString();

            int u = Int32.Parse(textBox18.Text);
            if (u < 0)
            {
                u = u * -1;
            }
            textBox18.Text = u.ToString();

            int g = Int32.Parse(textBox17.Text);
            if (g < 0)
            {
                g = g * -1;
            }
            textBox17.Text = g.ToString();

            int f = Int32.Parse(textBox16.Text);
            if (f < 0)
            {
                f = f * -1;
            }
            textBox16.Text = f.ToString();

            textBox38.Text = (int.Parse(textBox19.Text) + int.Parse(textBox18.Text) + int.Parse(textBox17.Text) + int.Parse(textBox16.Text)).ToString();

            //ERROR^2
            textBox28.Text = "-";
            textBox27.Text = "-";
            textBox26.Text = "-";
            textBox25.Text = (int.Parse(textBox19.Text) * int.Parse(textBox19.Text)).ToString();
            textBox24.Text = (int.Parse(textBox18.Text) * int.Parse(textBox18.Text)).ToString();
            textBox23.Text = (int.Parse(textBox17.Text) * int.Parse(textBox17.Text)).ToString();
            textBox15.Text = (int.Parse(textBox16.Text) * int.Parse(textBox16.Text)).ToString();

            // |%ERROR|
            int c = 100;
            textBox35.Text = "-";
            textBox34.Text = "-";
            textBox33.Text = "-";
            textBox32.Text = ((double.Parse(textBox19.Text) / double.Parse(textBox4.Text)) * c).ToString("N2") ;
            textBox31.Text = ((double.Parse(textBox18.Text) / double.Parse(textBox5.Text)) * c).ToString("N2") ;
            textBox30.Text = ((double.Parse(textBox17.Text) / double.Parse(textBox6.Text)) * c).ToString("N2") ;
            textBox29.Text = ((double.Parse(textBox16.Text) / double.Parse(textBox7.Text)) * c).ToString("N2") ;
            textBox39.Text = (double.Parse(textBox32.Text) + double.Parse(textBox31.Text) + double.Parse(textBox30.Text) + double.Parse(textBox29.Text)).ToString("N2");


            //MAD
            double z = 4;
            textBox36.Text = (int.Parse(textBox38.Text) / z).ToString();

            //MAPE
            textBox37.Text = (double.Parse(textBox39.Text) / z).ToString("N2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //5ma
            int a = 5;
            textBox8.Text = "-";
            textBox9.Text = "-";
            textBox10.Text = "-";
            textBox11.Text = "-";
            textBox12.Text = "-";
            textBox13.Text = ((int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text)) / a).ToString();
            textBox14.Text = ((int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text) + int.Parse(textBox5.Text) + int.Parse(textBox6.Text)) / a).ToString();

            //ERROR
            textBox22.Text = "-";
            textBox21.Text = "-";
            textBox20.Text = "-";
            textBox19.Text = "-";
            textBox18.Text = "-";
            textBox17.Text = (int.Parse(textBox6.Text) - int.Parse(textBox13.Text)).ToString();
            textBox16.Text = (int.Parse(textBox7.Text) - int.Parse(textBox14.Text)).ToString();

            int g = Int32.Parse(textBox17.Text);
            if (g < 0)
            {
                g = g * -1;
            }
            textBox17.Text = g.ToString();

            int f = Int32.Parse(textBox16.Text);
            if (f < 0)
            {
                f = f * -1;
            }
            textBox16.Text = f.ToString();

            textBox38.Text = (int.Parse(textBox17.Text) + int.Parse(textBox16.Text)).ToString();


            //ERROR^2
            textBox28.Text = "-";
            textBox27.Text = "-";
            textBox26.Text = "-";
            textBox25.Text = "-";
            textBox24.Text = "-";
            textBox23.Text = (int.Parse(textBox17.Text) * int.Parse(textBox17.Text)).ToString();
            textBox15.Text = (int.Parse(textBox16.Text) * int.Parse(textBox16.Text)).ToString();

            //ERROR%
            int c = 100;
            textBox35.Text = "-";
            textBox34.Text = "-";
            textBox33.Text = "-";
            textBox32.Text = "-";
            textBox31.Text = "-";
            textBox30.Text = ((double.Parse(textBox17.Text) / double.Parse(textBox6.Text)) * c).ToString("N2") ;
            textBox29.Text = ((double.Parse(textBox16.Text) / double.Parse(textBox7.Text)) * c).ToString("N2") ;


            //MAD
            int l = 2;
            textBox36.Text = (int.Parse(textBox38.Text) / l).ToString();

            //MAPE
            textBox37.Text = (double.Parse(textBox39.Text) / l).ToString("N2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
