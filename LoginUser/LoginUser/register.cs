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
    public partial class register : Form
    {
        
        public register()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (text_user.Text == "" && text_email.Text == "" && textnameuser.Text == "" && textpass.Text == "" && textpassag.Text == "") 
            {
                MessageBox.Show("กรุณากรอกข้อมูล");
                return;
            }
            SQLiteConnection con = new SQLiteConnection("Data Source=C:/Users/OHMME/Desktop/VS2/Database/DBregister.db;") ;
            string query = "INSERT INTO register(name, email, username, password, passwordag) VALUES('" + text_user.Text + "','"+ text_email.Text + "', '" + textnameuser.Text + "', '" + textpass.Text + "', '" + textpassag.Text + "') ";

            SQLiteCommand cmd = new SQLiteCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("สมัครสมาชิกเรียบร้อย");
            login loge = new login();
            loge.Show();
            this.Hide();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            text_user.Clear();
            text_email.Clear();
            textnameuser.Clear();
            textpass.Clear();
            textpassag.Clear();
        }
    }
}
