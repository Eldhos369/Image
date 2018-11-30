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
using System.IO;

namespace exp11
{
    public partial class Form1 : Form
    {
        PictureBox pb = new PictureBox();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\source\repos\exp11\exp11\Database1.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            
            
            if (id.Text == null)
            {
                MessageBox.Show("Enter id");
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                byte[] bt= File.ReadAllBytes(pb.ImageLocation);
                cmd.CommandText = "INSERT INTO imge VALUES('" + id.Text + "',@pic)";
                SqlParameter sp = new SqlParameter("@pic", SqlDbType.VarBinary, bt.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, bt);
                cmd.Parameters.Add(sp);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Saved");
            }

        }

        private void sel_Click(object sender, EventArgs e)
        {
        
            OpenFileDialog op = new OpenFileDialog();
  
            if(op.ShowDialog()==DialogResult.OK)
            {
              
                tb.Text = op.FileName.ToString();
                pb.ImageLocation=tb.Text;
                
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            view f = new view();
            f.Show();
        }
    }
}
