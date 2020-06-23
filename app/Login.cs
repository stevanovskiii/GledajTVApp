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

namespace app
{
    public partial class Login : Form
    {
        String promenliva = @"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True; AttachDbFilename=C:\Users\Rade\Desktop\app\app\Login.mdf;Connect Timeout=30";
        public Login()
        {
            InitializeComponent();
        }
        public Login(Form3 parent)
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "")
            {
                MessageBox.Show("Мора да внесите Корисничко Име", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt1.Focus();
                return;
            }
            if (txt2.Text == "")
            {
                MessageBox.Show("Мора да внесите Лозинка", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt2.Focus();
                return;
            }
            try
            {
                SqlConnection konekcija = default(SqlConnection);
                konekcija = new SqlConnection(promenliva);

                SqlCommand komanda = default(SqlCommand);

                komanda = new SqlCommand("SELECT KorisnickoIme,Lozinka FROM Korisnici WHERE KorisnickoIme = @KorisnickoIme AND Lozinka = @Lozinka", konekcija);

                SqlParameter KorisnickoIme = new SqlParameter("@KorisnickoIme", SqlDbType.VarChar);
                SqlParameter Lozinka = new SqlParameter("@Lozinka", SqlDbType.VarChar);

                KorisnickoIme.Value = txt1.Text;
                Lozinka.Value = txt2.Text;

                komanda.Parameters.Add(KorisnickoIme);
                komanda.Parameters.Add(Lozinka);

                komanda.Connection.Open();

                SqlDataReader cita = komanda.ExecuteReader(CommandBehavior.CloseConnection);

                if (cita.Read() == true)
                {
                    MessageBox.Show("Успрешно се најавивте " + txt1.Text);
                    Form3 forma = new Form3(this);
                    forma.Show();
                    this.Hide();
                }


                else
                {
                    MessageBox.Show("Погрешно корисничо име и лозинка!", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txt1.Clear();
                    txt2.Clear();
                    txt1.Focus();

                }
                if (konekcija.State == ConnectionState.Open)
                {
                    konekcija.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Проблем", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   

        private void button1_Click(object sender, EventArgs e)
        {
            string KonekcijaString = null;
            string baza = null;

            KonekcijaString = @"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True; AttachDbFilename=C:\Users\Rade\Desktop\app\app\Login.mdf;Connect Timeout=30";

            baza = "insert into Korisnici ([KorisnickoIme], [Lozinka]) values(@KorisnickoIme,@Lozinka)";

            using (SqlConnection povrzuvanje = new SqlConnection(KonekcijaString))
            {
                try
                {
                    povrzuvanje.Open();

                    using (SqlCommand komanda1 = new SqlCommand(baza, povrzuvanje))
                    {
                        komanda1.Parameters.Add("@KorisnickoIme", SqlDbType.NVarChar).Value = regtxt1.Text;
                        komanda1.Parameters.Add("@Lozinka", SqlDbType.NVarChar).Value = regtxt2.Text;

                        int dodajnovred = komanda1.ExecuteNonQuery();
                        if (dodajnovred > 0)
                            MessageBox.Show("Успрешно се регистриравте сега може да се најавите во формата за најави се");
                        else
                            MessageBox.Show("Неуспешна регистрација, пробајте повторно");

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Грешка:" + ex.Message);
                }
            }
        }
    }
}
