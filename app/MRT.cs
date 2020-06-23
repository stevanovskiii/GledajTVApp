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
    public partial class MRT : Form
    {
        public MRT(Form3 parent)
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MRT.ActiveForm.Close();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"http://190.2.154.72:8081/tvstanici/5mob/playlist.m3u8";
            axWindowsMediaPlayer1.currentPlaylist = axWindowsMediaPlayer1.mediaCollection.getByName("");
            axWindowsMediaPlayer1.settings.volume = 100;
        }
    }
}
