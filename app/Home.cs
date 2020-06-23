using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace app
{
    public partial class Form3 : Form
    {
        System.Timers.Timer timer;

        public Form3(Login parent)
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Sitel forma = new Sitel(this);
            forma.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Kanal5 forma = new Kanal5(this);
            forma.Show();
        }
        //Odjavuvanje i ja pokazuva Login formata
        private void odjse_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Close();
            Login forma = new Login(this);
            forma.Show();
            
        }
        // Izlez i gasnenje na aplikacijata
        private void излезToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            System.Windows.Forms.Application.Exit();
        }
        //Obicni eventi kade site ostanati formi se povikuvaat da se prikazat za site istoto
        private void telma_Click(object sender, EventArgs e)
        {
            Telma forma = new Telma(this);
            forma.Show();
        }

        private void otvori2menu_Click(object sender, EventArgs e)
        {
            MRT forma = new MRT(this);
            forma.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Kanal5 forma = new Kanal5(this);
            forma.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Sitel forma = new Sitel(this);
            forma.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Telma forma = new Telma(this);
            forma.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MRT forma = new MRT(this);
            forma.Show();
        }
        // Intervalot na tajmerot 
        private void Form3_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }
        //Gi zema momentalnoto vreme i data i gi sporeduva istite so vremeto na sistemot i dava poraka
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DateTime currentTime = System.DateTime.Now;
            DateTime userTime = dateTimePicker.Value;
            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            {
                timer.Stop();
                System.Windows.MessageBox.Show("Ве известуваме за поставениот потсетник, уживајте во гледањето на тв!", "Потсетник!");
            }
        }
        //Startuvanje na tajmerot i promena na labelata
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
            lblStatus.Text = "Потсетникот е поставен";
        }
        //Stopiranje na tajmerot
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lblStatus.Text = "Потсетникот е во прекин";
        }
        //Obicno prikazuvanje na komentarot od textboxot vo dr textbox kade ne e dozvoleno izmeni
        private void dodajTextbtn_Click(object sender, EventArgs e)
        {
            prikaziKom.Text = dodavanjeKom.Text;
        }
    }
}
