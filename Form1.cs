using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox3.Text);
            double c = Convert.ToDouble(textBox2.Text);

            double d = b * b - 4 * a * c;
            if(d<0)
            {
                MessageBox.Show("нет решения ");
            }
            else if (d == 0)
            {
                double x = -b / (2 * a);
                textBox5.Text = x.ToString();
            }
            else
            {
                double x1 = (-b+Math.Sqrt(d)) / (2 * a);
                textBox5.Text = x1.ToString();
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                textBox4.Text = x2.ToString();
            } 
        }
    }
}
