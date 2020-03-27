using Noodeltop.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace Noodeltop.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class orderpage : ContentPage
    {
        public orderpage()
        {
            InitializeComponent();

        }
        CheckBox checkBox = new CheckBox { IsChecked = true };
        void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            // Perform required operation after examining e.Value
        }
        void border(object sender, System.EventArgs e)
        {
            
            DisplayAlert("เเจ้งเตือน", "สมัครสมาชิกเรียบร้อย", "ตกลง");
            Navigation.PushAsync(new login());

            DisplayAlert("สั่งซื้อเรียบร้อย", "กรุณารอสักครู่...", "ตกลง");
            Navigation.PushAsync(new home());



        }




    }
}