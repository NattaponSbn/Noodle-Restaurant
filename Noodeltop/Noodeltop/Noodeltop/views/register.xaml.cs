using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


using System.Threading.Tasks;
using System.IO;
using SQLite;

using Xamarin.Forms.Internals;
using Noodeltop.Table;

namespace Noodeltop.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class register : ContentPage
    {
       
        public register()
        {
            InitializeComponent();
        }
        void btnregister(object sender, System.EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DBregister.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<Registeruser>();
            var userRe = new Registeruser()
            {
                name = e_name.Text,
                email = e_em.Text,
                username = e_uname.Text,
                password = entry_pass.Text,
                passwordag = entry_passag.Text
            };
            db.Insert(userRe);
            DisplayAlert("เเจ้งเตือน", "สมัครสมาชิกเรียบร้อย", "ตกลง"); 
            Navigation.PushAsync(new login());
            
        }

        private Task DisplayAlert(string v, string v1)
        {
            throw new NotImplementedException();
        }
    }
}