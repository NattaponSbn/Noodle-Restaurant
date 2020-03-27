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
    public partial class order : Form
    {
        string noode;
        string stape;
        string waters;
        string price;
        SQLiteConnection con = new SQLiteConnection("Data Source=C:/Users/OHMME/Desktop/VS2/Database/DBmenu.db;");
        public order()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checksmall_CheckedChanged(object sender, EventArgs e)
        {
            noode = " เส้นเล็ก ";
        }

        private void checkbig_CheckedChanged(object sender, EventArgs e)
        {
            noode = "เส้นใหญ่";
        }

        private void checkyellow_mein_CheckedChanged(object sender, EventArgs e)
        {
            noode = "หมี่เหลือง";
        }

        private void checkpig_CheckedChanged(object sender, EventArgs e)
        {
            stape = "หมู";
        }

        private void checkchicken_CheckedChanged(object sender, EventArgs e)
        {
            stape = "ไก่";
        }

        private void checkmeat_CheckedChanged(object sender, EventArgs e)
        {
            stape = "เนื้อ";
        }

        private void checkentrails_CheckedChanged(object sender, EventArgs e)
        {
            stape = "เครื่องใน";
        }

        private void checksea_CheckedChanged(object sender, EventArgs e)
        {
            stape = "ทะเล";
        }

        private void checksums_CheckedChanged(object sender, EventArgs e)
        {
            stape = "รวม";
        }

        private void checkclear_water_CheckedChanged(object sender, EventArgs e)
        {
            waters = " น้ำใส ";
        }

        private void checkwaterfall_CheckedChanged(object sender, EventArgs e)
        {
            waters = " น้ำตก ";
        }

        private void checkhot_CheckedChanged(object sender, EventArgs e)
        {
            waters = " ต้มยำ ";
        }

        private void checkyentafo_CheckedChanged(object sender, EventArgs e)
        {
            waters = " เย็นตาโฟ ";
        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checklot.Checked == true)
            {
                price = "50";
            }
            else
            {
                price = "40";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textboxsum.Text == "") 
            {
                MessageBox.Show("กรุณากรอกจำนวน");
            }
            string query = "INSERT INTO Menu(noodle, staple, water, price, number) VALUES('" + noode + "', '" + stape + "', '" + waters + "', '"+ price + "', '"+ textboxsum.Text + "')";
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("สั่งซื้อเรียบร้อย");
            home hom = new home();
            hom.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
