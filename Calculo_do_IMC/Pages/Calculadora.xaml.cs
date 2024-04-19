namespace Calculo_do_IMC.Pages;

public partial class Calculadora : ContentPage
{
	public Calculadora()
	{
		InitializeComponent();
	}

    private void Calcular_Clicked(object sender, EventArgs e)
    {
        double altura = 0;
        double peso = 0;
        bool pesoCerto = Double.TryParse(Peso.Text, out peso);
        bool alturaCerta = Double.TryParse(Altura.Text, out altura);
        if (!pesoCerto || !alturaCerta)
        {
            DisplayAlert("Aviso!", "Altura ou peso inválidos!", "Ok");
        }

        else if (peso != 0 && altura != 0)
        {
            altura = altura / 100;

            var imc = peso / (altura * altura);

            Resultado.Text = imc.ToString("F2");

            if (imc <= 18.5)
            {
                Grau.Text = "Abaixo do peso ideal!";
            }

            if (imc > 18.5 && imc < 25)
            {
                Grau.Text = "Peso ideal!";
            }

            if (imc >= 25 && imc < 30)
            {
                Grau.Text = "Levemente acima do peso!";
            }

            if (imc >= 30 && imc < 35)
            {
                Grau.Text = "Obesidade de grau I";
            }

            if (imc >= 35 && imc < 40)
            {
                Grau.Text = "Obesidade de grau II";
            }

            if (imc >= 40)
            {
                Grau.Text = "Obesidade de grau III";
            }
        }
        else
        {
            DisplayAlert("Aviso!", "Altura ou peso não podem ser zero!", "Ok");
        }
    }


}

