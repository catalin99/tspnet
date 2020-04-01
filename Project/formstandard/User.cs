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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModelDesignFirst_L1.User user = ModelDesignFirst_L1.User.CreateUser(
                textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            ModelDesignFirst_L1.Model1Container context = new ModelDesignFirst_L1.Model1Container();
            context.Users.Add(user);
            context.SaveChanges();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
