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
    public partial class NotaFinal : ContentPage
    {
        private Entry txtnota2;
        private Entry txtnota1;

        public NotaFinal()
        {
        }

        public NotaFinal(Entry txtnota1)
        {
            this.txtnota1 = txtnota1;
        }

        public NotaFinal(Entry txtnota2, Entry txtnota1)
        {
            this.txtnota2 = txtnota2;
            this.txtnota1 = txtnota1;
        }

        

        public NotaFinal(string nota1,string nota2  )
        {
            InitializeComponent();
        }

        private async void btnnotafinal_Clicked(object sender, EventArgs e)
        {

            try
            {

                double nota1 = Convert.ToDouble(txtnota1.Text);
                double nota2 = Convert.ToDouble(txtnota2.Text);
                double notafinal = nota1 + nota2;
                txtNotaFinal.Text = Convert.ToString(notafinal);

                if (notafinal >= 7)
                {

                    txtestado.Text = "APROBADO";

                }
                else
                {
                    if (notafinal >= 5)
                    {
                        txtestado.Text = "COMPLEMENTARIO";
                    }
                    else
                    {
                        if (notafinal < 5)
                        {
                            txtestado.Text = "REPROBADO";
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                DisplayAlert("Mensaje de Advertencia", ex.Message, "OK");

            }

        }
    }
}