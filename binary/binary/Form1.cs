using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binary
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

        public string convertToBinary(double number)
        {
            string result = "";
            while(number != 0)
            {
                result += (number % 2).ToString();
                number /= 2;
                number = Math.Floor(number);
            }


            return reverseString(result);
        }
        public string reverseString(string a)
        {
            var b = a.ToCharArray();
            int len = b.Length;
            var c = a.ToCharArray();
            for (int i = 0; i <  b.Length; i++)
            {
                c[i] = b[len - i];
            }
            a = "";
            for(int i = 0; i < c.Length; i++)
            {
                a += c[i];
            }
            return a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double str = Convert.ToInt32(richTextBox1.Text);
            richTextBox2.Text = convertToBinary(str);
        }
    }
}
