using System;

namespace CalculadoraIMC_MALH
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Altura.Text) &&
                !string.IsNullOrEmpty(Peso.Text) &&
                !string.IsNullOrEmpty(Latidos.Text))
            {

                var altura = double.Parse(Altura.Text);
                var peso = double.Parse(Peso.Text);

                var imc = peso / (altura * altura);
                IMC.Text = imc.ToString("F2"); 

                string resultadoIMC = "";
                if (imc < 18.5)
                {
                    resultadoIMC = "Tienes bajo peso";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    resultadoIMC = "Tu peso es normal";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    resultadoIMC = "Tienes sobre peso";
                }
                else
                {
                    resultadoIMC = "Tienes obesidad, cuidate!";
                }


                var latidos = double.Parse(Latidos.Text);
                var fc = latidos * 4; 
                FrecuenciaCardiaca.Text = fc.ToString();

                string resultadoFC = "";
                if (fc < 60)
                {
                    resultadoFC = "Frecuencia cardiaca baja";
                }
                else if (fc > 100)
                {
                    resultadoFC = "Frecuencia cardiaca alta";
                }
                else
                {
                    resultadoFC = "Frecuencia cardiaca normal";
                }


                string mensajeFinal = $"IMC: {resultadoIMC}\nFrecuencia Cardíaca: {resultadoFC} ({fc} bpm)";
                DisplayAlert("Resultado:", mensajeFinal, "Quitar");
            }
            else
            {
                DisplayAlert("Datos erroneos", "Por favor, llena toda la informacion", "Quitar");
            }
        }
    }
}
