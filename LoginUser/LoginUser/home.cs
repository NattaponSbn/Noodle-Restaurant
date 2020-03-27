using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginUser
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            order od = new order();
            this.Hide();
            od.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            login loge = new login();
            this.Hide();
            loge.Show();
            
        }
    }
}
