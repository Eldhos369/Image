using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exp123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            reg r = new reg();
            if(username.Text=="admin"&&password.Text=="admin")
            {
                r.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username OR password");
                username.Clear();
                password.Clear();
            }
        }
    }
}
