using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Kanal5 : Form
    {

        public Kanal5(Form3 parent)
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kanal5.ActiveForm.Close();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"http://51.89.67.64:8081/tvstanici/2/playlist.m3u8";
            axWindowsMediaPlayer1.currentPlaylist = axWindowsMediaPlayer1.mediaCollection.getByName("");
            axWindowsMediaPlayer1.settings.volume = 100;
        }

        private void Kanal5_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.autoStart = true;
        }
    }
}
