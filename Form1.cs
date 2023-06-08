using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace danhnhaplan5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text=="")
            {
                MessageBox.Show("Nhap ten nguoi dung");
            }
            else if(textBox2.Text=="")
            {
                MessageBox.Show("Nhap mat khau ");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-P3L3PMG\\LINH;Initial Catalog=dangnhap;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand(" select * from tbl_login where username = @Username and password = @Password", con);
                    cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                da.Fill(dt);

                    if(dt.Rows.Count > 0)
                    {
                        MessageBox.Show(" dang nhap thanh cong");
                    }
                    else
                    {
                        MessageBox.Show(" ten dang nhap hoac mat khau sai");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
