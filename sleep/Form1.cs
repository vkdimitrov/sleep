using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sleep
{
    public partial class Form1 : Form
    {
        private int minutes;
        private string mins;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Shutdown", "-s -t "+this.mins);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            this.minutes = Int32.Parse(textBox1.Text)*60;
            this.mins = Convert.ToString(this.minutes);

        }
    }
}
