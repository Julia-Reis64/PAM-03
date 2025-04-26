using System;

namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {
        Vitorias victory = new Vitorias();

        public MainPage()
        {
            InitializeComponent();
        }

        private void FlipButton_Clicked(object sender, EventArgs e)
        {
            //Algoritmo
            //Verificar qual opção selecionada (if alguma coisa)
            //Fazer o sorteio da moeda (Random, 1 e 2)
            //Exibir o lado que foi sorteado (Image.Source = "-.png")
            //Verificar se a opção é igual o lado (if)
            //Exibir o resultado do jogo em um alerta (DisplayAlert)

            /* Random random = new Random();
                int Sorteio = random.Next(2);
                   if (Sorteio == 0){
                    MoedaImagem.Source = "cara.png";
                    }
                   else{
                    Sorteio = 1;
                    MoedaImagem.Source = "coroa.png";
                    } */

            Coin moeda = new Coin();
            MoedaImagem.Source = moeda.Flip()+".png";

            if (moeda.LadoSorteado == "cara")
            {
                ExibirAlerta(0);
            }
            else{
                ExibirAlerta(1);
            }

            TotalVitoriasLabel.Text = $"Você ganhou {victory.TotalVitorias} vezes ao todo.";
            VitoriasSequencia.Text = $"Você ganhou {victory.VitoriaSequencia} vezes em sequencia";
        }

        public async void ExibirAlerta(int Sorteio){
            if (FlipCoin.SelectedIndex == Sorteio){
                await DisplayAlert("Parabéns", "você venceu!", "Ok!");
            }
            else{
               await DisplayAlert("Perdeste!", "poxa vida", "Ok!");
            }
        }

        //Demonstrador de vitórias
        //PlayerPointLabel.Text = $"Você ganhou {jogo.PlayerPoint} vezes ao todo.";
        //StreakLabel.Text = $"Você ganhou {jogo.Streak} vezes em sequencia."; */
        /*
        public async void Sequencia(int victory){
            TotalVitoriasLabel.Text = $"Você ganhou {victory.TotalVitorias} vezes ao todo.";
            VitoriasSequencia.Text = $"Você ganhou {victory.VitoriasSequencia} vezes em sequencia";
        }
        */

    }

}
