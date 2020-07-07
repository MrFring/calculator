using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCal2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);
            var z = x + y;
            this.labelResult.Text = z.ToString();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);
            var z = x - y;
            this.labelResult.Text = z.ToString();
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);
            var z = x * y;
            this.labelResult.Text = z.ToString();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            var x = double.Parse(this.textBoxOp1.Text);
            var y = double.Parse(this.textBoxOp2.Text);
            if (y != 0) {
                var z = x / y;
                this.labelResult.Text = z.ToString();
            }
            else
            {
                this.labelResult.Text = "The divisor can't be zero.";
            }
        }

        private void buttonTri_Click(object sender, EventArgs e)
        {
            var a = double.Parse(this.textBoxOp1.Text);
            var b = double.Parse(this.textBoxOp2.Text);
            var c = double.Parse(this.textBoxOp3.Text);
            double p = (a + b + c) / 2;
            if (((a + b) >= c)&& ((a + c) >= b)&&((b + c) >= a))
            {
                var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                this.labelResult.Text = s.ToString();
            }
            else
            {
                this.labelResult.Text = "The length of these three sides can't form a triangle.";
            }
        }
    }
}
