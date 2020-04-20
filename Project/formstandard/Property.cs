using ObjectWCF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            AfterInitializeComponent();
            InitializeEvents();
        }

        public void AfterInitializeComponent()
        {
            var propertyCodes = new MyPhotos().GetPropertyCodes();
            comboBox2.DataSource = propertyCodes;
            comboBox2.DisplayMember = "Code";
            comboBox2.ValueMember = "ID";
        }

        public void InitializeEvents()
        {
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(UpdateMedia);
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int propCode = ((ModelDesignFirst_L1.PropertyCode)comboBox2.SelectedItem).ID;
            string description = textBox2.Text;
            int mediaId = comboBox1.SelectedItem.ToString() == "Photo" ? 
                ((ModelDesignFirst_L1.Photo)comboBox3.SelectedItem).ID : 
                ((ModelDesignFirst_L1.Movie)comboBox3.SelectedItem).ID;
            if (comboBox1.SelectedItem.ToString() == "Photo" || comboBox1.SelectedItem.ToString() == "Movie")
            {
                new MyPhotos().CreateProperty(description, mediaId, propCode);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new MyPhotos().CreatePropertyCode(textBox1.Text);
            AfterInitializeComponent();
            comboBox2.Refresh();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void UpdateMedia(object sender, System.EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Movie")
            {
                var movies = new MyPhotos().GetAllMovies();
                comboBox3.DataSource = movies;
                comboBox3.DisplayMember = "MovieName";
                comboBox3.ValueMember = "ID";
            }
            else if (comboBox1.SelectedItem.ToString() == "Photo")
            {
                var photos = new MyPhotos().GetAllPhotos();
                comboBox3.DataSource = photos;
                comboBox3.DisplayMember = "PhotoName";
                comboBox3.ValueMember = "ID";
            }
            comboBox3.Refresh();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {   
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
