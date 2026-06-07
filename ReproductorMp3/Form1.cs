using WMPLib;
using System.IO;

namespace ReproductorMp3
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer reproductor = new WindowsMediaPlayer();
        private List<string> rutasArchivoMusica = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }
        private void findArchive_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscador = new OpenFileDialog();
            buscador.Filter = "Archivos de Audio|*.mp3;*.wav;*.wma";
            buscador.Multiselect = true;

            if (buscador.ShowDialog() == DialogResult.OK)
            {
                foreach (string rutaCompleta in buscador.FileNames)
                {
                    if (!rutasArchivoMusica.Contains(rutaCompleta))
                    {
                        rutasArchivoMusica.Add(rutaCompleta); 

                        string nombreCorto = Path.GetFileName(rutaCompleta);
                        listMusic.Items.Add(nombreCorto);
                    }
                }
            }
        }

        private void listMusic_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPlayMusic_Click(object sender, EventArgs e)
        {
            if (reproductor.playState == WMPPlayState.wmppsPaused)
            {
                reproductor.controls.play();
                timerMusic.Start();
            }
            else if (listMusic.SelectedIndex != -1)
            {
                int indiceSeleccionado = listMusic.SelectedIndex;
                reproductor.URL = rutasArchivoMusica[indiceSeleccionado];

                reproductor.controls.play();
                timerMusic.Start(); 
            }
            else
            {
                MessageBox.Show("Selecciona una camcion primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            reproductor.controls.pause();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                barProgress.Maximum = (int)reproductor.currentMedia.duration;

                barProgress.Value = (int)reproductor.controls.currentPosition;

                lblTimerSong.Text = reproductor.controls.currentPositionString;

                lblSongDuration.Text = reproductor.currentMedia.durationString;
            }
        }

        private void barProgress_Scroll(object sender, EventArgs e)
        {
            if (reproductor.currentMedia != null)
            {
                reproductor.controls.currentPosition = barProgress.Value;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void barProgress_MouseDown(object sender, MouseEventArgs e)
        {
            timerMusic.Stop();
        }

        private void barProgress_MouseUp(object sender, MouseEventArgs e)
        {
            reproductor.controls.currentPosition = barProgress.Value;

            if (reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                timerMusic.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnQuitMusic_Click(object sender, EventArgs e)
        {

        }
    }
}
