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
            AfterInitializeComponent();
            AddPhotosInList();
            InitializeEvents();
        }

        private void AfterInitializeComponent()
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
        }

        private void AddPhotosInList()
        {
            var photos = new MyPhotos().GetAllPhotos();
            var photos2 = new MyPhotos().GetAllPhotos();
            comboBox1.DataSource = photos;
            comboBox1.DisplayMember = "PhotoName";
            comboBox1.ValueMember = "FullPath";
            comboBox2.DataSource = photos2;
            comboBox2.DisplayMember = "PhotoName";
            comboBox2.ValueMember = "ID";
        }

        private void InitializeEvents()
        {
            this.comboBox1.SelectedValueChanged += new System.EventHandler(UpdatePictureView);
            
        }

        private void UpdatePictureView(object sender, System.EventArgs e)
        {
            var img = (Image)new Bitmap(Image.FromFile(comboBox1.SelectedValue.ToString()), new Size(pictureBox2.Width, pictureBox2.Height));
            pictureBox2.Image = img;
            pictureBox2.Refresh();
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
                textBox2.Text, textBox1.Text, dateTimePicker1.Value, textBox4.Text, textBox5.Text, textBox6.Text, Int32.Parse(textBox7.Text), Int32.Parse(textBox8.Text));
            this.comboBox1.SelectedValueChanged -= UpdatePictureView;
            AddPhotosInList();
            this.comboBox1.SelectedValueChanged += new System.EventHandler(UpdatePictureView);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string formats = "All Image Files |*.png; *.jpg; *.jpeg";

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Photo",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "png",

                Filter = formats,
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName.Split('\\').Last();
                textBox1.Text = fileName;
                textBox2.Text = openFileDialog1.FileName;
                var img = (Image)new Bitmap(Image.FromFile(openFileDialog1.FileName),new Size(pictureBox1.Width, pictureBox1.Height));
                pictureBox1.Image = img;
                pictureBox1.Refresh();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MyPhotos().DeletePhoto(Int32.Parse(comboBox2.SelectedValue.ToString()));
            this.comboBox1.SelectedValueChanged -= UpdatePictureView;
            AddPhotosInList();
            this.comboBox1.SelectedValueChanged += new System.EventHandler(UpdatePictureView);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            var photo = new MyPhotos().GetPhotoById(((ModelDesignFirst_L1.Photo)comboBox1.SelectedItem).ID);
            var prop = "Name: " + photo.PhotoName;
            prop += "\nCreation Date: " + photo.CreationDate.ToString();
            prop += "\nEvent: " + photo.Event;
            prop += "\nPersons: " + photo.TaggedPersons;
            prop += "\nLocations: " + photo.Location;
            prop += "\nHeight: " + photo.Height;
            prop += "\nWeight: " + photo.Weight;
            // Displays the MessageBox.
            result = MessageBox.Show(prop, "Proprerties", buttons);
        }


        private void button5_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            var photo = new MyPhotos().GetPhotoById(((ModelDesignFirst_L1.Photo)comboBox1.SelectedItem).ID);
            var props  = new MyPhotos().GetPropertiesByMediaID(photo.ID);
            var msj = "Photo: " + photo.PhotoName;
            var propCodes = new MyPhotos().GetPropertyCodes();
            foreach (var prop in props)
            {
                var code = propCodes.FirstOrDefault(a => a.ID == prop.PropertyCodeID);
                msj += "\n" + code.Code + ": " + prop.Description;
            }
            MessageBox.Show(msj, "Special Proprieties", buttons);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
