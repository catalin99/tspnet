using ObjectWCF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formstandard
{
    public partial class Photo : Form
    {
        public Photo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MyPhotos().CreatePhoto(
                textBox2.Text, textBox1.Text, DateTime.Parse(textBox3.Text), textBox4.Text, textBox5.Text, textBox6.Text, Int32.Parse(textBox7.Text), Int32.Parse(textBox8.Text));
        }
    }
}
