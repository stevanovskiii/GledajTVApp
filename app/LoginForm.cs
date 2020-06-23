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
    public partial class LoginForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (txt1.Text == "demo" && txt2.Text == "demo")
                {
                Form3 forma = new Form3(this);
                    forma.Show();
                }
                else
                {
                    MessageBox.Show("NAJAVI SE");
                }
            
        }
    }
}
