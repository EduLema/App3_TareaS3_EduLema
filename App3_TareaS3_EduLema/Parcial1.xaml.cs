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
    public partial class Parcial1 : ContentPage
    {
        public Parcial1()
        {
            InitializeComponent();
        }

        private async void btnCalculo_Clicked(object sender, EventArgs e)
        {
            
            try
            {
                double notaUno = Convert.ToDouble(txtnotaUno.Text);
                double examnen1 = Convert.ToDouble(txtexamen1.Text);

                double calculo = (notaUno * 0.3) + (examnen1 * 0.2);

                txtnota1.Text = Convert.ToString(calculo);
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Advertencia", ex.Message, "OK");
            }

            await Navigation.PushAsync(new NotaFinal(txtnota1));






        }
    }
}