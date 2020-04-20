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
using WMPLib;

namespace formstandard
{
    public partial class Movie : Form
    {
        public Movie()
        {
            InitializeComponent();
            AfterInitializeComponent();
            AddMoviesInList();
        }

        private void AddMoviesInList()
        {
            var movies = new ProjectClient().GetAllMovies();
            var moviesShow = new ProjectClient().GetAllMovies();
            comboBox1.DataSource = movies;
            comboBox1.DisplayMember = "MovieName";
            comboBox1.ValueMember = "ID";
            if (movies.Length == 0)
                comboBox1.Text = "No movies";

            comboBox1.Refresh();
            comboBox2.DataSource = moviesShow;
            comboBox2.DisplayMember = "MovieName";
            comboBox2.ValueMember = "FullPath";
            if (moviesShow.Length == 0)
                comboBox2.Text = "No movies";
            comboBox2.Refresh();
        }

        private void AfterInitializeComponent()
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ProjectClient().CreateMovie(
                textBox2.Text, textBox1.Text, dateTimePicker1.Value, 
                textBox4.Text, textBox5.Text, textBox6.Text, Int32.Parse(textBox7.Text));
            AddMoviesInList();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string formats = "All Videos Files |*.dat; *.wmv; *.3g2; *.3gp; *.3gp2; *.3gpp; *.amv; *.asf;  *.avi; *.bin; *.cue; *.divx; *.dv; *.flv; *.gxf; *.iso; *.m1v; *.m2v; *.m2t; *.m2ts; *.m4v; " +
                  " *.mkv; *.mov; *.mp2; *.mp2v; *.mp4; *.mp4v; *.mpa; *.mpe; *.mpeg; *.mpeg1; *.mpeg2; *.mpeg4; *.mpg; *.mpv2; *.mts; *.nsv; *.nuv; *.ogg; *.ogm; *.ogv; *.ogx; *.ps; *.rec; *.rm; *.rmvb; *.tod; *.ts; *.tts; *.vob; *.vro; *.webm";

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Movie",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "avi",
                
                Filter=formats,
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
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox2.Text!=string.Empty)
                new WindowsMediaPlayer().openPlayer(textBox2.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new ProjectClient().DeleteMovie(Int32.Parse(comboBox1.SelectedValue.ToString()));
            AddMoviesInList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue!=null)
                new WindowsMediaPlayer().openPlayer(comboBox2.SelectedValue.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            var movie = new ProjectClient().GetMovieById(((ModelDesignFirst_L1.Movie)comboBox2.SelectedItem).ID);
            var prop = "Name: " + movie.MovieName;
            prop += "\nCreation Date: " + movie.CreationDate.ToString();
            prop += "\nEvent: " + movie.Event;
            prop += "\nPersons: " + movie.TaggedPersons;
            prop += "\nLocations: " + movie.Location;
            prop += "\nDuration: " + movie.Duration;
            MessageBox.Show(prop, "Properties", buttons);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            var movie = new ProjectClient().GetMovieById(((ModelDesignFirst_L1.Movie)comboBox2.SelectedItem).ID);
            var props = new ProjectClient().GetPropertiesByMediaID(movie.ID);
            var msj = "Movie: " + movie.MovieName;
            var propCodes = new ProjectClient().GetPropertyCodes();
            foreach (var prop in props)
            {
                var code = propCodes.FirstOrDefault(a => a.ID == prop.PropertyCodeID);
                msj += "\n" + code.Code + ": " + prop.Description;
            }
            MessageBox.Show(msj, "Special Properties", buttons);
        }
    }
}
