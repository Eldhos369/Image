using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exp123
{
    public partial class reg : Form
    {
        public static string add=0;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\source\repos\exp123\exp123\Database1.mdf;Integrated Security=True");
        PictureBox pb = new PictureBox();
        OpenFileDialog op = new OpenFileDialog();
        public reg()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pror_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            byte[] bt = File.ReadAllBytes(add.ImageLocation);
            cmd.CommandText = "INSERT INTO imge VALUES('" + id.Text + "',@pic)";
            SqlParameter sp = new SqlParameter("@pic", SqlDbType.VarBinary, bt.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, bt);
            cmd.Parameters.Add(sp);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved");
        }

        private void sel_Click(object sender, EventArgs e)
        {
            if (op.ShowDialog() == DialogResult.OK)
            {

                propic.Text = op.FileName.ToString();
                add = propic.Text;
                pb.ImageLocation = propic.Text;
            }
        }
    }
}
