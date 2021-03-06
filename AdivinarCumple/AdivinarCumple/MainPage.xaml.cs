using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AdivinarCumple
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (validacionUno.IsChecked == true)
            {
                DisplayAlert("PERFECTO!", "Sigue de esa manera", "Ok");
            }
        }

        private void btnCalculo_Clicked(object sender, EventArgs e)
        {
            try
            {
                double fechaResta = Double.Parse(resultado.Text) - 365;

                string fechaString = fechaResta.ToString();

                int tamano = fechaString.Length;

                if (tamano > 4)
                {
                    DisplayAlert("Haz hecho algo mal...", "Haz ingresado una cantidad incorrecta", "Volver a intentar");
                }
                else
                {
                    string dia = fechaString.Substring(0, 2);
                    string mes = fechaString.Substring(2, 2);

                    DisplayAlert("Tu fecha de nacimiento es... ", "DIA: " + dia + " MES: " + mes, "Ok");
                }

            }
            catch (System.Exception)
            {
                DisplayAlert("ERROR!", "Dato no valido, vuelve a intentarlo", "Entiendo");
            }

        }
    }
}
