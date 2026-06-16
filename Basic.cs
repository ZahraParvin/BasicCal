using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeCalc
{
    public partial class Basic : Form
    {
        public Basic()
        {
            InitializeComponent();
        }

        private void Basic_Load(object sender, EventArgs e)
        {

        }

        private void mult_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox2.Text);

            double product = txt1 * txt2;
            textBox3.Text = product.ToString();
        }


        private void plus_Click(object sender, EventArgs e)
        {

            double txt1 = Convert.ToDouble(textBox1.Text);

            double txt2 = Convert.ToDouble(textBox2.Text);

            double sum = txt1 + txt2; 

            textBox3.Text = sum.ToString();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void sub_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox2.Text);

            double diff = txt1 - txt2;
            textBox3.Text = diff.ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox2.Text);

            double division = txt1 / txt2;
            textBox3.Text = division.ToString();
        }

        private void perc_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(textBox1.Text);
            double txt2 = Convert.ToDouble(textBox2.Text);

            double percent = (txt1 / txt2) * 100;
            textBox3.Text = percent.ToString();
        }
    }
    
}
