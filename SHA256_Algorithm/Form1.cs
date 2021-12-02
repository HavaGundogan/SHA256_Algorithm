using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHA256_Algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        HashAlgoritmasi ha = new HashAlgoritmasi();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null || textBox1.Text != "")
            {
                textBox2.Text = ha.Sha256Enc(textBox1.Text);
            }

        }
    }
}
