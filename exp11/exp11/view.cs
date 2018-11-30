using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exp11
{
    public partial class view : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\source\repos\exp11\exp11\Database1.mdf;Integrated Security=True");
        public view()
        {
            InitializeComponent();
        }

        private void get_Click(object sender, EventArgs e)
        {
            
                con.Open();
            // SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            string str = "SELECT * FROM imge  WHERE Id='" + int.Parse(id.Text) + "'";
            SqlDataAdapter sd = new SqlDataAdapter(str, con);
            //DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            sd.Fill(ds);
            //byte[] mydata = new byte[0];
            //mydata = (byte[])dt.Rows[0][1];
            //MemoryStream ms = new MemoryStream(mydata);
            //pb.Image = Image.FromStream(ms);
            if(ds.Tables[0].Rows.Count>0)
            {
                //mydata = (byte[])dt.Rows[0][1];
                MemoryStream ms = new MemoryStream((byte[])(ds.Tables[0].Rows[0][1]));
                pb.Image = new Bitmap(ms);
            }
            con.Close();
            
                //Retrieve BLOB from database into DataSe
                
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            Image returnImage ;
            //try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                returnImage = Image.FromStream(ms, true);//Exception occurs here
            }
            //catch { }*/
            return returnImage;
        }

        private void view_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.imge' table. You can move, or remove it, as needed.
            this.imgeTableAdapter.Fill(this.database1DataSet.imge);

        }

        private void DEL_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from imge where Id='" + int.Parse(id.Text) + "'";
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
