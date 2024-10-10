using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            int val1 =int.Parse(textBox1.Text);
            int val2 =int.Parse(textBox2.Text);
            int res = val1 + val2;

            MessageBox.Show("The result is"+ res.ToString(),"hello", MessageBoxButtons.OK, MessageBoxIcon.Information);
      
        }

        private void label3_Click(object sender, EventArgs e)
        {
            int val1 = int.Parse(textBox1.Text);
            int val2 = int.Parse(textBox2.Text);
            int res = val1 - val2;

            MessageBox.Show("The result is" + res.ToString(), "hello", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label4_Click(object sender, EventArgs e)
        {
            int val1 = int.Parse(textBox1.Text);
            int val2 = int.Parse(textBox2.Text);
            int res = val1* val2;

            MessageBox.Show("The result is" + res.ToString(), "hello", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label5_Click(object sender, EventArgs e)
        {
            int val1 = int.Parse(textBox1.Text);
            int val2 = int.Parse(textBox2.Text);
            int res = val1 / val2;

            MessageBox.Show("The result is" + res.ToString(), "hello", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
