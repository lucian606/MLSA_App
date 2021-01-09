using MLSA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MLSA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void SignInProcedure(Object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.IsValid())
            {
                DisplayAlert("Login", "Login Success", "Okay");
            } else
            {
                DisplayAlert("Login", "Login Fail", "Okay");
            }
        }
    }
}