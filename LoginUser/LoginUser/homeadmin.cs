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
    public partial class homeadmin : Form
    {
        
        public homeadmin()
        {
            InitializeComponent();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=C:/Users/OHMME/Desktop/VS2/Database/DBmenu.db;");
            conn.Open();
            string query = "SELECT * from Menu";
            SQLiteCommand cmdd = new SQLiteCommand(query, conn);

            DataTable dtb = new DataTable();
            SQLiteDataAdapter dap = new SQLiteDataAdapter(cmdd);
            dap.Fill(dtb);

            dataGridView.DataSource = dtb;
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=C:/Users/OHMME/Desktop/VS2/Database/DBregister.db;");
            con.Open();
            string query = "SELECT * from register";
            SQLiteCommand cmdd = new SQLiteCommand(query, con);

            DataTable dtb = new DataTable();
            SQLiteDataAdapter dap = new SQLiteDataAdapter(cmdd);
            dap.Fill(dtb);

            dataGridView.DataSource = dtb;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            login loh = new login();
            this.Hide();
            loh.Show();
        }
    }
}
