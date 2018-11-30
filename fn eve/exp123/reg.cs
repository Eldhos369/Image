using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exp123
{
    public partial class reg : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Image-masterq\Image-master\exp123\exp123\Database1.mdf;Integrated Security=True");
        PictureBox pb = new PictureBox();
        OpenFileDialog op = new OpenFileDialog();
        public reg()
        {
            InitializeComponent();
            gb.Hide();
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
        private void sel_Click(object sender, EventArgs e)
        {
            if (op.ShowDialog() == DialogResult.OK)
            {

                propic.Text = op.FileName.ToString();

                pb.ImageLocation = propic.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string theDate = dob.Value.ToString("yyyy-MM-dd");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
                cmd.CommandType = CommandType.Text;
                byte[] bt = File.ReadAllBytes(pb.ImageLocation);
                SqlParameter sp = new SqlParameter("@pic", SqlDbType.VarBinary, bt.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, bt);

                cmd.CommandText = "INSERT INTO tab1 VALUES('" + id.Text + "','" + name.Text + "','" + sec.Text + "','" + br.Text + "','" + theDate + "',@pic)";
                cmd.Parameters.Add(sp);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Saved");
            reset();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "SELECT name,sec,branch,dob FROM tab1 WHERE id='"+ids.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable sdt = new DataTable();
            sda.Fill(sdt);
            if (sdt.Rows.Count>0)
            {

                using (SqlDataReader sr = cmd.ExecuteReader())
                {
                    
                    gb.Show();
                    gb.Text = ids.Text;
                    sr.Read();
                    namer.Text = sr[0].ToString();
                    string sec = sr[1].ToString();
                    string branch = sr[2].ToString();
                    dobr.Text = sr[3].ToString();
                    secr.Text = sec + branch;

                }

                string str = "SELECT img FROM tab  WHERE Id='" + ids.Text + "'";
                SqlDataAdapter sd = new SqlDataAdapter(str, con);
                DataSet ds = new DataSet();
                sd.Fill(ds);
                
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])(ds.Tables[0].Rows[0]["img"]));
                    pror.Image = new Bitmap(ms);

                }

            }
            else
            {
                MessageBox.Show("ID not found");
            }
            
            con.Close();
            
        }

        private void reg_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 d = new Form1();
            d.Show();
        }
        public void reset()
        {
            id.Clear();
            name.Clear();
            sec.ResetText();
            br.ResetText();
            propic.Clear();
        }
    }
}
