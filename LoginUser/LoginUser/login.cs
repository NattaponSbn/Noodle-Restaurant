using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace LoginUser
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string user = text_user.Text.Trim();
            string pass = text_pass.Text.Trim();
            order hme = new order();
            
            if (user == "" && pass == "")
            {
                MessageBox.Show("กรุณาเช็คชื่อผู้ใช้เเละรหัสผ่าน");
            }
            else 
            {
                if (user == "admin" && pass == "0000")
                {
                    MessageBox.Show("เข้าสู่ระบบเรียบร้อย");
                    homeadmin had = new homeadmin();
                    this.Hide();
                    had.Show();
                }
                else 
                {
                    SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:/Users/OHMME/Desktop/VS2/Database/DBregister.db;");
                    string query = "SELECT * from register Where username = '" + user + "' and password = '" + pass + "'";
                    conn.Open();
                    SQLiteCommand cmdd = new SQLiteCommand(query, conn);
                    DataTable dt = new DataTable();
                    SQLiteDataAdapter sda = new SQLiteDataAdapter(cmdd);
                  
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        home hom = new home();
                        this.Hide();
                        hom.Show();
                    }
                    else
                    {
                        MessageBox.Show("กรุณาเช็คชื่อผู้ใช้เเละรหัสผ่าน");
                    }
                }   
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            register reg = new register();
            reg.Show();
            this.Hide();
            
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
