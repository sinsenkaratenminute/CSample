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

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Red;
            label1.Text = "こんにちは";

            label1.Hide();
            MessageBox.Show("こんにちは");
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
