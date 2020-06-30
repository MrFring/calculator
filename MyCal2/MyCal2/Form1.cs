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
            var x = int.Parse(this.textBoxOp1.Text);
            var y = int.Parse(this.textBoxOp2.Text);
            if (y != 0) {
                var z = x / y;
                this.labelResult.Text = z.ToString();
            }            
        }
    }
}
