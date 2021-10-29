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
    public partial class Parcial2 : ContentPage
    {
        public Parcial2()
        {
            InitializeComponent();
        }

        private async void btnCalculo2_Clicked(object sender, EventArgs e)
        {

            try
            {
                double notaDos = Convert.ToDouble(txtnotaDos.Text);
                double examen2 = Convert.ToDouble(txtexamen2.Text);
                double calculo1 = (notaDos * 0.3) + (examen2 * 0.2);
                txtnota2.Text = Convert.ToString(calculo1);
            }
            catch (Exception ex)
            {

                DisplayAlert("Mensaje de Advertencia", ex.Message, "OK");

            }

            await Navigation.PushAsync(new NotaFinal( txtnota2 ));



        }
    }
}