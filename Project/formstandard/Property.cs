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
    public partial class Property : Form
    {
        public Property()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Property_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Movie");
            comboBox1.Items.Add("Photo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModelDesignFirst_L1.PropertyCode propertyCode = ModelDesignFirst_L1.PropertyCode.CreatePropertyCode(textBox1.Text
                );
            List<ModelDesignFirst_L1.PropertyCode> list = new List<ModelDesignFirst_L1.PropertyCode>();
            list.Add(propertyCode);
            ModelDesignFirst_L1.Property property = ModelDesignFirst_L1.Property.CreateProperty(null, null, list) ;
            ModelDesignFirst_L1.Model1Container context = new ModelDesignFirst_L1.Model1Container();
            context.PropertyCodes.Add(propertyCode);
            context.Properties.Add(property);
            context.SaveChanges();
        }
    }
}
