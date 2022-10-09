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

namespace Lecteurmp32
{
    public partial class mouk : Form
    {
        public mouk()
        {
            InitializeComponent();
            track_Volume.Value = 50;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
        // créer la variable string
        string[] paths, files;
        private void button1_Click_3(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); // ouvrir la fenêtre pour les fichiers
            ofd.Multiselect = true; // permettre le multiselect
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) // quand l'information est retournée
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for ( int x=0;x < files.Length; x++)
                {
                    track_list.Items.Add(files[x]);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[track_list.SelectedIndex];
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsPlaying)
            {
                pBar.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                pBar.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            }
            try
            {
                start_song_label.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                end_song_label.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString.ToString();
            }
            catch
            {

            }
        }

        private void track_Volume_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = track_Volume.Value;
            label_volume.Text = axWindowsMediaPlayer1.settings.volume.ToString() + "%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
