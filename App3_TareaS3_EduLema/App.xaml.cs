using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3_TareaS3_EduLema
{
    public partial class App : Application
    {
        public static MasterDetailPage MAsterDet { get; set; }

        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new login());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
