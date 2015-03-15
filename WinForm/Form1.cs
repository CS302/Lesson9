using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(5000);
            richTextBox1.Text = "Нажата первая кнопка";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Нажата вторая кнопка";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Нажата третья кнопка";
        }
    }
}
