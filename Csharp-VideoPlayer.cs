using System;
using System.Windows.Forms;
using System.IO;
using WMPLib;

namespace VideoPlayer
{
    public partial class MainForm : Form
    {
        private WindowsMediaPlayer mediaPlayer;
        
        public MainForm()
        {
            InitializeComponent();
            mediaPlayer = new WindowsMediaPlayer();
        }
        
        private void SelectVideoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video Files (*.mp4;*.avi;*.mkv)|*.mp4;*.avi;*.mkv|All files (*.*)|*.*";
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedVideoPath = openFileDialog.FileName;
                mediaPlayer.URL = selectedVideoPath;
            }
        }
        
        private void PlayButton_Click(object sender, EventArgs e)
        {
            mediaPlayer.controls.play();
        }
        
        private void PauseButton_Click(object sender, EventArgs e)
        {
            mediaPlayer.controls.pause();
        }
        
        private void SpeedTrackBar_Scroll(object sender, EventArgs e)
        {
            mediaPlayer.settings.rate = SpeedTrackBar.Value / 10.0;
        }
        
        private void VolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            mediaPlayer.settings.volume = VolumeTrackBar.Value;
        }
    }
}
