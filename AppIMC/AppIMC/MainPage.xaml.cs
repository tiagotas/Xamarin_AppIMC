using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppIMC
{
    // Descrevemos a criação de uma classe na Aula 2, AppCambio
    public partial class MainPage : ContentPage
    {
        // Descrevemos a função do método construtor na Aula 2, AppCambio
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Laço try catch, conceito visto na Aula 2, AppCambio
            try
            {
                /**
                 * Também já vimos o procedimento de Parse (conversão de valores)
                 * na Aula 2 AppCambio, mas aqui estamos convertendo para outro tipo:
                 * números com ponto do tipo Double
                 */
                double peso = Double.Parse(txt_peso.Text);
                double altura = Double.Parse(txt_altura.Text);

                /**
                 * Aqui está a implementação da fórmula do IMC:
                 * "Peso dividido pela altura ao quadrado"
                 */ 
                double imc = peso / (altura * altura);

                /**
                 * Inicializamos uma váriavel do tipo string (caracter) para armazenar qual será
                 * a mensagem  ser mostrada ao usuário, conforme o reusltado do cálculo do IMC.
                 */ 
                string classificacao = "";


                /**
                 * Aqui começamos uma sequência de if (se) e de else (senão) juntamente com o 
                 * operador lógico AND (&&). Também estamos utilizanos os operadores:
                 *  > "maior que"
                 *  < "menor que"
                 *  >= "maior igual"
                 * Lê-se da seguinte maneira, por exemplo:
                 *    " Se imc maior ou igual a 17 E imc menor que 18.49, faça "
                 */ 
                if (imc < 17)
                {
                    classificacao = "Muito abaixo do peso";

                } else if (imc >= 17 && imc < 18.49)
                {
                    classificacao = "Abaixo do peso";

                } else if (imc >= 18.5 && imc < 24.99)
                {
                    classificacao = "Peso normal";

                } else if(imc >= 25 && imc < 29.99)
                {
                    classificacao = "Acima do peso";

                } else if (imc >= 30 && imc < 34.99)
                {
                    classificacao = "Obesidade I";

                } else if (imc >= 35 && imc < 39.99)
                {
                    classificacao = "Obesidade II (severa)";
                }
                else if (imc >= 40)
                {
                    classificacao = "Obesidade III (mórbida)";
                }

                /**
                 * Aqui estamos mostrando o resultado para o usuário, veja que estamos utilizando
                 * o recurso de concatenação, com o sinal de soma: +
                 * Como se tratam de strings o C# entende que é para juntar ambas.
                 * Outro ponto importante é o método ToString, que estamos passando: 0.00, que diz
                 * que teremos duas casas decimais após a vírgula.
                 * Nas duas linhas seguintes estmaos formatando eleentos do Label resultado, como
                 * a cor do texto: Color.Red e o alinhamento do texto no centro.
                 */ 
                resultado.Text = "Seu IMC é " + imc.ToString(("0.00")) + " está " + classificacao;
                resultado.TextColor = Color.Red;
                resultado.HorizontalTextAlignment = TextAlignment.Center;

            } catch(Exception ex)
            {
                // Se caso tivermos algum erro, ele será mostrado no Label de resultado.
                resultado.Text = "Desculpe, ocorreu um erro \n " + ex.Message;
            }
        }
    }
}
