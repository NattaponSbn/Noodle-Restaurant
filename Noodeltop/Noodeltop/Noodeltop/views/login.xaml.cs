using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using Noodeltop.Table;

namespace Noodeltop.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();

        }
        private void btn_register_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new register());
        }
        private void btn_login_clicked(object sender, EventArgs e)
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DBregister.db");
            var db = new SQLiteConnection(dbPath);
            var query = db.Table<Registeruser>().Where(u => u.username.Equals(e_user.Text) && u.password.Equals(e_password.Text)).FirstOrDefault();

            if (query != null)
            {
                Navigation.PushAsync(new home());
                DisplayAlert("เข้าสู่ระบบ", "เข้าสู่ระบบเรียบร้อยเเล้ว", "Yes");
            }
            else
            {
                DisplayAlert("เข้าสู่ระบบล้มเหลว", "เกอข้อผิดพลาดของระบบ", "Yes");
                Navigation.PushAsync(new login());

                
            }
        }
    }
}