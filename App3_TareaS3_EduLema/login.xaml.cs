using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3_TareaS3_EduLema
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string sUsuario = txtUsuario.Text;
            string sPassword = txtPassword.Text;

            if ((sUsuario == "estudiante2021") && (sPassword == "uisrael2021"))
                {
                Navigation.PushAsync(new MainPage());
                }
            else
            {
                lblresultado.Text = "El Usuario o Password son incorrectos.";
            }



        }
    }
}