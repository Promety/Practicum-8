using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8ZAd_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {        
            string s = textBox1.Text;

            Regex regex = new Regex(@"[-.?!);(,:]");
            MatchCollection matches = regex.Matches(s);
            var newText = Regex.Replace(s, "[-.?!);(,:]", "");
            textBox2.Text += newText;
            if (matches.Count == 0)
            {
                textBox2.Text = null;
                MessageBox.Show("В предложении нет знаков препинания", "Error");

            }
        }
    }
}
